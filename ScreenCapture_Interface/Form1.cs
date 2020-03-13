using System;
using System.IO;
using System.Windows.Forms;

namespace ScreenCapture_Interface
{
    public partial class Form1 : Form
    {
        private HotKey HK;
        private System.Timers.Timer tmr;
        private string SetTime = "";
        private int frequency;
        private string SetTime_From = "";
        private string SetTime_To = "";
        private string SavePath = "";
        private System.Windows.Forms.NotifyIcon notifyIcon_sc;
        private int Time_mode;

        #region [Initial]
        public Form1()
        {
            InitializeComponent();
            Initial();
        }

        ~Form1()
        {
            HK.Dispose(); //取消熱鍵
            tmr.Dispose();
            notifyIcon_sc.Dispose();
        }

        protected void Initial()
        {
            Time_mode = 0;
            Rb_Combine.Checked = true;
            Rb_Ontime.Checked = true;
            Btn_Stop.Enabled = false;

            HK = new HotKey(this.Handle, Keys.Space, Keys.None); //註冊Space為熱鍵, 如果不要組合鍵請傳Keys.None當參數
            HK.OnHotkey += new HotKey.HotkeyEventHandler(Hotkey_Capture); //hotkey事件  

            notifyIcon_sc = new System.Windows.Forms.NotifyIcon(this.components);

            //Btn_Folder_Click(null, null);
            //this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void TimeCheck()
        {
            DateTime dtNow = DateTime.Now;

            switch (Time_mode)
            {
                case 0:
                    if (dtNow.ToString("HH:mm") == SetTime)
                    {
                        Hotkey_Capture(null, null);
                        Btn_Stop_Click(null, null);
                    }
                    break;
                case 1:
                    if (Convert.ToDateTime(dtNow.ToString("HH:mm")) >= Convert.ToDateTime(SetTime_From))
                    {
                        if (frequency == 0)
                        {
                            Hotkey_Capture(null, null);
                            frequency = Convert.ToInt32(Num_FreM.Value * 60);
                        }
                        if (Convert.ToDateTime(dtNow.ToString("HH:mm")) > Convert.ToDateTime(SetTime_To))
                        {
                            Btn_Stop_Click(null, null);
                        }
                        --frequency;
                    }
                    break;
            }
        }

        #region [Validate]
        private bool SavePath_Validate(string path)
        {
            if (String.IsNullOrEmpty(path) || !Directory.Exists(path))
            {
                MessageBox.Show("Saving path not exist !");
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
            dialog.SelectedPath = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Saving path : " + dialog.SelectedPath);
                Txt_SavePath.Text = dialog.SelectedPath;
                SavePath = dialog.SelectedPath;
            }

            dialog.Dispose();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (!SavePath_Validate(SavePath))
            {
                return;
            }

            switch (Time_mode)
            {
                case 0:
                    SetTime = Convert.ToDateTime(Num_H.Value + ":" + Num_M.Value).ToString("HH:mm");
                    Pl_Ontime.Enabled = false;
                    break;
                case 1:
                    SetTime_From = Convert.ToDateTime(Num_FromH.Value + ":" + Num_FromM.Value).ToString("HH:mm");
                    SetTime_To = Convert.ToDateTime(Num_ToH.Value + ":" + Num_ToM.Value).ToString("HH:mm");
                    frequency = Convert.ToInt32(Num_FreM.Value * 60);
                    if (Convert.ToDateTime(SetTime_From) >= Convert.ToDateTime(SetTime_To))
                    {
                        MessageBox.Show("Set time start >= end !");
                        return;
                    }
                    Pl_Fromto.Enabled = false;
                    break;
            }

            Btn_Start.Enabled = false;
            Btn_Stop.Enabled = true;
            Btn_Folder.Enabled = false;
            Pl_TimeMode.Enabled = false;

            tmr = new System.Timers.Timer(1000);
            tmr.Elapsed += delegate
            {
                TimeCheck();
            };
            tmr.Start();
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            tmr.Stop();
            tmr.Dispose();

            switch (Time_mode)
            {
                case 0:
                    SetTime = "";
                    Pl_Ontime.Enabled = true;
                    Num_H.Value = 0;
                    Num_M.Value = 0;
                    break;
                case 1:
                    frequency = 0;
                    SetTime_From = "";
                    SetTime_To = "";
                    Pl_Fromto.Enabled = true;
                    Num_FromH.Value = 0;
                    Num_FromM.Value = 0;
                    Num_ToH.Value = 0;
                    Num_ToM.Value = 0;
                    Num_FreM.Value = 0;
                    break;
            }

            Btn_Stop.Enabled = false;
            Btn_Start.Enabled = true;
            Btn_Folder.Enabled = true;
            Pl_TimeMode.Enabled = true;
        }

        private void Hotkey_Capture(object sender, HotKeyEventArgs e)
        {
            if (!SavePath_Validate(SavePath))
            {
                return;
            }

            ScreenCapture SC = new ScreenCapture();
            if (Rb_Combine.Checked)
            {
                SC.ScreenCapture_Single(SavePath);
            }
            else
            {
                SC.ScreenCapture_Multiple(SavePath);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                HK.Dispose(); //取消熱鍵

                this.ShowInTaskbar = false;     //讓程式在工具列中隱藏   

                HK = new HotKey(this.Handle, Keys.Space, Keys.None); //註冊Space為熱鍵, 如果不要組合鍵請傳Keys.None當參數
                HK.OnHotkey += new HotKey.HotkeyEventHandler(Hotkey_Capture); //hotkey事件               
            }
        }

        private void NotifyIcon_min_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HK.Dispose(); //取消熱鍵

            this.ShowInTaskbar = true;                   // 顯示在工具列
            this.WindowState = FormWindowState.Normal;   // 還原視窗

            HK = new HotKey(this.Handle, Keys.Space, Keys.None); //註冊Space為熱鍵, 如果不要組合鍵請傳Keys.None當參數
            HK.OnHotkey += new HotKey.HotkeyEventHandler(Hotkey_Capture); //hotkey事件  
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifyIcon_min_MouseDoubleClick(null, null);
        }

        private void Rb_Ontime_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Ontime.Checked)
            {
                Time_mode = 0;
                Pl_Ontime.Enabled = true;
                Pl_Fromto.Enabled = false;
                Num_H.Value = 0;
                Num_M.Value = 0;
            }
            else
            {
                Time_mode = 1;
                Pl_Ontime.Enabled = false;
                Pl_Fromto.Enabled = true;
                Num_FromH.Value = 0;
                Num_FromM.Value = 0;
                Num_ToH.Value = 0;
                Num_ToM.Value = 0;
                Num_FreM.Value = 0;
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
