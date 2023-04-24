namespace proiect
{
    partial class FormPrincipal
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
            this.blocksite_btn = new System.Windows.Forms.Button();
            this.deblocaresite_btn = new System.Windows.Forms.Button();
            this.siteTBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Capturepkt = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blocksite_btn
            // 
            this.blocksite_btn.Location = new System.Drawing.Point(28, 147);
            this.blocksite_btn.Name = "blocksite_btn";
            this.blocksite_btn.Size = new System.Drawing.Size(110, 23);
            this.blocksite_btn.TabIndex = 0;
            this.blocksite_btn.Text = "Blocare Site";
            this.blocksite_btn.UseVisualStyleBackColor = true;
            this.blocksite_btn.Click += new System.EventHandler(this.blocksite_btn_Click);
            // 
            // deblocaresite_btn
            // 
            this.deblocaresite_btn.Location = new System.Drawing.Point(168, 147);
            this.deblocaresite_btn.Name = "deblocaresite_btn";
            this.deblocaresite_btn.Size = new System.Drawing.Size(103, 23);
            this.deblocaresite_btn.TabIndex = 1;
            this.deblocaresite_btn.Text = "Deblocare Site";
            this.deblocaresite_btn.UseVisualStyleBackColor = true;
            this.deblocaresite_btn.Click += new System.EventHandler(this.deblocaresite_btn_Click);
            // 
            // siteTBox
            // 
            this.siteTBox.Location = new System.Drawing.Point(28, 53);
            this.siteTBox.Name = "siteTBox";
            this.siteTBox.Size = new System.Drawing.Size(243, 20);
            this.siteTBox.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(326, 48);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(444, 212);
            this.listBox1.TabIndex = 4;
            // 
            // Capturepkt
            // 
            this.Capturepkt.Location = new System.Drawing.Point(28, 191);
            this.Capturepkt.Margin = new System.Windows.Forms.Padding(2);
            this.Capturepkt.Name = "Capturepkt";
            this.Capturepkt.Size = new System.Drawing.Size(152, 28);
            this.Capturepkt.TabIndex = 0;
            this.Capturepkt.Text = "Captureaza pachete";
            this.Capturepkt.Click += new System.EventHandler(this.CapturePackets_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(695, 278);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Inchide";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.Capturepkt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.siteTBox);
            this.Controls.Add(this.deblocaresite_btn);
            this.Controls.Add(this.blocksite_btn);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button blocksite_btn;
        private System.Windows.Forms.Button deblocaresite_btn;
        private System.Windows.Forms.TextBox siteTBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Capturepkt;
        private System.Windows.Forms.Button btClose;
    }
}