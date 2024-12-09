namespace Kostki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.resultLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.resultLabel.Location = new System.Drawing.Point(300, 71);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(188, 29);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Aktualny Wynik";
            this.resultLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.playAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.playAgainButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playAgainButton.Location = new System.Drawing.Point(286, 330);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(232, 44);
            this.playAgainButton.TabIndex = 3;
            this.playAgainButton.Text = "Zagraj jeszcze raz";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.resultLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Gra w kosci";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.ListBox resultList;
    }
}