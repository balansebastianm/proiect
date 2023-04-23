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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blocksite_btn
            // 
            this.blocksite_btn.Location = new System.Drawing.Point(37, 181);
            this.blocksite_btn.Margin = new System.Windows.Forms.Padding(4);
            this.blocksite_btn.Name = "blocksite_btn";
            this.blocksite_btn.Size = new System.Drawing.Size(147, 28);
            this.blocksite_btn.TabIndex = 0;
            this.blocksite_btn.Text = "Blocare Site";
            this.blocksite_btn.UseVisualStyleBackColor = true;
            this.blocksite_btn.Click += new System.EventHandler(this.blocksite_btn_Click);
            // 
            // deblocaresite_btn
            // 
            this.deblocaresite_btn.Location = new System.Drawing.Point(224, 181);
            this.deblocaresite_btn.Margin = new System.Windows.Forms.Padding(4);
            this.deblocaresite_btn.Name = "deblocaresite_btn";
            this.deblocaresite_btn.Size = new System.Drawing.Size(137, 28);
            this.deblocaresite_btn.TabIndex = 1;
            this.deblocaresite_btn.Text = "Deblocare Site";
            this.deblocaresite_btn.UseVisualStyleBackColor = true;
            this.deblocaresite_btn.Click += new System.EventHandler(this.deblocaresite_btn_Click);
            // 
            // siteTBox
            // 
            this.siteTBox.Location = new System.Drawing.Point(37, 65);
            this.siteTBox.Margin = new System.Windows.Forms.Padding(4);
            this.siteTBox.Name = "siteTBox";
            this.siteTBox.Size = new System.Drawing.Size(323, 22);
            this.siteTBox.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(434, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(591, 260);
            this.listBox1.TabIndex = 4;
            
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.siteTBox);
            this.Controls.Add(this.deblocaresite_btn);
            this.Controls.Add(this.blocksite_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button1;
    }
}