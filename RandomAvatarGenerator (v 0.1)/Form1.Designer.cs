namespace RandomAvatarGenerator__v_0._1_
{
    partial class mainwindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usingRAGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSize3 = new System.Windows.Forms.Button();
            this.imageViewerPanel = new System.Windows.Forms.Panel();
            this.buttonSize5 = new System.Windows.Forms.Button();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.checkVertical = new System.Windows.Forms.CheckBox();
            this.checkHorizontal = new System.Windows.Forms.CheckBox();
            this.checkDiagonal = new System.Windows.Forms.CheckBox();
            this.buttonSize15 = new System.Windows.Forms.Button();
            this.buttonSize25 = new System.Windows.Forms.Button();
            this.buttonSize75 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.groupBoxMirror = new System.Windows.Forms.GroupBox();
            this.groupBoxGrid = new System.Windows.Forms.GroupBox();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonOff = new System.Windows.Forms.RadioButton();
            this.radioButtonOn = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxMirror.SuspendLayout();
            this.groupBoxGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usingRAGToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // usingRAGToolStripMenuItem
            // 
            this.usingRAGToolStripMenuItem.Enabled = false;
            this.usingRAGToolStripMenuItem.Name = "usingRAGToolStripMenuItem";
            this.usingRAGToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.usingRAGToolStripMenuItem.Text = "Using RAG";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Enabled = false;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // buttonSize3
            // 
            this.buttonSize3.Location = new System.Drawing.Point(332, 44);
            this.buttonSize3.Name = "buttonSize3";
            this.buttonSize3.Size = new System.Drawing.Size(55, 23);
            this.buttonSize3.TabIndex = 1;
            this.buttonSize3.Text = "3x3";
            this.buttonSize3.UseVisualStyleBackColor = true;
            this.buttonSize3.Click += new System.EventHandler(this.buttonSize3_Click);
            // 
            // imageViewerPanel
            // 
            this.imageViewerPanel.Location = new System.Drawing.Point(12, 27);
            this.imageViewerPanel.Name = "imageViewerPanel";
            this.imageViewerPanel.Size = new System.Drawing.Size(300, 300);
            this.imageViewerPanel.TabIndex = 2;
            this.imageViewerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.imageViewerPanel_Paint);
            // 
            // buttonSize5
            // 
            this.buttonSize5.Location = new System.Drawing.Point(393, 44);
            this.buttonSize5.Name = "buttonSize5";
            this.buttonSize5.Size = new System.Drawing.Size(55, 23);
            this.buttonSize5.TabIndex = 3;
            this.buttonSize5.Text = "5x5";
            this.buttonSize5.UseVisualStyleBackColor = true;
            this.buttonSize5.Click += new System.EventHandler(this.buttonSize5_Click);
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(12, 333);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomize.TabIndex = 4;
            this.buttonRandomize.Text = "Randomize";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // checkVertical
            // 
            this.checkVertical.AutoSize = true;
            this.checkVertical.Checked = true;
            this.checkVertical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkVertical.Location = new System.Drawing.Point(46, 19);
            this.checkVertical.Name = "checkVertical";
            this.checkVertical.Size = new System.Drawing.Size(61, 17);
            this.checkVertical.TabIndex = 5;
            this.checkVertical.Text = "Vertical";
            this.checkVertical.UseVisualStyleBackColor = true;
            this.checkVertical.CheckedChanged += new System.EventHandler(this.checkVertical_CheckedChanged);
            // 
            // checkHorizontal
            // 
            this.checkHorizontal.AutoSize = true;
            this.checkHorizontal.Location = new System.Drawing.Point(114, 19);
            this.checkHorizontal.Name = "checkHorizontal";
            this.checkHorizontal.Size = new System.Drawing.Size(73, 17);
            this.checkHorizontal.TabIndex = 6;
            this.checkHorizontal.Text = "Horizontal";
            this.checkHorizontal.UseVisualStyleBackColor = true;
            this.checkHorizontal.CheckedChanged += new System.EventHandler(this.checkHorizontal_CheckedChanged);
            // 
            // checkDiagonal
            // 
            this.checkDiagonal.AutoSize = true;
            this.checkDiagonal.Enabled = false;
            this.checkDiagonal.Location = new System.Drawing.Point(194, 19);
            this.checkDiagonal.Name = "checkDiagonal";
            this.checkDiagonal.Size = new System.Drawing.Size(68, 17);
            this.checkDiagonal.TabIndex = 7;
            this.checkDiagonal.Text = "Diagonal";
            this.checkDiagonal.UseVisualStyleBackColor = true;
            this.checkDiagonal.CheckedChanged += new System.EventHandler(this.checkDiagonal_CheckedChanged);
            // 
            // buttonSize15
            // 
            this.buttonSize15.Location = new System.Drawing.Point(454, 44);
            this.buttonSize15.Name = "buttonSize15";
            this.buttonSize15.Size = new System.Drawing.Size(55, 23);
            this.buttonSize15.TabIndex = 8;
            this.buttonSize15.Text = "15x15";
            this.buttonSize15.UseVisualStyleBackColor = true;
            this.buttonSize15.Click += new System.EventHandler(this.buttonSize15_Click);
            // 
            // buttonSize25
            // 
            this.buttonSize25.Location = new System.Drawing.Point(515, 44);
            this.buttonSize25.Name = "buttonSize25";
            this.buttonSize25.Size = new System.Drawing.Size(55, 23);
            this.buttonSize25.TabIndex = 9;
            this.buttonSize25.Text = "25x25";
            this.buttonSize25.UseVisualStyleBackColor = true;
            this.buttonSize25.Click += new System.EventHandler(this.buttonSize25_Click);
            // 
            // buttonSize75
            // 
            this.buttonSize75.Location = new System.Drawing.Point(576, 44);
            this.buttonSize75.Name = "buttonSize75";
            this.buttonSize75.Size = new System.Drawing.Size(55, 23);
            this.buttonSize75.TabIndex = 10;
            this.buttonSize75.Text = "75x75";
            this.buttonSize75.UseVisualStyleBackColor = true;
            this.buttonSize75.Click += new System.EventHandler(this.buttonSize75_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Grid size";
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(236, 333);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveImage.TabIndex = 13;
            this.buttonSaveImage.Text = "Save image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save avatar to image file";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(639, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBarLabel1
            // 
            this.statusBarLabel1.Name = "statusBarLabel1";
            this.statusBarLabel1.Size = new System.Drawing.Size(36, 17);
            this.statusBarLabel1.Text = "ready";
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(94, 333);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(75, 23);
            this.buttonRotate.TabIndex = 15;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // groupBoxMirror
            // 
            this.groupBoxMirror.Controls.Add(this.checkDiagonal);
            this.groupBoxMirror.Controls.Add(this.checkVertical);
            this.groupBoxMirror.Controls.Add(this.checkHorizontal);
            this.groupBoxMirror.Location = new System.Drawing.Point(322, 73);
            this.groupBoxMirror.Name = "groupBoxMirror";
            this.groupBoxMirror.Size = new System.Drawing.Size(309, 47);
            this.groupBoxMirror.TabIndex = 16;
            this.groupBoxMirror.TabStop = false;
            this.groupBoxMirror.Text = "Mirror";
            // 
            // groupBoxGrid
            // 
            this.groupBoxGrid.Controls.Add(this.radioButtonRandom);
            this.groupBoxGrid.Controls.Add(this.radioButtonOff);
            this.groupBoxGrid.Controls.Add(this.radioButtonOn);
            this.groupBoxGrid.Location = new System.Drawing.Point(322, 127);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Size = new System.Drawing.Size(309, 47);
            this.groupBoxGrid.TabIndex = 17;
            this.groupBoxGrid.TabStop = false;
            this.groupBoxGrid.Text = "Grid";
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Location = new System.Drawing.Point(136, 19);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(65, 17);
            this.radioButtonRandom.TabIndex = 2;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Random";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            this.radioButtonRandom.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.AutoSize = true;
            this.radioButtonOff.Location = new System.Drawing.Point(91, 19);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(39, 17);
            this.radioButtonOff.TabIndex = 1;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "Off";
            this.radioButtonOff.UseVisualStyleBackColor = true;
            this.radioButtonOff.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonOn
            // 
            this.radioButtonOn.AutoSize = true;
            this.radioButtonOn.Checked = true;
            this.radioButtonOn.Location = new System.Drawing.Point(46, 19);
            this.radioButtonOn.Name = "radioButtonOn";
            this.radioButtonOn.Size = new System.Drawing.Size(39, 17);
            this.radioButtonOn.TabIndex = 0;
            this.radioButtonOn.TabStop = true;
            this.radioButtonOn.Text = "On";
            this.radioButtonOn.UseVisualStyleBackColor = true;
            this.radioButtonOn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 392);
            this.Controls.Add(this.groupBoxGrid);
            this.Controls.Add(this.groupBoxMirror);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSize75);
            this.Controls.Add(this.buttonSize25);
            this.Controls.Add(this.buttonSize15);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.buttonSize5);
            this.Controls.Add(this.imageViewerPanel);
            this.Controls.Add(this.buttonSize3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainwindow";
            this.Text = "Random avatar generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxMirror.ResumeLayout(false);
            this.groupBoxMirror.PerformLayout();
            this.groupBoxGrid.ResumeLayout(false);
            this.groupBoxGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usingRAGToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button buttonSize3;
        private System.Windows.Forms.Panel imageViewerPanel;
        private System.Windows.Forms.Button buttonSize5;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.CheckBox checkVertical;
        private System.Windows.Forms.CheckBox checkHorizontal;
        private System.Windows.Forms.CheckBox checkDiagonal;
        private System.Windows.Forms.Button buttonSize15;
        private System.Windows.Forms.Button buttonSize25;
        private System.Windows.Forms.Button buttonSize75;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel1;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.GroupBox groupBoxMirror;
        private System.Windows.Forms.GroupBox groupBoxGrid;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.RadioButton radioButtonOn;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

