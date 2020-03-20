using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ScreenCaptureTool
{
    public partial class Form1 : Form
    {
        private static NotifyIcon NIcon;
        private static HotKey HK;
        private static TimerSet TS;
        private static ScreenCapture SC;
        private static string SavePath = string.Empty;
        private static emMutipleScreenMode MutipleScreenMode;
        private static emTimerCaptureMode TimerCaptureMode;
        private static DateTime SetTime;
        private static DateTime SetTimeFrom;
        private static DateTime SetTimeTo;
        private static int FreqMin;
        private static DateTime CaptureTime;

        private enum emMutipleScreenMode
        {
            [EnumMember]
            Combine = 0,

            [EnumMember]
            Seperate = 1
        }

        private enum emTimerCaptureMode
        {
            [EnumMember]
            OnTime = 0,

            [EnumMember]
            FromTo = 1
        }

        #region [Initial]
        public Form1()
        {
            InitializeComponent();
            RegisterHotKey();
            Initial();
        }

        private void RegisterHotKey()
        {
            if (null != HK)
            {
                HK.Dispose();                                           //取消熱鍵
            }
            HK = new HotKey(this.Handle, Keys.PrintScreen, Keys.None);  //註冊[PrintScreen]為熱鍵, 如果不要組合鍵請傳Keys.None當參數
            HK.OnHotkey += new HotKey.HotkeyEventHandler(Hotkey_Click); //HotKey事件
        }

        protected void Initial()
        {
            MutipleScreenMode = emMutipleScreenMode.Combine;
            TimerCaptureMode = emTimerCaptureMode.OnTime;
            NIcon = new NotifyIcon(this.components);
            TS = new TimerSet();
            SC = new ScreenCapture();

            //Btn_Folder_Click(null, null);
            //this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region [GUI]
        private void GUILock()
        {
            switch (TimerCaptureMode)
            {
                case emTimerCaptureMode.OnTime:
                    Pl_OnTime.Enabled = false;
                    break;

                case emTimerCaptureMode.FromTo:
                    Pl_FromTo.Enabled = false;
                    break;
            }

            Pl_TimerMode.Enabled = false;
            Btn_Start.Enabled = false;
            Btn_Stop.Enabled = true;
            Btn_Folder.Enabled = false;
        }

        private void GUIRelease()
        {
            switch (TimerCaptureMode)
            {
                case emTimerCaptureMode.OnTime:
                    Pl_OnTime.Enabled = true;
                    break;

                case emTimerCaptureMode.FromTo:
                    Pl_FromTo.Enabled = true;
                    break;
            }

            Pl_TimerMode.Enabled = true;
            Btn_Start.Enabled = true;
            Btn_Stop.Enabled = false;
            Btn_Folder.Enabled = true;
        }

        private void NumericUpDown_Select(NumericUpDown objNumericUpDown)
        {
            objNumericUpDown.Select(0, objNumericUpDown.Value.ToString().Length);
        }
        #endregion

        #region [Event]
        private void Hotkey_Click(object sender, HotKeyEventArgs e)
        {
            if (!CheckSavePath(SavePath))
            {
                return;
            }

            InvokeCapture();
        }

        private void Btn_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select Save Path";
            dialog.SelectedPath = string.Empty;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Txt_SavePath.Text = dialog.SelectedPath;
                SavePath = dialog.SelectedPath;
            }

            dialog.Dispose();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (!CheckSavePath(SavePath))
            {
                return;
            }

            GUILock();
            TimerStart();
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            TimerStop();
            GUIRelease();
        }

        private void Rb_Combine_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Combine.Checked)
            {
                MutipleScreenMode = emMutipleScreenMode.Combine;
            }
            else
            {
                MutipleScreenMode = emMutipleScreenMode.Seperate;
            }
        }

        private void Rb_OnTime_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_OnTime.Checked)
            {
                TimerCaptureMode = emTimerCaptureMode.OnTime;
                Pl_OnTime.Enabled = true;
                Pl_FromTo.Enabled = false;
            }
            else
            {
                TimerCaptureMode = emTimerCaptureMode.FromTo;
                Pl_OnTime.Enabled = false;
                Pl_FromTo.Enabled = true;
            }

            Num_H.Value = 0;
            Num_M.Value = 0;
            Num_FromH.Value = 0;
            Num_FromM.Value = 0;
            Num_ToH.Value = 0;
            Num_ToM.Value = 0;
            Num_FreM.Value = 1;
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;   //還原視窗
        }

        private void ToolStripMenuItem_ExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItem_RestoreClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;   //還原視窗
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    this.ShowInTaskbar = true;  //程式在工具列中顯示
                    break;

                case FormWindowState.Minimized:
                    this.ShowInTaskbar = false; //程式在工具列中隱藏
                    break;
            }

            RegisterHotKey();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SC.Dispose();
            TS.Dispose();
            NIcon.Dispose();
            HK.Dispose();
        }

        private void Num_H_Enter(object sender, EventArgs e)
        {
            NumericUpDown_Select(Num_H);
        }

        private void Num_M_Enter(object sender, EventArgs e)
        {
            NumericUpDown_Select(Num_M);
        }

        private void Num_FromH_Enter(object sender, EventArgs e)
        {
            NumericUpDown_Select(Num_FromH);
        }

        private void Num_FromM_Enter(object sender, EventArgs e)
        {
            NumericUpDown_Select(Num_FromM);
        }

        private void Num_ToH_Enter(object sender, EventArgs e)
        {
            NumericUpDown_Select(Num_ToH);
        }

        private void Num_ToM_Enter(object sender, EventArgs e)
        {
            NumericUpDown_Select(Num_ToM);
        }

        private void Num_FreM_Enter(object sender, EventArgs e)
        {
            NumericUpDown_Select(Num_FreM);
        }
        #endregion

        #region [Validate]
        private bool CheckSavePath(string strPath)
        {
            if (String.IsNullOrWhiteSpace(strPath) || !Directory.Exists(strPath))
            {
                MessageBox.Show("Save Path Not Exist !");
                return false;
            }
            return true;
        }

        private bool CheckSetTimeFromTo(DateTime dtFrom, DateTime dtTo)
        {
            if (dtFrom >= dtTo)
            {
                MessageBox.Show("Timer From >= To !");
                return false;
            }
            return true;
        }
        #endregion

        #region [Logic]
        private void InvokeCapture()
        {
            switch (MutipleScreenMode)
            {
                case emMutipleScreenMode.Combine:
                    SC.ScreenCapture_Single(SavePath);
                    break;

                case emMutipleScreenMode.Seperate:
                    SC.ScreenCapture_Multiple(SavePath);
                    break;
            }
        }

        private void TimerStart()
        {
            switch (TimerCaptureMode)
            {
                case emTimerCaptureMode.OnTime:
                    SetTime = Convert.ToDateTime(Num_H.Value + ":" + Num_M.Value + ":00");
                    break;

                case emTimerCaptureMode.FromTo:
                    SetTimeFrom = Convert.ToDateTime(Num_FromH.Value + ":" + Num_FromM.Value + ":00");
                    SetTimeTo = Convert.ToDateTime(Num_ToH.Value + ":" + Num_ToM.Value + ":01");
                    if (!CheckSetTimeFromTo(SetTimeFrom, SetTimeTo))
                    {
                        GUIRelease();
                        return;
                    }

                    FreqMin = Convert.ToInt32(Num_FreM.Value);
                    CaptureTime = SetTimeFrom.AddMinutes(FreqMin);
                    DateTime dtNow = DateTime.Now;
                    if (dtNow > SetTimeFrom && dtNow < SetTimeTo)
                    {
                        while (dtNow >= CaptureTime)
                        {
                            CaptureTime = CaptureTime.AddMinutes(FreqMin);
                        }
                    }
                    break;
            }

            TimerSet.TimerInvoke tiCallback = TimerCheck;
            TS.TimerStart(1000, tiCallback);
        }

        private void TimerCheck()
        {
            DateTime dtNow = DateTime.Now;

            switch (TimerCaptureMode)
            {
                case emTimerCaptureMode.OnTime:
                    if (dtNow.ToString("HH:mm:ss") == SetTime.ToString("HH:mm:ss"))
                    {
                        InvokeCapture();
                    }
                    if (dtNow > SetTime)
                    {
                        SetTime = SetTime.AddDays(1);
                    }
                    break;

                case emTimerCaptureMode.FromTo:
                    if (dtNow > SetTimeFrom && dtNow < SetTimeTo)
                    {
                        if (dtNow.ToString("HH:mm:ss") == CaptureTime.ToString("HH:mm:ss"))
                        {
                            CaptureTime = CaptureTime.AddMinutes(FreqMin);
                            InvokeCapture();
                        }
                    }
                    if (dtNow > SetTimeTo)
                    {
                        SetTimeFrom = SetTimeFrom.AddDays(1);
                        SetTimeTo = SetTimeTo.AddDays(1);
                        CaptureTime = SetTimeFrom.AddMinutes(FreqMin);
                    }
                    break;
            }
        }

        private void TimerStop()
        {
            TS.TimerStop();
        }
        #endregion
    }
}
