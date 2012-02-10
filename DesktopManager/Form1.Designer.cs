namespace DesktopManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIconStatus = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listCurrent = new System.Windows.Forms.ListBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupList = new System.Windows.Forms.GroupBox();
            this.bListAddDir = new System.Windows.Forms.Button();
            this.bListLoad = new System.Windows.Forms.Button();
            this.bClearList = new System.Windows.Forms.Button();
            this.bListSave = new System.Windows.Forms.Button();
            this.groupWall = new System.Windows.Forms.GroupBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.bSetWallpaper = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupLanguage = new System.Windows.Forms.GroupBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.groupTimer = new System.Windows.Forms.GroupBox();
            this.numericTimer = new System.Windows.Forms.NumericUpDown();
            this.cbUseTimer = new System.Windows.Forms.CheckBox();
            this.groupStyle = new System.Windows.Forms.GroupBox();
            this.cbStretch = new System.Windows.Forms.CheckBox();
            this.radioCenter = new System.Windows.Forms.RadioButton();
            this.radioTile = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStripNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupList.SuspendLayout();
            this.groupWall.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupLanguage.SuspendLayout();
            this.groupTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimer)).BeginInit();
            this.groupStyle.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconStatus
            // 
            this.notifyIconStatus.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIconStatus, "notifyIconStatus");
            this.notifyIconStatus.ContextMenuStrip = this.contextMenuStripNotify;
            this.notifyIconStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconStatus_MouseClick);
            // 
            // contextMenuStripNotify
            // 
            this.contextMenuStripNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStripNotify.Name = "contextMenuStripNotify";
            resources.ApplyResources(this.contextMenuStripNotify, "contextMenuStripNotify");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listCurrent
            // 
            this.listCurrent.FormattingEnabled = true;
            resources.ApplyResources(this.listCurrent, "listCurrent");
            this.listCurrent.Name = "listCurrent";
            this.listCurrent.SelectedIndexChanged += new System.EventHandler(this.listCurrent_SelectedIndexChanged);
            // 
            // pictureBoxPreview
            // 
            resources.ApplyResources(this.pictureBoxPreview, "pictureBoxPreview");
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupList);
            this.tabPage1.Controls.Add(this.groupWall);
            this.tabPage1.Controls.Add(this.bSetWallpaper);
            this.tabPage1.Controls.Add(this.pictureBoxPreview);
            this.tabPage1.Controls.Add(this.listCurrent);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupList
            // 
            this.groupList.Controls.Add(this.bListAddDir);
            this.groupList.Controls.Add(this.bListLoad);
            this.groupList.Controls.Add(this.bClearList);
            this.groupList.Controls.Add(this.bListSave);
            resources.ApplyResources(this.groupList, "groupList");
            this.groupList.Name = "groupList";
            this.groupList.TabStop = false;
            // 
            // bListAddDir
            // 
            resources.ApplyResources(this.bListAddDir, "bListAddDir");
            this.bListAddDir.Name = "bListAddDir";
            this.bListAddDir.UseVisualStyleBackColor = true;
            this.bListAddDir.Click += new System.EventHandler(this.bListAddDir_Click_1);
            // 
            // bListLoad
            // 
            resources.ApplyResources(this.bListLoad, "bListLoad");
            this.bListLoad.Name = "bListLoad";
            this.bListLoad.UseVisualStyleBackColor = true;
            this.bListLoad.Click += new System.EventHandler(this.bListLoad_Click_1);
            // 
            // bClearList
            // 
            resources.ApplyResources(this.bClearList, "bClearList");
            this.bClearList.Name = "bClearList";
            this.bClearList.UseVisualStyleBackColor = true;
            this.bClearList.Click += new System.EventHandler(this.bClearList_Click);
            // 
            // bListSave
            // 
            resources.ApplyResources(this.bListSave, "bListSave");
            this.bListSave.Name = "bListSave";
            this.bListSave.UseVisualStyleBackColor = true;
            this.bListSave.Click += new System.EventHandler(this.bListSave_Click_1);
            // 
            // groupWall
            // 
            this.groupWall.Controls.Add(this.bAdd);
            this.groupWall.Controls.Add(this.bRemove);
            resources.ApplyResources(this.groupWall, "groupWall");
            this.groupWall.Name = "groupWall";
            this.groupWall.TabStop = false;
            // 
            // bAdd
            // 
            resources.ApplyResources(this.bAdd, "bAdd");
            this.bAdd.Name = "bAdd";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bRemove
            // 
            resources.ApplyResources(this.bRemove, "bRemove");
            this.bRemove.Name = "bRemove";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bSetWallpaper
            // 
            resources.ApplyResources(this.bSetWallpaper, "bSetWallpaper");
            this.bSetWallpaper.Name = "bSetWallpaper";
            this.bSetWallpaper.UseVisualStyleBackColor = true;
            this.bSetWallpaper.Click += new System.EventHandler(this.bSetWallpaper_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupLanguage);
            this.tabPage3.Controls.Add(this.groupTimer);
            this.tabPage3.Controls.Add(this.groupStyle);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupLanguage
            // 
            this.groupLanguage.Controls.Add(this.cbLanguage);
            resources.ApplyResources(this.groupLanguage, "groupLanguage");
            this.groupLanguage.Name = "groupLanguage";
            this.groupLanguage.TabStop = false;
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            resources.GetString("cbLanguage.Items"),
            resources.GetString("cbLanguage.Items1")});
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            this.cbLanguage.SelectedValueChanged += new System.EventHandler(this.cbLanguage_SelectedValueChanged);
            // 
            // groupTimer
            // 
            this.groupTimer.Controls.Add(this.numericTimer);
            this.groupTimer.Controls.Add(this.cbUseTimer);
            resources.ApplyResources(this.groupTimer, "groupTimer");
            this.groupTimer.Name = "groupTimer";
            this.groupTimer.TabStop = false;
            // 
            // numericTimer
            // 
            resources.ApplyResources(this.numericTimer, "numericTimer");
            this.numericTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTimer.Name = "numericTimer";
            this.numericTimer.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericTimer.ValueChanged += new System.EventHandler(this.numericTimer_ValueChanged);
            // 
            // cbUseTimer
            // 
            resources.ApplyResources(this.cbUseTimer, "cbUseTimer");
            this.cbUseTimer.Name = "cbUseTimer";
            this.cbUseTimer.UseVisualStyleBackColor = true;
            this.cbUseTimer.CheckedChanged += new System.EventHandler(this.cbUseTimer_CheckedChanged);
            // 
            // groupStyle
            // 
            this.groupStyle.Controls.Add(this.cbStretch);
            this.groupStyle.Controls.Add(this.radioCenter);
            this.groupStyle.Controls.Add(this.radioTile);
            resources.ApplyResources(this.groupStyle, "groupStyle");
            this.groupStyle.Name = "groupStyle";
            this.groupStyle.TabStop = false;
            // 
            // cbStretch
            // 
            resources.ApplyResources(this.cbStretch, "cbStretch");
            this.cbStretch.Name = "cbStretch";
            this.cbStretch.UseVisualStyleBackColor = true;
            // 
            // radioCenter
            // 
            resources.ApplyResources(this.radioCenter, "radioCenter");
            this.radioCenter.Checked = true;
            this.radioCenter.Name = "radioCenter";
            this.radioCenter.TabStop = true;
            this.radioCenter.UseVisualStyleBackColor = true;
            // 
            // radioTile
            // 
            resources.ApplyResources(this.radioTile, "radioTile");
            this.radioTile.Name = "radioTile";
            this.radioTile.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStripNotify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupList.ResumeLayout(false);
            this.groupWall.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupLanguage.ResumeLayout(false);
            this.groupTimer.ResumeLayout(false);
            this.groupTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimer)).EndInit();
            this.groupStyle.ResumeLayout(false);
            this.groupStyle.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listCurrent;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupStyle;
        private System.Windows.Forms.CheckBox cbStretch;
        private System.Windows.Forms.RadioButton radioCenter;
        private System.Windows.Forms.RadioButton radioTile;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSetWallpaper;
        private System.Windows.Forms.GroupBox groupTimer;
        private System.Windows.Forms.NumericUpDown numericTimer;
        private System.Windows.Forms.CheckBox cbUseTimer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotify;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupWall;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button bListAddDir;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bClearList;
        private System.Windows.Forms.Button bListLoad;
        private System.Windows.Forms.Button bListSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupLanguage;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.Label label2;
    }
}

