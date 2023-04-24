namespace proiect
{
    partial class CapturePackets
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
            this.Results = new System.Windows.Forms.ListBox();
            this.btClose = new System.Windows.Forms.Button();
            this.StopCapture = new System.Windows.Forms.Button();
            this.SaveToDisk = new System.Windows.Forms.Button();
            this.btResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.Location = new System.Drawing.Point(12, 12);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(653, 420);
            this.Results.TabIndex = 0;
            this.Results.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Results_MouseDoubleClick);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(671, 409);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Inchide";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // StopCapture
            // 
            this.StopCapture.Location = new System.Drawing.Point(672, 12);
            this.StopCapture.Name = "StopCapture";
            this.StopCapture.Size = new System.Drawing.Size(116, 23);
            this.StopCapture.TabIndex = 2;
            this.StopCapture.Text = "Opreste capturarea";
            this.StopCapture.UseVisualStyleBackColor = true;
            this.StopCapture.Click += new System.EventHandler(this.StopCapture_Click);
            // 
            // SaveToDisk
            // 
            this.SaveToDisk.Location = new System.Drawing.Point(672, 41);
            this.SaveToDisk.Name = "SaveToDisk";
            this.SaveToDisk.Size = new System.Drawing.Size(75, 23);
            this.SaveToDisk.TabIndex = 3;
            this.SaveToDisk.Text = "Salveaza";
            this.SaveToDisk.UseVisualStyleBackColor = true;
            this.SaveToDisk.Click += new System.EventHandler(this.SaveToDisk_Click);
            // 
            // btResume
            // 
            this.btResume.Location = new System.Drawing.Point(672, 70);
            this.btResume.Name = "btResume";
            this.btResume.Size = new System.Drawing.Size(75, 23);
            this.btResume.TabIndex = 4;
            this.btResume.Text = "Resume";
            this.btResume.UseVisualStyleBackColor = true;
            this.btResume.Click += new System.EventHandler(this.btResume_Click);
            // 
            // CapturePackets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btResume);
            this.Controls.Add(this.SaveToDisk);
            this.Controls.Add(this.StopCapture);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.Results);
            this.Name = "CapturePackets";
            this.Text = "CapturePackets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button StopCapture;
        private System.Windows.Forms.Button SaveToDisk;
        private System.Windows.Forms.Button btResume;
    }
}