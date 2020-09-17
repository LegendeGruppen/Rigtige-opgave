namespace Webcam_AForge_Edition
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
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.comboBoxCameraList = new System.Windows.Forms.ComboBox();
            this.buttonCamStart = new System.Windows.Forms.Button();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.buttonGray = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStop = new System.Windows.Forms.Button();
            this.Red_scale = new System.Windows.Forms.Button();
            this.Blue_scale = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgVideo
            // 
            this.imgVideo.Location = new System.Drawing.Point(12, 39);
            this.imgVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(483, 299);
            this.imgVideo.TabIndex = 0;
            this.imgVideo.TabStop = false;
            // 
            // buttonCapture
            // 
            this.buttonCapture.BackColor = System.Drawing.Color.Red;
            this.buttonCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapture.ForeColor = System.Drawing.Color.White;
            this.buttonCapture.Location = new System.Drawing.Point(12, 343);
            this.buttonCapture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(487, 55);
            this.buttonCapture.TabIndex = 1;
            this.buttonCapture.Text = "Capture";
            this.buttonCapture.UseVisualStyleBackColor = false;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // comboBoxCameraList
            // 
            this.comboBoxCameraList.FormattingEnabled = true;
            this.comboBoxCameraList.Location = new System.Drawing.Point(15, 508);
            this.comboBoxCameraList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCameraList.Name = "comboBoxCameraList";
            this.comboBoxCameraList.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCameraList.TabIndex = 2;
            // 
            // buttonCamStart
            // 
            this.buttonCamStart.Location = new System.Drawing.Point(147, 505);
            this.buttonCamStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCamStart.Name = "buttonCamStart";
            this.buttonCamStart.Size = new System.Drawing.Size(99, 29);
            this.buttonCamStart.TabIndex = 3;
            this.buttonCamStart.Text = "Start";
            this.buttonCamStart.UseVisualStyleBackColor = true;
            this.buttonCamStart.Click += new System.EventHandler(this.buttonCamStart_Click);
            // 
            // imgCapture
            // 
            this.imgCapture.Location = new System.Drawing.Point(500, 39);
            this.imgCapture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(477, 299);
            this.imgCapture.TabIndex = 4;
            this.imgCapture.TabStop = false;
            // 
            // buttonGray
            // 
            this.buttonGray.Location = new System.Drawing.Point(562, 503);
            this.buttonGray.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonGray.Size = new System.Drawing.Size(99, 29);
            this.buttonGray.TabIndex = 8;
            this.buttonGray.Text = "Gray scale";
            this.buttonGray.UseVisualStyleBackColor = true;
            this.buttonGray.Click += new System.EventHandler(this.buttonGrayscale_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.resolutionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // resolutionToolStripMenuItem
            // 
            this.resolutionToolStripMenuItem.Name = "resolutionToolStripMenuItem";
            this.resolutionToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.resolutionToolStripMenuItem.Text = "&Resolution";
            this.resolutionToolStripMenuItem.Click += new System.EventHandler(this.resolutionToolStripMenuItem_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(252, 505);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(99, 29);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Red_scale
            // 
            this.Red_scale.Location = new System.Drawing.Point(668, 503);
            this.Red_scale.Name = "Red_scale";
            this.Red_scale.Size = new System.Drawing.Size(99, 29);
            this.Red_scale.TabIndex = 12;
            this.Red_scale.Text = "Red ";
            this.Red_scale.UseVisualStyleBackColor = true;
            this.Red_scale.Click += new System.EventHandler(this.Red_scale_Click);
            // 
            // Blue_scale
            // 
            this.Blue_scale.Location = new System.Drawing.Point(878, 503);
            this.Blue_scale.Name = "Blue_scale";
            this.Blue_scale.Size = new System.Drawing.Size(99, 29);
            this.Blue_scale.TabIndex = 14;
            this.Blue_scale.Text = "Blue";
            this.Blue_scale.UseVisualStyleBackColor = true;
            this.Blue_scale.Click += new System.EventHandler(this.Blue_scale_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Green";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Green_scale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 548);
            this.Controls.Add(this.Blue_scale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Red_scale);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonGray);
            this.Controls.Add(this.imgCapture);
            this.Controls.Add(this.buttonCamStart);
            this.Controls.Add(this.comboBoxCameraList);
            this.Controls.Add(this.buttonCapture);
            this.Controls.Add(this.imgVideo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "WebCam Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.ComboBox comboBoxCameraList;
        private System.Windows.Forms.Button buttonCamStart;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.Button buttonGray;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resolutionToolStripMenuItem;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button Red_scale;
        private System.Windows.Forms.Button Blue_scale;
        private System.Windows.Forms.Button button1;
    }
}

