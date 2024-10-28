namespace Zamowienie
{
    partial class Form2
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(226, 89);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "label1";
            // 
            // surnNameLabel
            // 
            this.surnNameLabel.AutoSize = true;
            this.surnNameLabel.Location = new System.Drawing.Point(226, 130);
            this.surnNameLabel.Name = "surnNameLabel";
            this.surnNameLabel.Size = new System.Drawing.Size(35, 13);
            this.surnNameLabel.TabIndex = 1;
            this.surnNameLabel.Text = "label2";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(226, 166);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(35, 13);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "label3";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(226, 205);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(35, 13);
            this.productLabel.TabIndex = 3;
            this.productLabel.Text = "label4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.surnNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label productLabel;
    }
}