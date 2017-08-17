namespace Parkinson_Recorder
{
    partial class ProgramMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramMainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindowTabControl = new System.Windows.Forms.TabControl();
            this.recorderViewTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.communicationTabPage = new System.Windows.Forms.TabPage();
            this.connectionSettingsTabPage = new System.Windows.Forms.TabPage();
            this.tabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainWindowStatusStrip = new System.Windows.Forms.StatusStrip();
            this.newMeasureButton = new System.Windows.Forms.Button();
            this.openMeasureButton = new System.Windows.Forms.Button();
            this.saveMeasureButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip.SuspendLayout();
            this.mainWindowTabControl.SuspendLayout();
            this.recorderViewTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(992, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Wyjście";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainWindowTabControl
            // 
            this.mainWindowTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainWindowTabControl.Controls.Add(this.recorderViewTabPage);
            this.mainWindowTabControl.Controls.Add(this.communicationTabPage);
            this.mainWindowTabControl.Controls.Add(this.connectionSettingsTabPage);
            this.mainWindowTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowTabControl.ImageList = this.tabControlImageList;
            this.mainWindowTabControl.ItemSize = new System.Drawing.Size(100, 100);
            this.mainWindowTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainWindowTabControl.Multiline = true;
            this.mainWindowTabControl.Name = "mainWindowTabControl";
            this.mainWindowTabControl.SelectedIndex = 0;
            this.mainWindowTabControl.Size = new System.Drawing.Size(992, 623);
            this.mainWindowTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainWindowTabControl.TabIndex = 1;
            // 
            // recorderViewTabPage
            // 
            this.recorderViewTabPage.Controls.Add(this.tableLayoutPanel2);
            this.recorderViewTabPage.Controls.Add(this.tableLayoutPanel1);
            this.recorderViewTabPage.Location = new System.Drawing.Point(104, 4);
            this.recorderViewTabPage.Name = "recorderViewTabPage";
            this.recorderViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recorderViewTabPage.Size = new System.Drawing.Size(884, 615);
            this.recorderViewTabPage.TabIndex = 0;
            this.recorderViewTabPage.Text = "recorderViewtabPage";
            this.recorderViewTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.Controls.Add(this.newMeasureButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.openMeasureButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveMeasureButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.splitter1, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 88);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 0);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // communicationTabPage
            // 
            this.communicationTabPage.Location = new System.Drawing.Point(104, 4);
            this.communicationTabPage.Name = "communicationTabPage";
            this.communicationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.communicationTabPage.Size = new System.Drawing.Size(884, 615);
            this.communicationTabPage.TabIndex = 1;
            this.communicationTabPage.Text = "communicationTabPage";
            this.communicationTabPage.UseVisualStyleBackColor = true;
            // 
            // connectionSettingsTabPage
            // 
            this.connectionSettingsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.connectionSettingsTabPage.Location = new System.Drawing.Point(104, 4);
            this.connectionSettingsTabPage.Name = "connectionSettingsTabPage";
            this.connectionSettingsTabPage.Size = new System.Drawing.Size(884, 615);
            this.connectionSettingsTabPage.TabIndex = 2;
            this.connectionSettingsTabPage.Text = "connectionSettingsTabPage";
            // 
            // tabControlImageList
            // 
            this.tabControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabControlImageList.ImageStream")));
            this.tabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabControlImageList.Images.SetKeyName(0, "Connect_Icon.png");
            this.tabControlImageList.Images.SetKeyName(1, "Disconnect_Icon.png");
            // 
            // mainWindowStatusStrip
            // 
            this.mainWindowStatusStrip.Location = new System.Drawing.Point(0, 625);
            this.mainWindowStatusStrip.Name = "mainWindowStatusStrip";
            this.mainWindowStatusStrip.Size = new System.Drawing.Size(992, 22);
            this.mainWindowStatusStrip.TabIndex = 2;
            this.mainWindowStatusStrip.Text = "statusStrip1";
            // 
            // newMeasureButton
            // 
            this.newMeasureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMeasureButton.ImageIndex = 0;
            this.newMeasureButton.Location = new System.Drawing.Point(3, 3);
            this.newMeasureButton.Name = "newMeasureButton";
            this.newMeasureButton.Size = new System.Drawing.Size(59, 74);
            this.newMeasureButton.TabIndex = 0;
            this.newMeasureButton.Text = "newMeasureButton";
            this.newMeasureButton.UseVisualStyleBackColor = true;
            // 
            // openMeasureButton
            // 
            this.openMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openMeasureButton.Location = new System.Drawing.Point(68, 3);
            this.openMeasureButton.Name = "openMeasureButton";
            this.openMeasureButton.Size = new System.Drawing.Size(62, 74);
            this.openMeasureButton.TabIndex = 1;
            this.openMeasureButton.Text = "openMeasureButton";
            this.openMeasureButton.UseVisualStyleBackColor = true;
            // 
            // saveMeasureButton
            // 
            this.saveMeasureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveMeasureButton.Location = new System.Drawing.Point(136, 3);
            this.saveMeasureButton.Name = "saveMeasureButton";
            this.saveMeasureButton.Size = new System.Drawing.Size(55, 74);
            this.saveMeasureButton.TabIndex = 2;
            this.saveMeasureButton.Text = "saveMeasureButton";
            this.saveMeasureButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(215, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(197, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 74);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // ProgramMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 647);
            this.Controls.Add(this.mainWindowStatusStrip);
            this.Controls.Add(this.mainWindowTabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ProgramMainWindow";
            this.Text = "Parkinson Recorder";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainWindowTabControl.ResumeLayout(false);
            this.recorderViewTabPage.ResumeLayout(false);
            this.recorderViewTabPage.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage recorderViewTabPage;
        private System.Windows.Forms.TabPage communicationTabPage;
        private System.Windows.Forms.TabControl mainWindowTabControl;
        private System.Windows.Forms.ImageList tabControlImageList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.StatusStrip mainWindowStatusStrip;
        private System.Windows.Forms.TabPage connectionSettingsTabPage;
        private System.Windows.Forms.Button newMeasureButton;
        private System.Windows.Forms.Button openMeasureButton;
        private System.Windows.Forms.Button saveMeasureButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
    }
}

