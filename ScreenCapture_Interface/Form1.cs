using System;
using System.IO;
using System.Windows.Forms;

namespace ScreenCapture_Interface
{
    public partial class Form1 : Form
    {
        private HotKey HK;
        private System.Timers.Timer Timer;
        private string SavePath = string.Empty;
        private int MutipleScreenMode;
        private int TimeCaptureMode;
        private DateTime SetTime;
        private DateTime SetTimeFrom;
        private DateTime SetTimeTo;
        private DateTime CaptureTime;
        private NotifyIcon NotifyIcon;

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
            NotifyIcon.Dispose();
            Timer.Dispose();
        }

        protected void Initial()
        {
            MutipleScreenMode = 0;
            TimeCaptureMode = 0;
            NotifyIcon = new NotifyIcon(this.components);

            //Btn_Folder_Click(null, null);
            //this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void RegisterHotKey()
        {
            HK = new HotKey(this.Handle, Keys.Space, Keys.None); //註冊Space為熱鍵, 如果不要組合鍵請傳Keys.None當參數
            HK.OnHotkey += new HotKey.HotkeyEventHandler(Hotkey_Capture); //HotKey事件
        }

        private void CheckTimer()
        {
            DateTime dtNow = DateTime.Now;

            switch (TimeCaptureMode)
            {
                case 0:
                    if (dtNow.ToString("HH:mm:ss") == SetTime.ToString("HH:mm:ss"))
                    {
                        Hotkey_Capture(null, null);
                    }
                    break;

                case 1:
                    if (dtNow > SetTimeFrom && dtNow < SetTimeTo)
                    {
                        if (dtNow.ToString("HH:mm:ss") == CaptureTime.ToString("HH:mm:ss"))
                        {
                            CaptureTime = CaptureTime.AddMinutes(Convert.ToInt32(Num_FreM.Value));
                            Hotkey_Capture(null, null);
                        }
                    }
                    else
                    {
                        CaptureTime = SetTimeFrom.AddMinutes(Convert.ToInt32(Num_FreM.Value));
                    }
                    break;
            }
        }

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
        #endregion

        #region [Event]
        private void Btn_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Saving path setting";
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

            switch (TimeCaptureMode)
            {
                case 0:
                    SetTime = Convert.ToDateTime(Num_H.Value + ":" + Num_M.Value + ":00");
                    Pl_Ontime.Enabled = false;
                    break;

                case 1:
                    SetTimeFrom = Convert.ToDateTime(Num_FromH.Value + ":" + Num_FromM.Value + ":00");
                    SetTimeTo = Convert.ToDateTime(Num_ToH.Value + ":" + Num_ToM.Value + ":59");
                    if (SetTimeFrom >= SetTimeTo)
                    {
                        MessageBox.Show("Set time start >= end !");
                        return;
                    }

                    CaptureTime = SetTimeFrom.AddMinutes(Convert.ToInt32(Num_FreM.Value));
                    while (DateTime.Now >= CaptureTime)
                    {
                        CaptureTime = CaptureTime.AddMinutes(Convert.ToInt32(Num_FreM.Value));
                    }

                    Pl_Fromto.Enabled = false;
                    break;
            }

            Btn_Start.Enabled = false;
            Btn_Stop.Enabled = true;
            Btn_Folder.Enabled = false;
            Pl_TimeMode.Enabled = false;

            Timer = new System.Timers.Timer(1000);
            Timer.Elapsed += delegate
            {
                CheckTimer();
            };
            Timer.Start();
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            Timer.Dispose();

            switch (TimeCaptureMode)
            {
                case 0:
                    Pl_Ontime.Enabled = true;
                    Num_H.Value = 0;
                    Num_M.Value = 0;
                    break;

                case 1:
                    Pl_Fromto.Enabled = true;
                    Num_FromH.Value = 0;
                    Num_FromM.Value = 0;
                    Num_ToH.Value = 0;
                    Num_ToM.Value = 0;
                    Num_FreM.Value = 1;
                    break;
            }

            Btn_Stop.Enabled = false;
            Btn_Start.Enabled = true;
            Btn_Folder.Enabled = true;
            Pl_TimeMode.Enabled = true;
        }

        private void Hotkey_Capture(object sender, HotKeyEventArgs e)
        {
            if (!CheckSavePath(SavePath))
            {
                return;
            }

            ScreenCapture SC = new ScreenCapture();
            switch (MutipleScreenMode)
            {
                case 0:
                    SC.ScreenCapture_Single(SavePath);
                    break;

                case 1:
                    SC.ScreenCapture_Multiple(SavePath);
                    break;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                HK.Dispose();                   //取消熱鍵
                this.ShowInTaskbar = false;     //讓程式在工具列中隱藏
                RegisterHotKey();
            }
        }

        private void NotifyIcon_min_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HK.Dispose();                                //取消熱鍵
            this.ShowInTaskbar = true;                   //顯示在工具列
            this.WindowState = FormWindowState.Normal;   //還原視窗
            RegisterHotKey();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifyIcon_min_MouseDoubleClick(null, null);
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

        private void Rb_Ontime_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Ontime.Checked)
            {
                TimeCaptureMode = 0;
                Pl_Ontime.Enabled = true;
                Pl_Fromto.Enabled = false;
                Num_H.Value = 0;
                Num_M.Value = 0;
            }
            else
            {
                TimeCaptureMode = 1;
                Pl_Ontime.Enabled = false;
                Pl_Fromto.Enabled = true;
                Num_FromH.Value = 0;
                Num_FromM.Value = 0;
                Num_ToH.Value = 0;
                Num_ToM.Value = 0;
                Num_FreM.Value = 1;
            }
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
