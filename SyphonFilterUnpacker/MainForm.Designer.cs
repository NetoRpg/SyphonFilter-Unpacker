namespace SyphonFilterUnpacker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FOG = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chBoxRepack = new System.Windows.Forms.CheckBox();
            this.txtFOGSaveRepack = new System.Windows.Forms.TextBox();
            this.txtFOGRepackOpen = new System.Windows.Forms.TextBox();
            this.btnFOGRepack = new System.Windows.Forms.Button();
            this.btnFOGUnpackSave = new System.Windows.Forms.Button();
            this.btnFOGRepackOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUnpackOpenPath = new System.Windows.Forms.TextBox();
            this.btnFOGUnpackOpen = new System.Windows.Forms.Button();
            this.chBoxUnpack = new System.Windows.Forms.CheckBox();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.HOG = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtHOGRepackSave = new System.Windows.Forms.TextBox();
            this.txtHOGRepackOpen = new System.Windows.Forms.TextBox();
            this.btnHOGRepack = new System.Windows.Forms.Button();
            this.btnHOGRepackSave = new System.Windows.Forms.Button();
            this.btnHOGRepackOpen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHOGUnpack = new System.Windows.Forms.Button();
            this.txtHOGUnpackOpen = new System.Windows.Forms.TextBox();
            this.btnHOGUnpackOpen = new System.Windows.Forms.Button();
            this.statStrip = new System.Windows.Forms.StatusStrip();
            this.ssLblStat = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssPB = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.FOG.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.HOG.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // unpackToolStripMenuItem
            // 
            this.unpackToolStripMenuItem.Name = "unpackToolStripMenuItem";
            this.unpackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unpackToolStripMenuItem.Text = "Unpack";
            // 
            // repackToolStripMenuItem
            // 
            this.repackToolStripMenuItem.Name = "repackToolStripMenuItem";
            this.repackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.repackToolStripMenuItem.Text = "Repack";
            this.repackToolStripMenuItem.Click += new System.EventHandler(this.repackToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem1});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aToolStripMenuItem.Text = "File";
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.aToolStripMenuItem1.Text = "Exit";
            this.aToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FOG);
            this.tabControl1.Controls.Add(this.HOG);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 260);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // FOG
            // 
            this.FOG.Controls.Add(this.groupBox2);
            this.FOG.Controls.Add(this.groupBox1);
            this.FOG.Location = new System.Drawing.Point(4, 22);
            this.FOG.Name = "FOG";
            this.FOG.Padding = new System.Windows.Forms.Padding(3);
            this.FOG.Size = new System.Drawing.Size(412, 234);
            this.FOG.TabIndex = 0;
            this.FOG.Text = "FOG";
            this.FOG.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chBoxRepack);
            this.groupBox2.Controls.Add(this.txtFOGSaveRepack);
            this.groupBox2.Controls.Add(this.txtFOGRepackOpen);
            this.groupBox2.Controls.Add(this.btnFOGRepack);
            this.groupBox2.Controls.Add(this.btnFOGUnpackSave);
            this.groupBox2.Controls.Add(this.btnFOGRepackOpen);
            this.groupBox2.Location = new System.Drawing.Point(3, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 128);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Repack";
            // 
            // chBoxRepack
            // 
            this.chBoxRepack.AutoSize = true;
            this.chBoxRepack.Location = new System.Drawing.Point(7, 100);
            this.chBoxRepack.Name = "chBoxRepack";
            this.chBoxRepack.Size = new System.Drawing.Size(96, 17);
            this.chBoxRepack.TabIndex = 5;
            this.chBoxRepack.Text = "Repack HOGs";
            this.chBoxRepack.UseVisualStyleBackColor = true;
            // 
            // txtFOGSaveRepack
            // 
            this.txtFOGSaveRepack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFOGSaveRepack.Location = new System.Drawing.Point(7, 51);
            this.txtFOGSaveRepack.Name = "txtFOGSaveRepack";
            this.txtFOGSaveRepack.Size = new System.Drawing.Size(310, 20);
            this.txtFOGSaveRepack.TabIndex = 4;
            // 
            // txtFOGRepackOpen
            // 
            this.txtFOGRepackOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFOGRepackOpen.Location = new System.Drawing.Point(7, 21);
            this.txtFOGRepackOpen.Name = "txtFOGRepackOpen";
            this.txtFOGRepackOpen.Size = new System.Drawing.Size(310, 20);
            this.txtFOGRepackOpen.TabIndex = 3;
            // 
            // btnFOGRepack
            // 
            this.btnFOGRepack.Location = new System.Drawing.Point(323, 96);
            this.btnFOGRepack.Name = "btnFOGRepack";
            this.btnFOGRepack.Size = new System.Drawing.Size(75, 23);
            this.btnFOGRepack.TabIndex = 2;
            this.btnFOGRepack.Text = "Repack";
            this.btnFOGRepack.UseVisualStyleBackColor = true;
            this.btnFOGRepack.Click += new System.EventHandler(this.btnFOGRepack_Click);
            // 
            // btnFOGUnpackSave
            // 
            this.btnFOGUnpackSave.Location = new System.Drawing.Point(323, 49);
            this.btnFOGUnpackSave.Name = "btnFOGUnpackSave";
            this.btnFOGUnpackSave.Size = new System.Drawing.Size(75, 23);
            this.btnFOGUnpackSave.TabIndex = 1;
            this.btnFOGUnpackSave.Text = "Save";
            this.btnFOGUnpackSave.UseVisualStyleBackColor = true;
            this.btnFOGUnpackSave.Click += new System.EventHandler(this.btnFOGUnpackSave_Click);
            // 
            // btnFOGRepackOpen
            // 
            this.btnFOGRepackOpen.Location = new System.Drawing.Point(323, 19);
            this.btnFOGRepackOpen.Name = "btnFOGRepackOpen";
            this.btnFOGRepackOpen.Size = new System.Drawing.Size(75, 23);
            this.btnFOGRepackOpen.TabIndex = 0;
            this.btnFOGRepackOpen.Text = "Open";
            this.btnFOGRepackOpen.UseVisualStyleBackColor = true;
            this.btnFOGRepackOpen.Click += new System.EventHandler(this.btnFOGRepackOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUnpackOpenPath);
            this.groupBox1.Controls.Add(this.btnFOGUnpackOpen);
            this.groupBox1.Controls.Add(this.chBoxUnpack);
            this.groupBox1.Controls.Add(this.btnUnpack);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unpack";
            // 
            // txtUnpackOpenPath
            // 
            this.txtUnpackOpenPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUnpackOpenPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnpackOpenPath.Location = new System.Drawing.Point(7, 21);
            this.txtUnpackOpenPath.Name = "txtUnpackOpenPath";
            this.txtUnpackOpenPath.ReadOnly = true;
            this.txtUnpackOpenPath.Size = new System.Drawing.Size(310, 20);
            this.txtUnpackOpenPath.TabIndex = 3;
            // 
            // btnFOGUnpackOpen
            // 
            this.btnFOGUnpackOpen.Location = new System.Drawing.Point(323, 19);
            this.btnFOGUnpackOpen.Name = "btnFOGUnpackOpen";
            this.btnFOGUnpackOpen.Size = new System.Drawing.Size(75, 23);
            this.btnFOGUnpackOpen.TabIndex = 1;
            this.btnFOGUnpackOpen.Text = "Open";
            this.btnFOGUnpackOpen.UseVisualStyleBackColor = true;
            this.btnFOGUnpackOpen.Click += new System.EventHandler(this.btnUnpackOpen_Click);
            // 
            // chBoxUnpack
            // 
            this.chBoxUnpack.AutoSize = true;
            this.chBoxUnpack.Location = new System.Drawing.Point(7, 68);
            this.chBoxUnpack.Name = "chBoxUnpack";
            this.chBoxUnpack.Size = new System.Drawing.Size(96, 17);
            this.chBoxUnpack.TabIndex = 0;
            this.chBoxUnpack.Text = "Unpack HOGs";
            this.chBoxUnpack.UseVisualStyleBackColor = true;
            // 
            // btnUnpack
            // 
            this.btnUnpack.Location = new System.Drawing.Point(323, 64);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(75, 23);
            this.btnUnpack.TabIndex = 2;
            this.btnUnpack.Text = "Unpack";
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // HOG
            // 
            this.HOG.Controls.Add(this.groupBox4);
            this.HOG.Controls.Add(this.groupBox3);
            this.HOG.Location = new System.Drawing.Point(4, 22);
            this.HOG.Name = "HOG";
            this.HOG.Padding = new System.Windows.Forms.Padding(3);
            this.HOG.Size = new System.Drawing.Size(412, 234);
            this.HOG.TabIndex = 1;
            this.HOG.Text = "HOG";
            this.HOG.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtHOGRepackSave);
            this.groupBox4.Controls.Add(this.txtHOGRepackOpen);
            this.groupBox4.Controls.Add(this.btnHOGRepack);
            this.groupBox4.Controls.Add(this.btnHOGRepackSave);
            this.groupBox4.Controls.Add(this.btnHOGRepackOpen);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 128);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Repack";
            // 
            // txtHOGRepackSave
            // 
            this.txtHOGRepackSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHOGRepackSave.Location = new System.Drawing.Point(7, 51);
            this.txtHOGRepackSave.Name = "txtHOGRepackSave";
            this.txtHOGRepackSave.Size = new System.Drawing.Size(310, 20);
            this.txtHOGRepackSave.TabIndex = 4;
            // 
            // txtHOGRepackOpen
            // 
            this.txtHOGRepackOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHOGRepackOpen.Location = new System.Drawing.Point(7, 21);
            this.txtHOGRepackOpen.Name = "txtHOGRepackOpen";
            this.txtHOGRepackOpen.Size = new System.Drawing.Size(310, 20);
            this.txtHOGRepackOpen.TabIndex = 3;
            // 
            // btnHOGRepack
            // 
            this.btnHOGRepack.Location = new System.Drawing.Point(323, 96);
            this.btnHOGRepack.Name = "btnHOGRepack";
            this.btnHOGRepack.Size = new System.Drawing.Size(75, 23);
            this.btnHOGRepack.TabIndex = 2;
            this.btnHOGRepack.Text = "Repack";
            this.btnHOGRepack.UseVisualStyleBackColor = true;
            this.btnHOGRepack.Click += new System.EventHandler(this.btnHOGRepack_Click);
            // 
            // btnHOGRepackSave
            // 
            this.btnHOGRepackSave.Location = new System.Drawing.Point(323, 49);
            this.btnHOGRepackSave.Name = "btnHOGRepackSave";
            this.btnHOGRepackSave.Size = new System.Drawing.Size(75, 23);
            this.btnHOGRepackSave.TabIndex = 1;
            this.btnHOGRepackSave.Text = "Save";
            this.btnHOGRepackSave.UseVisualStyleBackColor = true;
            this.btnHOGRepackSave.Click += new System.EventHandler(this.btnHOGRepackSave_Click);
            // 
            // btnHOGRepackOpen
            // 
            this.btnHOGRepackOpen.Location = new System.Drawing.Point(323, 19);
            this.btnHOGRepackOpen.Name = "btnHOGRepackOpen";
            this.btnHOGRepackOpen.Size = new System.Drawing.Size(75, 23);
            this.btnHOGRepackOpen.TabIndex = 0;
            this.btnHOGRepackOpen.Text = "Open";
            this.btnHOGRepackOpen.UseVisualStyleBackColor = true;
            this.btnHOGRepackOpen.Click += new System.EventHandler(this.btnHOGRepackOpen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHOGUnpack);
            this.groupBox3.Controls.Add(this.txtHOGUnpackOpen);
            this.groupBox3.Controls.Add(this.btnHOGUnpackOpen);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unpack";
            // 
            // btnHOGUnpack
            // 
            this.btnHOGUnpack.Location = new System.Drawing.Point(323, 64);
            this.btnHOGUnpack.Name = "btnHOGUnpack";
            this.btnHOGUnpack.Size = new System.Drawing.Size(75, 23);
            this.btnHOGUnpack.TabIndex = 2;
            this.btnHOGUnpack.Text = "Unpack";
            this.btnHOGUnpack.UseVisualStyleBackColor = true;
            this.btnHOGUnpack.Click += new System.EventHandler(this.btnHOGUnpack_Click);
            // 
            // txtHOGUnpackOpen
            // 
            this.txtHOGUnpackOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHOGUnpackOpen.Location = new System.Drawing.Point(7, 21);
            this.txtHOGUnpackOpen.Name = "txtHOGUnpackOpen";
            this.txtHOGUnpackOpen.Size = new System.Drawing.Size(310, 20);
            this.txtHOGUnpackOpen.TabIndex = 1;
            // 
            // btnHOGUnpackOpen
            // 
            this.btnHOGUnpackOpen.Location = new System.Drawing.Point(323, 19);
            this.btnHOGUnpackOpen.Name = "btnHOGUnpackOpen";
            this.btnHOGUnpackOpen.Size = new System.Drawing.Size(75, 23);
            this.btnHOGUnpackOpen.TabIndex = 0;
            this.btnHOGUnpackOpen.Text = "Open";
            this.btnHOGUnpackOpen.UseVisualStyleBackColor = true;
            this.btnHOGUnpackOpen.Click += new System.EventHandler(this.btnHOGUnpackOpen_Click);
            // 
            // statStrip
            // 
            this.statStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.ssLblStat,
            this.ssPB});
            this.statStrip.Location = new System.Drawing.Point(0, 279);
            this.statStrip.Name = "statStrip";
            this.statStrip.Size = new System.Drawing.Size(420, 24);
            this.statStrip.SizingGrip = false;
            this.statStrip.Stretch = false;
            this.statStrip.TabIndex = 5;
            this.statStrip.Text = "statusStrip1";
            // 
            // ssLblStat
            // 
            this.ssLblStat.AutoSize = false;
            this.ssLblStat.Name = "ssLblStat";
            this.ssLblStat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ssLblStat.Size = new System.Drawing.Size(294, 19);
            this.ssLblStat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ssPB
            // 
            this.ssPB.Name = "ssPB";
            this.ssPB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ssPB.Size = new System.Drawing.Size(100, 18);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(22, 19);
            this.toolStripStatusLabel2.Text = "2.2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(420, 303);
            this.Controls.Add(this.statStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syphon Filter Unpacker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.FOG.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HOG.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statStrip.ResumeLayout(false);
            this.statStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repackToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FOG;
        private System.Windows.Forms.TabPage HOG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFOGUnpackOpen;
        private System.Windows.Forms.CheckBox chBoxUnpack;
        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.TextBox txtUnpackOpenPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFOGRepack;
        private System.Windows.Forms.Button btnFOGUnpackSave;
        private System.Windows.Forms.Button btnFOGRepackOpen;
        private System.Windows.Forms.TextBox txtFOGSaveRepack;
        private System.Windows.Forms.TextBox txtFOGRepackOpen;
        private System.Windows.Forms.CheckBox chBoxRepack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHOGUnpackOpen;
        private System.Windows.Forms.Button btnHOGUnpackOpen;
        private System.Windows.Forms.Button btnHOGUnpack;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtHOGRepackSave;
        private System.Windows.Forms.TextBox txtHOGRepackOpen;
        private System.Windows.Forms.Button btnHOGRepack;
        private System.Windows.Forms.Button btnHOGRepackSave;
        private System.Windows.Forms.Button btnHOGRepackOpen;
        private System.Windows.Forms.StatusStrip statStrip;
        private System.Windows.Forms.ToolStripStatusLabel ssLblStat;
        private System.Windows.Forms.ToolStripProgressBar ssPB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}