namespace gra_w_kosci_v2
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
            this.label1 = new System.Windows.Forms.Label();
            this.playerDiceSum2Label = new System.Windows.Forms.Label();
            this.playerDiceSum = new System.Windows.Forms.Label();
            this.throwDiceButton = new System.Windows.Forms.Button();
            this.diceBox5 = new System.Windows.Forms.PictureBox();
            this.diceBox4 = new System.Windows.Forms.PictureBox();
            this.diceBox3 = new System.Windows.Forms.PictureBox();
            this.diceBox2 = new System.Windows.Forms.PictureBox();
            this.diceBox1 = new System.Windows.Forms.PictureBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(277, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "WITAJ W GRZE W KOSCI";
            // 
            // playerDiceSum2Label
            // 
            this.playerDiceSum2Label.AutoSize = true;
            this.playerDiceSum2Label.Location = new System.Drawing.Point(367, 317);
            this.playerDiceSum2Label.Name = "playerDiceSum2Label";
            this.playerDiceSum2Label.Size = new System.Drawing.Size(81, 13);
            this.playerDiceSum2Label.TabIndex = 18;
            this.playerDiceSum2Label.Text = "Wynik gracza 2";
            // 
            // playerDiceSum
            // 
            this.playerDiceSum.AutoSize = true;
            this.playerDiceSum.Location = new System.Drawing.Point(367, 292);
            this.playerDiceSum.Name = "playerDiceSum";
            this.playerDiceSum.Size = new System.Drawing.Size(81, 13);
            this.playerDiceSum.TabIndex = 17;
            this.playerDiceSum.Text = "Wynik gracza 1";
            // 
            // throwDiceButton
            // 
            this.throwDiceButton.BackColor = System.Drawing.Color.Black;
            this.throwDiceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.throwDiceButton.Location = new System.Drawing.Point(360, 344);
            this.throwDiceButton.Name = "throwDiceButton";
            this.throwDiceButton.Size = new System.Drawing.Size(88, 30);
            this.throwDiceButton.TabIndex = 16;
            this.throwDiceButton.Text = "Rzuć kostką";
            this.throwDiceButton.UseVisualStyleBackColor = false;
            this.throwDiceButton.Click += new System.EventHandler(this.throwDiceButton_Click);
            // 
            // diceBox5
            // 
            this.diceBox5.BackColor = System.Drawing.Color.Black;
            this.diceBox5.Location = new System.Drawing.Point(625, 179);
            this.diceBox5.Name = "diceBox5";
            this.diceBox5.Size = new System.Drawing.Size(100, 50);
            this.diceBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceBox5.TabIndex = 15;
            this.diceBox5.TabStop = false;
            // 
            // diceBox4
            // 
            this.diceBox4.BackColor = System.Drawing.Color.Black;
            this.diceBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.diceBox4.Location = new System.Drawing.Point(486, 179);
            this.diceBox4.Name = "diceBox4";
            this.diceBox4.Size = new System.Drawing.Size(100, 50);
            this.diceBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceBox4.TabIndex = 14;
            this.diceBox4.TabStop = false;
            // 
            // diceBox3
            // 
            this.diceBox3.BackColor = System.Drawing.Color.Black;
            this.diceBox3.Location = new System.Drawing.Point(358, 179);
            this.diceBox3.Name = "diceBox3";
            this.diceBox3.Size = new System.Drawing.Size(100, 50);
            this.diceBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceBox3.TabIndex = 13;
            this.diceBox3.TabStop = false;
            // 
            // diceBox2
            // 
            this.diceBox2.BackColor = System.Drawing.Color.Black;
            this.diceBox2.Location = new System.Drawing.Point(218, 179);
            this.diceBox2.Name = "diceBox2";
            this.diceBox2.Size = new System.Drawing.Size(100, 50);
            this.diceBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceBox2.TabIndex = 12;
            this.diceBox2.TabStop = false;
            // 
            // diceBox1
            // 
            this.diceBox1.BackColor = System.Drawing.Color.Black;
            this.diceBox1.Location = new System.Drawing.Point(75, 179);
            this.diceBox1.Name = "diceBox1";
            this.diceBox1.Size = new System.Drawing.Size(100, 50);
            this.diceBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceBox1.TabIndex = 11;
            this.diceBox1.TabStop = false;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(367, 133);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(76, 13);
            this.playerNameLabel.TabIndex = 10;
            this.playerNameLabel.Text = "Gracz numer 1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerDiceSum2Label);
            this.Controls.Add(this.playerDiceSum);
            this.Controls.Add(this.throwDiceButton);
            this.Controls.Add(this.diceBox5);
            this.Controls.Add(this.diceBox4);
            this.Controls.Add(this.diceBox3);
            this.Controls.Add(this.diceBox2);
            this.Controls.Add(this.diceBox1);
            this.Controls.Add(this.playerNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Gra wkosci";
            ((System.ComponentModel.ISupportInitialize)(this.diceBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerDiceSum2Label;
        private System.Windows.Forms.Label playerDiceSum;
        private System.Windows.Forms.Button throwDiceButton;
        private System.Windows.Forms.PictureBox diceBox5;
        private System.Windows.Forms.PictureBox diceBox4;
        private System.Windows.Forms.PictureBox diceBox3;
        private System.Windows.Forms.PictureBox diceBox2;
        private System.Windows.Forms.PictureBox diceBox1;
        private System.Windows.Forms.Label playerNameLabel;
    }
}