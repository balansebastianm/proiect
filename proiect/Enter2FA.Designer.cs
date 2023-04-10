namespace proiect
{
    partial class Enter2FA
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb2FA = new System.Windows.Forms.TextBox();
            this.btSend2FA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti codul trimis pe adresa de email";
            // 
            // tb2FA
            // 
            this.tb2FA.Location = new System.Drawing.Point(16, 62);
            this.tb2FA.Name = "tb2FA";
            this.tb2FA.Size = new System.Drawing.Size(201, 20);
            this.tb2FA.TabIndex = 1;
            // 
            // btSend2FA
            // 
            this.btSend2FA.Location = new System.Drawing.Point(73, 100);
            this.btSend2FA.Name = "btSend2FA";
            this.btSend2FA.Size = new System.Drawing.Size(75, 23);
            this.btSend2FA.TabIndex = 2;
            this.btSend2FA.Text = "Trimite";
            this.btSend2FA.UseVisualStyleBackColor = true;
            this.btSend2FA.Click += new System.EventHandler(this.btSend2FA_Click);
            // 
            // Enter2FA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 154);
            this.Controls.Add(this.btSend2FA);
            this.Controls.Add(this.tb2FA);
            this.Controls.Add(this.label1);
            this.Name = "Enter2FA";
            this.Text = "Introduceti Codul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb2FA;
        private System.Windows.Forms.Button btSend2FA;
    }
}

