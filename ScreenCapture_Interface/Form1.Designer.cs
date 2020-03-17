namespace ScreenCapture_Interface
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Btn_Folder = new System.Windows.Forms.Button();
            this.Lbl_S1 = new System.Windows.Forms.Label();
            this.notifyIcon_min = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Num_M = new System.Windows.Forms.NumericUpDown();
            this.Num_H = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Tip = new System.Windows.Forms.Label();
            this.Rb_Combine = new System.Windows.Forms.RadioButton();
            this.Rb_Seperate = new System.Windows.Forms.RadioButton();
            this.Lbl_Mode = new System.Windows.Forms.Label();
            this.Num_FromH = new System.Windows.Forms.NumericUpDown();
            this.Num_FromM = new System.Windows.Forms.NumericUpDown();
            this.Lbl_S5 = new System.Windows.Forms.Label();
            this.Num_ToH = new System.Windows.Forms.NumericUpDown();
            this.Num_ToM = new System.Windows.Forms.NumericUpDown();
            this.Lbl_S7 = new System.Windows.Forms.Label();
            this.Lbl_Freq1 = new System.Windows.Forms.Label();
            this.Num_FreM = new System.Windows.Forms.NumericUpDown();
            this.Pl_ScreenMode = new System.Windows.Forms.Panel();
            this.Pl_OnTime = new System.Windows.Forms.Panel();
            this.Lbl_OnTime = new System.Windows.Forms.Label();
            this.Pl_TimerMode = new System.Windows.Forms.Panel();
            this.Lbl_TimerMode = new System.Windows.Forms.Label();
            this.Rb_FromTo = new System.Windows.Forms.RadioButton();
            this.Rb_OnTime = new System.Windows.Forms.RadioButton();
            this.Pl_FromTo = new System.Windows.Forms.Panel();
            this.Lbl_Freq2 = new System.Windows.Forms.Label();
            this.Lbl_From = new System.Windows.Forms.Label();
            this.Lbl_To = new System.Windows.Forms.Label();
            this.Pl_SavePath = new System.Windows.Forms.Panel();
            this.Txt_SavePath = new System.Windows.Forms.TextBox();
            this.Lbl_SavePath = new System.Windows.Forms.Label();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FromH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FromM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ToH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ToM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FreM)).BeginInit();
            this.Pl_ScreenMode.SuspendLayout();
            this.Pl_OnTime.SuspendLayout();
            this.Pl_TimerMode.SuspendLayout();
            this.Pl_FromTo.SuspendLayout();
            this.Pl_SavePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(275, 80);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(44, 25);
            this.Btn_Start.TabIndex = 13;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Enabled = false;
            this.Btn_Stop.Location = new System.Drawing.Point(275, 109);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(44, 25);
            this.Btn_Stop.TabIndex = 14;
            this.Btn_Stop.Text = "Stop";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Folder
            // 
            this.Btn_Folder.Location = new System.Drawing.Point(258, 17);
            this.Btn_Folder.Name = "Btn_Folder";
            this.Btn_Folder.Size = new System.Drawing.Size(80, 25);
            this.Btn_Folder.TabIndex = 1;
            this.Btn_Folder.Text = "Select Folder";
            this.Btn_Folder.UseVisualStyleBackColor = true;
            this.Btn_Folder.Click += new System.EventHandler(this.Btn_Folder_Click);
            // 
            // Lbl_S1
            // 
            this.Lbl_S1.AutoSize = true;
            this.Lbl_S1.Location = new System.Drawing.Point(89, 9);
            this.Lbl_S1.Name = "Lbl_S1";
            this.Lbl_S1.Size = new System.Drawing.Size(8, 12);
            this.Lbl_S1.TabIndex = 6;
            this.Lbl_S1.Text = ":";
            // 
            // notifyIcon_min
            // 
            this.notifyIcon_min.ContextMenuStrip = this.contextMenu;
            this.notifyIcon_min.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_min.Icon")));
            this.notifyIcon_min.Text = "Screen Capture";
            this.notifyIcon_min.Visible = true;
            this.notifyIcon_min.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(118, 54);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_RestoreClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_ExitClick);
            // 
            // Num_M
            // 
            this.Num_M.Location = new System.Drawing.Point(101, 4);
            this.Num_M.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Num_M.Name = "Num_M";
            this.Num_M.ReadOnly = true;
            this.Num_M.Size = new System.Drawing.Size(31, 22);
            this.Num_M.TabIndex = 7;
            this.Num_M.Enter += new System.EventHandler(this.Num_M_Enter);
            // 
            // Num_H
            // 
            this.Num_H.Location = new System.Drawing.Point(55, 4);
            this.Num_H.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Num_H.Name = "Num_H";
            this.Num_H.ReadOnly = true;
            this.Num_H.Size = new System.Drawing.Size(31, 22);
            this.Num_H.TabIndex = 6;
            this.Num_H.Enter += new System.EventHandler(this.Num_H_Enter);
            // 
            // Lbl_Tip
            // 
            this.Lbl_Tip.AutoSize = true;
            this.Lbl_Tip.Location = new System.Drawing.Point(3, 3);
            this.Lbl_Tip.Name = "Lbl_Tip";
            this.Lbl_Tip.Size = new System.Drawing.Size(175, 12);
            this.Lbl_Tip.TabIndex = 8;
            this.Lbl_Tip.Text = "Press [Space] or Set Time to Capture";
            // 
            // Rb_Combine
            // 
            this.Rb_Combine.AutoSize = true;
            this.Rb_Combine.Checked = true;
            this.Rb_Combine.Location = new System.Drawing.Point(115, 7);
            this.Rb_Combine.Name = "Rb_Combine";
            this.Rb_Combine.Size = new System.Drawing.Size(66, 16);
            this.Rb_Combine.TabIndex = 2;
            this.Rb_Combine.TabStop = true;
            this.Rb_Combine.Text = "Combine";
            this.Rb_Combine.UseVisualStyleBackColor = true;
            this.Rb_Combine.CheckedChanged += new System.EventHandler(this.Rb_Combine_CheckedChanged);
            // 
            // Rb_Seperate
            // 
            this.Rb_Seperate.AutoSize = true;
            this.Rb_Seperate.Location = new System.Drawing.Point(184, 7);
            this.Rb_Seperate.Name = "Rb_Seperate";
            this.Rb_Seperate.Size = new System.Drawing.Size(62, 16);
            this.Rb_Seperate.TabIndex = 3;
            this.Rb_Seperate.TabStop = true;
            this.Rb_Seperate.Text = "Seperate";
            this.Rb_Seperate.UseVisualStyleBackColor = true;
            // 
            // Lbl_Mode
            // 
            this.Lbl_Mode.AutoSize = true;
            this.Lbl_Mode.Location = new System.Drawing.Point(2, 8);
            this.Lbl_Mode.Name = "Lbl_Mode";
            this.Lbl_Mode.Size = new System.Drawing.Size(108, 12);
            this.Lbl_Mode.TabIndex = 11;
            this.Lbl_Mode.Text = "Multiple Screen Mode";
            // 
            // Num_FromH
            // 
            this.Num_FromH.Location = new System.Drawing.Point(36, 4);
            this.Num_FromH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Num_FromH.Name = "Num_FromH";
            this.Num_FromH.ReadOnly = true;
            this.Num_FromH.Size = new System.Drawing.Size(31, 22);
            this.Num_FromH.TabIndex = 8;
            this.Num_FromH.Enter += new System.EventHandler(this.Num_FromH_Enter);
            // 
            // Num_FromM
            // 
            this.Num_FromM.Location = new System.Drawing.Point(81, 4);
            this.Num_FromM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Num_FromM.Name = "Num_FromM";
            this.Num_FromM.ReadOnly = true;
            this.Num_FromM.Size = new System.Drawing.Size(31, 22);
            this.Num_FromM.TabIndex = 9;
            this.Num_FromM.Enter += new System.EventHandler(this.Num_FromM_Enter);
            // 
            // Lbl_S5
            // 
            this.Lbl_S5.AutoSize = true;
            this.Lbl_S5.Location = new System.Drawing.Point(70, 9);
            this.Lbl_S5.Name = "Lbl_S5";
            this.Lbl_S5.Size = new System.Drawing.Size(8, 12);
            this.Lbl_S5.TabIndex = 15;
            this.Lbl_S5.Text = ":";
            // 
            // Num_ToH
            // 
            this.Num_ToH.Location = new System.Drawing.Point(136, 4);
            this.Num_ToH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Num_ToH.Name = "Num_ToH";
            this.Num_ToH.ReadOnly = true;
            this.Num_ToH.Size = new System.Drawing.Size(31, 22);
            this.Num_ToH.TabIndex = 10;
            this.Num_ToH.Enter += new System.EventHandler(this.Num_ToH_Enter);
            // 
            // Num_ToM
            // 
            this.Num_ToM.Location = new System.Drawing.Point(181, 4);
            this.Num_ToM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Num_ToM.Name = "Num_ToM";
            this.Num_ToM.ReadOnly = true;
            this.Num_ToM.Size = new System.Drawing.Size(31, 22);
            this.Num_ToM.TabIndex = 11;
            this.Num_ToM.Enter += new System.EventHandler(this.Num_ToM_Enter);
            // 
            // Lbl_S7
            // 
            this.Lbl_S7.AutoSize = true;
            this.Lbl_S7.Location = new System.Drawing.Point(170, 9);
            this.Lbl_S7.Name = "Lbl_S7";
            this.Lbl_S7.Size = new System.Drawing.Size(8, 12);
            this.Lbl_S7.TabIndex = 20;
            this.Lbl_S7.Text = ":";
            // 
            // Lbl_Freq1
            // 
            this.Lbl_Freq1.AutoSize = true;
            this.Lbl_Freq1.Location = new System.Drawing.Point(214, 9);
            this.Lbl_Freq1.Name = "Lbl_Freq1";
            this.Lbl_Freq1.Size = new System.Drawing.Size(46, 12);
            this.Lbl_Freq1.TabIndex = 25;
            this.Lbl_Freq1.Text = "-> Every";
            // 
            // Num_FreM
            // 
            this.Num_FreM.Location = new System.Drawing.Point(261, 4);
            this.Num_FreM.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Num_FreM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_FreM.Name = "Num_FreM";
            this.Num_FreM.ReadOnly = true;
            this.Num_FreM.Size = new System.Drawing.Size(31, 22);
            this.Num_FreM.TabIndex = 12;
            this.Num_FreM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_FreM.Enter += new System.EventHandler(this.Num_FreM_Enter);
            // 
            // Pl_ScreenMode
            // 
            this.Pl_ScreenMode.Controls.Add(this.Lbl_Mode);
            this.Pl_ScreenMode.Controls.Add(this.Rb_Seperate);
            this.Pl_ScreenMode.Controls.Add(this.Rb_Combine);
            this.Pl_ScreenMode.Location = new System.Drawing.Point(3, 46);
            this.Pl_ScreenMode.Name = "Pl_ScreenMode";
            this.Pl_ScreenMode.Size = new System.Drawing.Size(250, 30);
            this.Pl_ScreenMode.TabIndex = 2;
            // 
            // Pl_OnTime
            // 
            this.Pl_OnTime.Controls.Add(this.Lbl_OnTime);
            this.Pl_OnTime.Controls.Add(this.Lbl_S1);
            this.Pl_OnTime.Controls.Add(this.Num_M);
            this.Pl_OnTime.Controls.Add(this.Num_H);
            this.Pl_OnTime.Location = new System.Drawing.Point(3, 108);
            this.Pl_OnTime.Name = "Pl_OnTime";
            this.Pl_OnTime.Size = new System.Drawing.Size(250, 30);
            this.Pl_OnTime.TabIndex = 4;
            // 
            // Lbl_OnTime
            // 
            this.Lbl_OnTime.AutoSize = true;
            this.Lbl_OnTime.Location = new System.Drawing.Point(3, 8);
            this.Lbl_OnTime.Name = "Lbl_OnTime";
            this.Lbl_OnTime.Size = new System.Drawing.Size(47, 12);
            this.Lbl_OnTime.TabIndex = 28;
            this.Lbl_OnTime.Text = "On-Time";
            // 
            // Pl_TimerMode
            // 
            this.Pl_TimerMode.Controls.Add(this.Lbl_TimerMode);
            this.Pl_TimerMode.Controls.Add(this.Rb_FromTo);
            this.Pl_TimerMode.Controls.Add(this.Rb_OnTime);
            this.Pl_TimerMode.Location = new System.Drawing.Point(3, 77);
            this.Pl_TimerMode.Name = "Pl_TimerMode";
            this.Pl_TimerMode.Size = new System.Drawing.Size(250, 30);
            this.Pl_TimerMode.TabIndex = 3;
            // 
            // Lbl_TimerMode
            // 
            this.Lbl_TimerMode.AutoSize = true;
            this.Lbl_TimerMode.Location = new System.Drawing.Point(2, 9);
            this.Lbl_TimerMode.Name = "Lbl_TimerMode";
            this.Lbl_TimerMode.Size = new System.Drawing.Size(103, 12);
            this.Lbl_TimerMode.TabIndex = 27;
            this.Lbl_TimerMode.Text = "Timer Capture Mode";
            // 
            // Rb_FromTo
            // 
            this.Rb_FromTo.AutoSize = true;
            this.Rb_FromTo.Location = new System.Drawing.Point(184, 7);
            this.Rb_FromTo.Name = "Rb_FromTo";
            this.Rb_FromTo.Size = new System.Drawing.Size(65, 16);
            this.Rb_FromTo.TabIndex = 5;
            this.Rb_FromTo.TabStop = true;
            this.Rb_FromTo.Text = "From-To";
            this.Rb_FromTo.UseVisualStyleBackColor = true;
            // 
            // Rb_OnTime
            // 
            this.Rb_OnTime.AutoSize = true;
            this.Rb_OnTime.Checked = true;
            this.Rb_OnTime.Location = new System.Drawing.Point(115, 7);
            this.Rb_OnTime.Name = "Rb_OnTime";
            this.Rb_OnTime.Size = new System.Drawing.Size(65, 16);
            this.Rb_OnTime.TabIndex = 4;
            this.Rb_OnTime.TabStop = true;
            this.Rb_OnTime.Text = "On-Time";
            this.Rb_OnTime.UseVisualStyleBackColor = true;
            this.Rb_OnTime.CheckedChanged += new System.EventHandler(this.Rb_OnTime_CheckedChanged);
            // 
            // Pl_FromTo
            // 
            this.Pl_FromTo.Controls.Add(this.Lbl_Freq2);
            this.Pl_FromTo.Controls.Add(this.Lbl_From);
            this.Pl_FromTo.Controls.Add(this.Lbl_To);
            this.Pl_FromTo.Controls.Add(this.Lbl_Freq1);
            this.Pl_FromTo.Controls.Add(this.Num_FreM);
            this.Pl_FromTo.Controls.Add(this.Num_ToH);
            this.Pl_FromTo.Controls.Add(this.Num_ToM);
            this.Pl_FromTo.Controls.Add(this.Lbl_S5);
            this.Pl_FromTo.Controls.Add(this.Lbl_S7);
            this.Pl_FromTo.Controls.Add(this.Num_FromM);
            this.Pl_FromTo.Controls.Add(this.Num_FromH);
            this.Pl_FromTo.Enabled = false;
            this.Pl_FromTo.Location = new System.Drawing.Point(3, 139);
            this.Pl_FromTo.Name = "Pl_FromTo";
            this.Pl_FromTo.Size = new System.Drawing.Size(339, 30);
            this.Pl_FromTo.TabIndex = 5;
            // 
            // Lbl_Freq2
            // 
            this.Lbl_Freq2.AutoSize = true;
            this.Lbl_Freq2.Location = new System.Drawing.Point(294, 9);
            this.Lbl_Freq2.Name = "Lbl_Freq2";
            this.Lbl_Freq2.Size = new System.Drawing.Size(42, 12);
            this.Lbl_Freq2.TabIndex = 33;
            this.Lbl_Freq2.Text = "Minutes";
            // 
            // Lbl_From
            // 
            this.Lbl_From.AutoSize = true;
            this.Lbl_From.Location = new System.Drawing.Point(3, 9);
            this.Lbl_From.Name = "Lbl_From";
            this.Lbl_From.Size = new System.Drawing.Size(30, 12);
            this.Lbl_From.TabIndex = 32;
            this.Lbl_From.Text = "From";
            // 
            // Lbl_To
            // 
            this.Lbl_To.AutoSize = true;
            this.Lbl_To.Location = new System.Drawing.Point(115, 8);
            this.Lbl_To.Name = "Lbl_To";
            this.Lbl_To.Size = new System.Drawing.Size(18, 12);
            this.Lbl_To.TabIndex = 31;
            this.Lbl_To.Text = "To";
            // 
            // Pl_SavePath
            // 
            this.Pl_SavePath.Controls.Add(this.Txt_SavePath);
            this.Pl_SavePath.Controls.Add(this.Lbl_SavePath);
            this.Pl_SavePath.Location = new System.Drawing.Point(3, 15);
            this.Pl_SavePath.Name = "Pl_SavePath";
            this.Pl_SavePath.Size = new System.Drawing.Size(250, 30);
            this.Pl_SavePath.TabIndex = 20;
            // 
            // Txt_SavePath
            // 
            this.Txt_SavePath.Enabled = false;
            this.Txt_SavePath.Location = new System.Drawing.Point(57, 4);
            this.Txt_SavePath.Name = "Txt_SavePath";
            this.Txt_SavePath.Size = new System.Drawing.Size(191, 22);
            this.Txt_SavePath.TabIndex = 12;
            // 
            // Lbl_SavePath
            // 
            this.Lbl_SavePath.AutoSize = true;
            this.Lbl_SavePath.Location = new System.Drawing.Point(3, 9);
            this.Lbl_SavePath.Name = "Lbl_SavePath";
            this.Lbl_SavePath.Size = new System.Drawing.Size(50, 12);
            this.Lbl_SavePath.TabIndex = 11;
            this.Lbl_SavePath.Text = "Save Path";
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(344, 171);
            this.Controls.Add(this.Pl_SavePath);
            this.Controls.Add(this.Pl_FromTo);
            this.Controls.Add(this.Pl_TimerMode);
            this.Controls.Add(this.Pl_OnTime);
            this.Controls.Add(this.Pl_ScreenMode);
            this.Controls.Add(this.Lbl_Tip);
            this.Controls.Add(this.Btn_Folder);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ScreenCapture";
            this.TopMost = true;
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Num_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FromH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FromM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ToH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ToM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FreM)).EndInit();
            this.Pl_ScreenMode.ResumeLayout(false);
            this.Pl_ScreenMode.PerformLayout();
            this.Pl_OnTime.ResumeLayout(false);
            this.Pl_OnTime.PerformLayout();
            this.Pl_TimerMode.ResumeLayout(false);
            this.Pl_TimerMode.PerformLayout();
            this.Pl_FromTo.ResumeLayout(false);
            this.Pl_FromTo.PerformLayout();
            this.Pl_SavePath.ResumeLayout(false);
            this.Pl_SavePath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Button Btn_Folder;
        private System.Windows.Forms.Label Lbl_S1;
        private System.Windows.Forms.NotifyIcon notifyIcon_min;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NumericUpDown Num_M;
        private System.Windows.Forms.NumericUpDown Num_H;
        private System.Windows.Forms.Label Lbl_Tip;
        private System.Windows.Forms.RadioButton Rb_Combine;
        private System.Windows.Forms.RadioButton Rb_Seperate;
        private System.Windows.Forms.Label Lbl_Mode;
        private System.Windows.Forms.NumericUpDown Num_FromH;
        private System.Windows.Forms.NumericUpDown Num_FromM;
        private System.Windows.Forms.Label Lbl_S5;
        private System.Windows.Forms.NumericUpDown Num_ToH;
        private System.Windows.Forms.NumericUpDown Num_ToM;
        private System.Windows.Forms.Label Lbl_S7;
        private System.Windows.Forms.Label Lbl_Freq1;
        private System.Windows.Forms.NumericUpDown Num_FreM;
        private System.Windows.Forms.Panel Pl_ScreenMode;
        private System.Windows.Forms.Panel Pl_OnTime;
        private System.Windows.Forms.Panel Pl_TimerMode;
        private System.Windows.Forms.Label Lbl_TimerMode;
        private System.Windows.Forms.RadioButton Rb_FromTo;
        private System.Windows.Forms.RadioButton Rb_OnTime;
        private System.Windows.Forms.Panel Pl_FromTo;
        private System.Windows.Forms.Label Lbl_To;
        private System.Windows.Forms.Label Lbl_OnTime;
        private System.Windows.Forms.Label Lbl_From;
        private System.Windows.Forms.Panel Pl_SavePath;
        private System.Windows.Forms.TextBox Txt_SavePath;
        private System.Windows.Forms.Label Lbl_SavePath;
        private System.Windows.Forms.Label Lbl_Freq2;
    }
}

