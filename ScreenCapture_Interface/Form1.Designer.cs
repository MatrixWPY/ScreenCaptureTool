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
            this.Lbl_S2 = new System.Windows.Forms.Label();
            this.notifyIcon_min = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Num_S = new System.Windows.Forms.NumericUpDown();
            this.Num_M = new System.Windows.Forms.NumericUpDown();
            this.Num_H = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Tip = new System.Windows.Forms.Label();
            this.Rb_Combine = new System.Windows.Forms.RadioButton();
            this.Rb_Seperate = new System.Windows.Forms.RadioButton();
            this.Lbl_Mode = new System.Windows.Forms.Label();
            this.Num_FromH = new System.Windows.Forms.NumericUpDown();
            this.Num_FromM = new System.Windows.Forms.NumericUpDown();
            this.Num_FromS = new System.Windows.Forms.NumericUpDown();
            this.Lbl_S6 = new System.Windows.Forms.Label();
            this.Lbl_S5 = new System.Windows.Forms.Label();
            this.Num_ToH = new System.Windows.Forms.NumericUpDown();
            this.Num_ToM = new System.Windows.Forms.NumericUpDown();
            this.Num_ToS = new System.Windows.Forms.NumericUpDown();
            this.Lbl_S8 = new System.Windows.Forms.Label();
            this.Lbl_S7 = new System.Windows.Forms.Label();
            this.Lbl_Capturefreq = new System.Windows.Forms.Label();
            this.Num_FreH = new System.Windows.Forms.NumericUpDown();
            this.Num_FreM = new System.Windows.Forms.NumericUpDown();
            this.Num_FreS = new System.Windows.Forms.NumericUpDown();
            this.Lbl_S4 = new System.Windows.Forms.Label();
            this.Lbl_S3 = new System.Windows.Forms.Label();
            this.Pl_ScreenMode = new System.Windows.Forms.Panel();
            this.Pl_Ontime = new System.Windows.Forms.Panel();
            this.Pl_TimeMode = new System.Windows.Forms.Panel();
            this.Lbl_TimeMode = new System.Windows.Forms.Label();
            this.Rb_Fromto = new System.Windows.Forms.RadioButton();
            this.Rb_Ontime = new System.Windows.Forms.RadioButton();
            this.Pl_Fromto = new System.Windows.Forms.Panel();
            this.Lbl_S9 = new System.Windows.Forms.Label();
            this.Lbl_SetTime_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FromH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FromM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FromS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ToH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ToM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ToS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FreH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FreM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FreS)).BeginInit();
            this.Pl_ScreenMode.SuspendLayout();
            this.Pl_Ontime.SuspendLayout();
            this.Pl_TimeMode.SuspendLayout();
            this.Pl_Fromto.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(252, 38);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(44, 23);
            this.Btn_Start.TabIndex = 18;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Location = new System.Drawing.Point(300, 38);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(44, 23);
            this.Btn_Stop.TabIndex = 19;
            this.Btn_Stop.Text = "Stop";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Folder
            // 
            this.Btn_Folder.Location = new System.Drawing.Point(308, 7);
            this.Btn_Folder.Name = "Btn_Folder";
            this.Btn_Folder.Size = new System.Drawing.Size(28, 23);
            this.Btn_Folder.TabIndex = 1;
            this.Btn_Folder.Text = "...";
            this.Btn_Folder.UseVisualStyleBackColor = true;
            this.Btn_Folder.Click += new System.EventHandler(this.Btn_Folder_Click);
            // 
            // Lbl_S1
            // 
            this.Lbl_S1.AutoSize = true;
            this.Lbl_S1.Location = new System.Drawing.Point(90, 9);
            this.Lbl_S1.Name = "Lbl_S1";
            this.Lbl_S1.Size = new System.Drawing.Size(8, 12);
            this.Lbl_S1.TabIndex = 6;
            this.Lbl_S1.Text = ":";
            // 
            // Lbl_S2
            // 
            this.Lbl_S2.AutoSize = true;
            this.Lbl_S2.Location = new System.Drawing.Point(135, 9);
            this.Lbl_S2.Name = "Lbl_S2";
            this.Lbl_S2.Size = new System.Drawing.Size(8, 12);
            this.Lbl_S2.TabIndex = 7;
            this.Lbl_S2.Text = ":";
            // 
            // notifyIcon_min
            // 
            this.notifyIcon_min.ContextMenuStrip = this.contextMenu;
            this.notifyIcon_min.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_min.Icon")));
            this.notifyIcon_min.Text = "Screen Capture";
            this.notifyIcon_min.Visible = true;
            this.notifyIcon_min.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_min_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(120, 54);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(116, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Num_S
            // 
            this.Num_S.Location = new System.Drawing.Point(146, 4);
            this.Num_S.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Num_S.Name = "Num_S";
            this.Num_S.Size = new System.Drawing.Size(31, 22);
            this.Num_S.TabIndex = 8;
            this.Num_S.Enter += new System.EventHandler(this.Num_S_Enter);
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
            this.Num_M.Size = new System.Drawing.Size(31, 22);
            this.Num_M.TabIndex = 7;
            this.Num_M.Enter += new System.EventHandler(this.Num_M_Enter);
            // 
            // Num_H
            // 
            this.Num_H.Location = new System.Drawing.Point(57, 4);
            this.Num_H.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Num_H.Name = "Num_H";
            this.Num_H.Size = new System.Drawing.Size(31, 22);
            this.Num_H.TabIndex = 6;
            this.Num_H.Enter += new System.EventHandler(this.Num_H_Enter);
            // 
            // Lbl_Tip
            // 
            this.Lbl_Tip.AutoSize = true;
            this.Lbl_Tip.Location = new System.Drawing.Point(3, 3);
            this.Lbl_Tip.Name = "Lbl_Tip";
            this.Lbl_Tip.Size = new System.Drawing.Size(158, 12);
            this.Lbl_Tip.TabIndex = 8;
            this.Lbl_Tip.Text = "Press [F1] or set Time to Capture";
            // 
            // Rb_Combine
            // 
            this.Rb_Combine.AutoSize = true;
            this.Rb_Combine.Location = new System.Drawing.Point(112, 3);
            this.Rb_Combine.Name = "Rb_Combine";
            this.Rb_Combine.Size = new System.Drawing.Size(66, 16);
            this.Rb_Combine.TabIndex = 2;
            this.Rb_Combine.TabStop = true;
            this.Rb_Combine.Text = "Combine";
            this.Rb_Combine.UseVisualStyleBackColor = true;
            // 
            // Rb_Seperate
            // 
            this.Rb_Seperate.AutoSize = true;
            this.Rb_Seperate.Location = new System.Drawing.Point(182, 3);
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
            this.Lbl_Mode.Location = new System.Drawing.Point(0, 5);
            this.Lbl_Mode.Name = "Lbl_Mode";
            this.Lbl_Mode.Size = new System.Drawing.Size(111, 12);
            this.Lbl_Mode.TabIndex = 11;
            this.Lbl_Mode.Text = "Multiple screen mode :";
            // 
            // Num_FromH
            // 
            this.Num_FromH.Location = new System.Drawing.Point(57, 28);
            this.Num_FromH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Num_FromH.Name = "Num_FromH";
            this.Num_FromH.Size = new System.Drawing.Size(31, 22);
            this.Num_FromH.TabIndex = 12;
            this.Num_FromH.Enter += new System.EventHandler(this.Num_FromH_Enter);
            // 
            // Num_FromM
            // 
            this.Num_FromM.Location = new System.Drawing.Point(101, 28);
            this.Num_FromM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Num_FromM.Name = "Num_FromM";
            this.Num_FromM.Size = new System.Drawing.Size(31, 22);
            this.Num_FromM.TabIndex = 13;
            this.Num_FromM.Enter += new System.EventHandler(this.Num_FromM_Enter);
            // 
            // Num_FromS
            // 
            this.Num_FromS.Location = new System.Drawing.Point(146, 28);
            this.Num_FromS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Num_FromS.Name = "Num_FromS";
            this.Num_FromS.Size = new System.Drawing.Size(31, 22);
            this.Num_FromS.TabIndex = 14;
            this.Num_FromS.Enter += new System.EventHandler(this.Num_FromS_Enter);
            // 
            // Lbl_S6
            // 
            this.Lbl_S6.AutoSize = true;
            this.Lbl_S6.Location = new System.Drawing.Point(135, 33);
            this.Lbl_S6.Name = "Lbl_S6";
            this.Lbl_S6.Size = new System.Drawing.Size(8, 12);
            this.Lbl_S6.TabIndex = 16;
            this.Lbl_S6.Text = ":";
            // 
            // Lbl_S5
            // 
            this.Lbl_S5.AutoSize = true;
            this.Lbl_S5.Location = new System.Drawing.Point(90, 33);
            this.Lbl_S5.Name = "Lbl_S5";
            this.Lbl_S5.Size = new System.Drawing.Size(8, 12);
            this.Lbl_S5.TabIndex = 15;
            this.Lbl_S5.Text = ":";
            // 
            // Num_ToH
            // 
            this.Num_ToH.Location = new System.Drawing.Point(201, 28);
            this.Num_ToH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Num_ToH.Name = "Num_ToH";
            this.Num_ToH.Size = new System.Drawing.Size(31, 22);
            this.Num_ToH.TabIndex = 15;
            this.Num_ToH.Enter += new System.EventHandler(this.Num_ToH_Enter);
            // 
            // Num_ToM
            // 
            this.Num_ToM.Location = new System.Drawing.Point(245, 28);
            this.Num_ToM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Num_ToM.Name = "Num_ToM";
            this.Num_ToM.Size = new System.Drawing.Size(31, 22);
            this.Num_ToM.TabIndex = 16;
            this.Num_ToM.Enter += new System.EventHandler(this.Num_ToM_Enter);
            // 
            // Num_ToS
            // 
            this.Num_ToS.Location = new System.Drawing.Point(290, 28);
            this.Num_ToS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Num_ToS.Name = "Num_ToS";
            this.Num_ToS.Size = new System.Drawing.Size(31, 22);
            this.Num_ToS.TabIndex = 17;
            this.Num_ToS.Enter += new System.EventHandler(this.Num_ToS_Enter);
            // 
            // Lbl_S8
            // 
            this.Lbl_S8.AutoSize = true;
            this.Lbl_S8.Location = new System.Drawing.Point(279, 33);
            this.Lbl_S8.Name = "Lbl_S8";
            this.Lbl_S8.Size = new System.Drawing.Size(8, 12);
            this.Lbl_S8.TabIndex = 21;
            this.Lbl_S8.Text = ":";
            // 
            // Lbl_S7
            // 
            this.Lbl_S7.AutoSize = true;
            this.Lbl_S7.Location = new System.Drawing.Point(234, 33);
            this.Lbl_S7.Name = "Lbl_S7";
            this.Lbl_S7.Size = new System.Drawing.Size(8, 12);
            this.Lbl_S7.TabIndex = 20;
            this.Lbl_S7.Text = ":";
            // 
            // Lbl_Capturefreq
            // 
            this.Lbl_Capturefreq.AutoSize = true;
            this.Lbl_Capturefreq.Location = new System.Drawing.Point(0, 4);
            this.Lbl_Capturefreq.Name = "Lbl_Capturefreq";
            this.Lbl_Capturefreq.Size = new System.Drawing.Size(92, 12);
            this.Lbl_Capturefreq.TabIndex = 25;
            this.Lbl_Capturefreq.Text = "Capture freqency :";
            // 
            // Num_FreH
            // 
            this.Num_FreH.Location = new System.Drawing.Point(101, 1);
            this.Num_FreH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Num_FreH.Name = "Num_FreH";
            this.Num_FreH.Size = new System.Drawing.Size(31, 22);
            this.Num_FreH.TabIndex = 9;
            this.Num_FreH.Enter += new System.EventHandler(this.Num_FreH_Enter);
            // 
            // Num_FreM
            // 
            this.Num_FreM.Location = new System.Drawing.Point(145, 1);
            this.Num_FreM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Num_FreM.Name = "Num_FreM";
            this.Num_FreM.Size = new System.Drawing.Size(31, 22);
            this.Num_FreM.TabIndex = 10;
            this.Num_FreM.Enter += new System.EventHandler(this.Num_FreM_Enter);
            // 
            // Num_FreS
            // 
            this.Num_FreS.Location = new System.Drawing.Point(190, 1);
            this.Num_FreS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Num_FreS.Name = "Num_FreS";
            this.Num_FreS.Size = new System.Drawing.Size(31, 22);
            this.Num_FreS.TabIndex = 11;
            this.Num_FreS.Enter += new System.EventHandler(this.Num_FreS_Enter);
            // 
            // Lbl_S4
            // 
            this.Lbl_S4.AutoSize = true;
            this.Lbl_S4.Location = new System.Drawing.Point(179, 6);
            this.Lbl_S4.Name = "Lbl_S4";
            this.Lbl_S4.Size = new System.Drawing.Size(8, 12);
            this.Lbl_S4.TabIndex = 30;
            this.Lbl_S4.Text = ":";
            // 
            // Lbl_S3
            // 
            this.Lbl_S3.AutoSize = true;
            this.Lbl_S3.Location = new System.Drawing.Point(134, 6);
            this.Lbl_S3.Name = "Lbl_S3";
            this.Lbl_S3.Size = new System.Drawing.Size(8, 12);
            this.Lbl_S3.TabIndex = 29;
            this.Lbl_S3.Text = ":";
            // 
            // Pl_ScreenMode
            // 
            this.Pl_ScreenMode.Controls.Add(this.Lbl_Mode);
            this.Pl_ScreenMode.Controls.Add(this.Rb_Seperate);
            this.Pl_ScreenMode.Controls.Add(this.Rb_Combine);
            this.Pl_ScreenMode.Location = new System.Drawing.Point(3, 18);
            this.Pl_ScreenMode.Name = "Pl_ScreenMode";
            this.Pl_ScreenMode.Size = new System.Drawing.Size(250, 19);
            this.Pl_ScreenMode.TabIndex = 2;
            // 
            // Pl_Ontime
            // 
            this.Pl_Ontime.Controls.Add(this.Lbl_SetTime_1);
            this.Pl_Ontime.Controls.Add(this.Num_S);
            this.Pl_Ontime.Controls.Add(this.Lbl_S1);
            this.Pl_Ontime.Controls.Add(this.Lbl_S2);
            this.Pl_Ontime.Controls.Add(this.Num_M);
            this.Pl_Ontime.Controls.Add(this.Num_H);
            this.Pl_Ontime.Location = new System.Drawing.Point(3, 58);
            this.Pl_Ontime.Name = "Pl_Ontime";
            this.Pl_Ontime.Size = new System.Drawing.Size(250, 29);
            this.Pl_Ontime.TabIndex = 4;
            // 
            // Pl_TimeMode
            // 
            this.Pl_TimeMode.Controls.Add(this.Lbl_TimeMode);
            this.Pl_TimeMode.Controls.Add(this.Rb_Fromto);
            this.Pl_TimeMode.Controls.Add(this.Rb_Ontime);
            this.Pl_TimeMode.Location = new System.Drawing.Point(3, 38);
            this.Pl_TimeMode.Name = "Pl_TimeMode";
            this.Pl_TimeMode.Size = new System.Drawing.Size(250, 19);
            this.Pl_TimeMode.TabIndex = 3;
            // 
            // Lbl_TimeMode
            // 
            this.Lbl_TimeMode.AutoSize = true;
            this.Lbl_TimeMode.Location = new System.Drawing.Point(0, 5);
            this.Lbl_TimeMode.Name = "Lbl_TimeMode";
            this.Lbl_TimeMode.Size = new System.Drawing.Size(101, 12);
            this.Lbl_TimeMode.TabIndex = 27;
            this.Lbl_TimeMode.Text = "Time capture mode :";
            // 
            // Rb_Fromto
            // 
            this.Rb_Fromto.AutoSize = true;
            this.Rb_Fromto.Location = new System.Drawing.Point(182, 3);
            this.Rb_Fromto.Name = "Rb_Fromto";
            this.Rb_Fromto.Size = new System.Drawing.Size(65, 16);
            this.Rb_Fromto.TabIndex = 5;
            this.Rb_Fromto.TabStop = true;
            this.Rb_Fromto.Text = "From-To";
            this.Rb_Fromto.UseVisualStyleBackColor = true;
            // 
            // Rb_Ontime
            // 
            this.Rb_Ontime.AutoSize = true;
            this.Rb_Ontime.Location = new System.Drawing.Point(112, 3);
            this.Rb_Ontime.Name = "Rb_Ontime";
            this.Rb_Ontime.Size = new System.Drawing.Size(65, 16);
            this.Rb_Ontime.TabIndex = 4;
            this.Rb_Ontime.TabStop = true;
            this.Rb_Ontime.Text = "On-Time";
            this.Rb_Ontime.UseVisualStyleBackColor = true;
            this.Rb_Ontime.CheckedChanged += new System.EventHandler(this.Rb_Ontime_CheckedChanged);
            // 
            // Pl_Fromto
            // 
            this.Pl_Fromto.Controls.Add(this.label1);
            this.Pl_Fromto.Controls.Add(this.Lbl_S9);
            this.Pl_Fromto.Controls.Add(this.Lbl_Capturefreq);
            this.Pl_Fromto.Controls.Add(this.Lbl_S3);
            this.Pl_Fromto.Controls.Add(this.Lbl_S4);
            this.Pl_Fromto.Controls.Add(this.Num_FreS);
            this.Pl_Fromto.Controls.Add(this.Num_FreM);
            this.Pl_Fromto.Controls.Add(this.Num_ToH);
            this.Pl_Fromto.Controls.Add(this.Num_FreH);
            this.Pl_Fromto.Controls.Add(this.Num_ToM);
            this.Pl_Fromto.Controls.Add(this.Num_FromS);
            this.Pl_Fromto.Controls.Add(this.Num_ToS);
            this.Pl_Fromto.Controls.Add(this.Lbl_S5);
            this.Pl_Fromto.Controls.Add(this.Lbl_S8);
            this.Pl_Fromto.Controls.Add(this.Lbl_S6);
            this.Pl_Fromto.Controls.Add(this.Lbl_S7);
            this.Pl_Fromto.Controls.Add(this.Num_FromM);
            this.Pl_Fromto.Controls.Add(this.Num_FromH);
            this.Pl_Fromto.Location = new System.Drawing.Point(3, 61);
            this.Pl_Fromto.Name = "Pl_Fromto";
            this.Pl_Fromto.Size = new System.Drawing.Size(339, 56);
            this.Pl_Fromto.TabIndex = 5;
            // 
            // Lbl_S9
            // 
            this.Lbl_S9.AutoSize = true;
            this.Lbl_S9.Location = new System.Drawing.Point(184, 32);
            this.Lbl_S9.Name = "Lbl_S9";
            this.Lbl_S9.Size = new System.Drawing.Size(11, 12);
            this.Lbl_S9.TabIndex = 31;
            this.Lbl_S9.Text = "~";
            // 
            // Lbl_SetTime_1
            // 
            this.Lbl_SetTime_1.AutoSize = true;
            this.Lbl_SetTime_1.Location = new System.Drawing.Point(0, 8);
            this.Lbl_SetTime_1.Name = "Lbl_SetTime_1";
            this.Lbl_SetTime_1.Size = new System.Drawing.Size(52, 12);
            this.Lbl_SetTime_1.TabIndex = 28;
            this.Lbl_SetTime_1.Text = "Set Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "Set Time :";
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(344, 117);
            this.Controls.Add(this.Pl_Fromto);
            this.Controls.Add(this.Pl_TimeMode);
            this.Controls.Add(this.Pl_Ontime);
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
            ((System.ComponentModel.ISupportInitialize)(this.Num_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FromH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FromM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FromS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ToH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ToM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ToS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FreH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FreM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_FreS)).EndInit();
            this.Pl_ScreenMode.ResumeLayout(false);
            this.Pl_ScreenMode.PerformLayout();
            this.Pl_Ontime.ResumeLayout(false);
            this.Pl_Ontime.PerformLayout();
            this.Pl_TimeMode.ResumeLayout(false);
            this.Pl_TimeMode.PerformLayout();
            this.Pl_Fromto.ResumeLayout(false);
            this.Pl_Fromto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Button Btn_Folder;
        private System.Windows.Forms.Label Lbl_S1;
        private System.Windows.Forms.Label Lbl_S2;
        private System.Windows.Forms.NotifyIcon notifyIcon_min;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NumericUpDown Num_S;
        private System.Windows.Forms.NumericUpDown Num_M;
        private System.Windows.Forms.NumericUpDown Num_H;
        private System.Windows.Forms.Label Lbl_Tip;
        private System.Windows.Forms.RadioButton Rb_Combine;
        private System.Windows.Forms.RadioButton Rb_Seperate;
        private System.Windows.Forms.Label Lbl_Mode;
        private System.Windows.Forms.NumericUpDown Num_FromH;
        private System.Windows.Forms.NumericUpDown Num_FromM;
        private System.Windows.Forms.NumericUpDown Num_FromS;
        private System.Windows.Forms.Label Lbl_S6;
        private System.Windows.Forms.Label Lbl_S5;
        private System.Windows.Forms.NumericUpDown Num_ToH;
        private System.Windows.Forms.NumericUpDown Num_ToM;
        private System.Windows.Forms.NumericUpDown Num_ToS;
        private System.Windows.Forms.Label Lbl_S8;
        private System.Windows.Forms.Label Lbl_S7;
        private System.Windows.Forms.Label Lbl_Capturefreq;
        private System.Windows.Forms.NumericUpDown Num_FreH;
        private System.Windows.Forms.NumericUpDown Num_FreM;
        private System.Windows.Forms.NumericUpDown Num_FreS;
        private System.Windows.Forms.Label Lbl_S4;
        private System.Windows.Forms.Label Lbl_S3;
        private System.Windows.Forms.Panel Pl_ScreenMode;
        private System.Windows.Forms.Panel Pl_Ontime;
        private System.Windows.Forms.Panel Pl_TimeMode;
        private System.Windows.Forms.Label Lbl_TimeMode;
        private System.Windows.Forms.RadioButton Rb_Fromto;
        private System.Windows.Forms.RadioButton Rb_Ontime;
        private System.Windows.Forms.Panel Pl_Fromto;
        private System.Windows.Forms.Label Lbl_S9;
        private System.Windows.Forms.Label Lbl_SetTime_1;
        private System.Windows.Forms.Label label1;
    }
}

