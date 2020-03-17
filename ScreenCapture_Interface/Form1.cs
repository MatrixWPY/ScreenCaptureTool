using System;
using System.IO;
using System.Windows.Forms;

namespace ScreenCapture_Interface
{
    public partial class Form1 : Form
    {
        private static HotKey HK;
        private static TimerSet Timer;
        private static NotifyIcon NIcon;
        private static string SavePath = string.Empty;
        private static int MutipleScreenMode;
        private static int TimerCaptureMode;

        #region [Initial]
        public Form1()
        {
            InitializeComponent();
            Initial();
            RegisterHotKey();
        }

        ~Form1()
        {
            HK.Dispose(); //取消熱鍵
            //Timer.Dispose();
            NIcon.Dispose();
        }

        protected void Initial()
        {
            MutipleScreenMode = 0;
            TimerCaptureMode = 0;
            NIcon = new NotifyIcon(this.components);
            Timer = new TimerSet();

            //Btn_Folder_Click(null, null);
            //this.WindowState = FormWindowState.Minimized;
        }

        private void RegisterHotKey()
        {
            if (null != HK)
            {
                HK.Dispose();                                           //取消熱鍵
            }
            HK = new HotKey(this.Handle, Keys.Space, Keys.None);        //註冊Space為熱鍵, 如果不要組合鍵請傳Keys.None當參數
            HK.OnHotkey += new HotKey.HotkeyEventHandler(Hotkey_Click); //HotKey事件
        }
        #endregion

        #region [Logic]
        private void InvokeCapture(int iMutipleScreenMode, string strSavePath)
        {
            ScreenCapture SC = new ScreenCapture();
            switch (iMutipleScreenMode)
            {
                case 0:
                    SC.ScreenCapture_Single(strSavePath);
                    break;

                case 1:
                    SC.ScreenCapture_Multiple(strSavePath);
                    break;
            }
        }

        private void TimerStart(int iTimeCaptureMode, int iMutipleScreenMode, string strSavePath)
        {
            switch (iTimeCaptureMode)
            {
                case 0:
                    Timer.SetTime = Convert.ToDateTime(Num_H.Value + ":" + Num_M.Value + ":00");
                    Pl_OnTime.Enabled = false;
                    break;

                case 1:
                    Timer.SetTimeFrom = Convert.ToDateTime(Num_FromH.Value + ":" + Num_FromM.Value + ":00");
                    Timer.SetTimeTo = Convert.ToDateTime(Num_ToH.Value + ":" + Num_ToM.Value + ":59");
                    if (!CheckSetTimeFromTo(Timer.SetTimeFrom, Timer.SetTimeTo))
                    {
                        return;
                    }

                    Timer.Frequency = Convert.ToInt32(Num_FreM.Value);
                    Timer.CaptureTime = Timer.SetTimeFrom.AddMinutes(Timer.Frequency);
                    DateTime dtNow = DateTime.Now;
                    if (dtNow > Timer.SetTimeFrom && dtNow < Timer.SetTimeTo)
                    {
                        while (dtNow >= Timer.CaptureTime)
                        {
                            Timer.CaptureTime = Timer.CaptureTime.AddMinutes(Timer.Frequency);
                        }
                    }

                    Pl_FromTo.Enabled = false;
                    break;
            }

            TimerSet.TimerInvoke tiCallback = InvokeCapture;
            Timer.TimerStart(iTimeCaptureMode, iMutipleScreenMode, strSavePath, tiCallback);
        }

        private void TimerStop()
        {
            Timer.TimerStop();
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

        #region [Event]
        private void Hotkey_Click(object sender, HotKeyEventArgs e)
        {
            if (!CheckSavePath(SavePath))
            {
                return;
            }

            InvokeCapture(MutipleScreenMode, SavePath);
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

            Btn_Start.Enabled = false;
            Btn_Stop.Enabled = true;
            Btn_Folder.Enabled = false;
            Pl_TimerMode.Enabled = false;

            TimerStart(TimerCaptureMode, MutipleScreenMode, SavePath);
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            TimerStop();

            Btn_Start.Enabled = true;
            Btn_Stop.Enabled = false;
            Btn_Folder.Enabled = true;
            Pl_TimerMode.Enabled = true;

            switch (TimerCaptureMode)
            {
                case 0:
                    Pl_OnTime.Enabled = true;
                    break;

                case 1:
                    Pl_FromTo.Enabled = true;
                    break;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false; //讓程式在工具列中隱藏
                RegisterHotKey();
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;                   //顯示在工具列
            this.WindowState = FormWindowState.Normal;   //還原視窗
            RegisterHotKey();
        }

        private void ToolStripMenuItem_ExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItem_RestoreClick(object sender, EventArgs e)
        {
            NotifyIcon_MouseDoubleClick(null, null);
        }

        private void Rb_Combine_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Combine.Checked)
            {
                MutipleScreenMode = 0;
            }
            else
            {
                MutipleScreenMode = 1;
            }
        }

        private void Rb_OnTime_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_OnTime.Checked)
            {
                TimerCaptureMode = 0;
                Pl_OnTime.Enabled = true;
                Pl_FromTo.Enabled = false;
            }
            else
            {
                TimerCaptureMode = 1;
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

        private void SelectAll(NumericUpDown numericUpDown)
        {
            numericUpDown.Select(0, numericUpDown.Value.ToString().Length);
        }

        private void Num_H_Enter(object sender, EventArgs e)
        {
            SelectAll(Num_H);
        }

        private void Num_M_Enter(object sender, EventArgs e)
        {
            SelectAll(Num_M);
        }

        private void Num_FromH_Enter(object sender, EventArgs e)
        {
            SelectAll(Num_FromH);
        }

        private void Num_FromM_Enter(object sender, EventArgs e)
        {
            SelectAll(Num_FromM);
        }

        private void Num_ToH_Enter(object sender, EventArgs e)
        {
            SelectAll(Num_ToH);
        }

        private void Num_ToM_Enter(object sender, EventArgs e)
        {
            SelectAll(Num_ToM);
        }

        private void Num_FreM_Enter(object sender, EventArgs e)
        {
            SelectAll(Num_FreM);
        }
        #endregion
    }
}
