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
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}