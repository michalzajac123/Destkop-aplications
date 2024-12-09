namespace Kostki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DicePictureBox1 = new System.Windows.Forms.PictureBox();
            this.DicePictureBox2 = new System.Windows.Forms.PictureBox();
            this.throwDiceButton = new System.Windows.Forms.Button();
            this.showResultButton = new System.Windows.Forms.Button();
            this.dice1Label = new System.Windows.Forms.Label();
            this.dice2Label = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmNameButton = new System.Windows.Forms.Button();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DicePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DicePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DicePictureBox1
            // 
            this.DicePictureBox1.Location = new System.Drawing.Point(165, 78);
            this.DicePictureBox1.Name = "DicePictureBox1";
            this.DicePictureBox1.Size = new System.Drawing.Size(160, 132);
            this.DicePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DicePictureBox1.TabIndex = 0;
            this.DicePictureBox1.TabStop = false;
            this.DicePictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DicePictureBox2
            // 
            this.DicePictureBox2.Location = new System.Drawing.Point(477, 78);
            this.DicePictureBox2.Name = "DicePictureBox2";
            this.DicePictureBox2.Size = new System.Drawing.Size(159, 132);
            this.DicePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DicePictureBox2.TabIndex = 1;
            this.DicePictureBox2.TabStop = false;
            // 
            // throwDiceButton
            // 
            this.throwDiceButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.throwDiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.throwDiceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.throwDiceButton.Location = new System.Drawing.Point(165, 285);
            this.throwDiceButton.Name = "throwDiceButton";
            this.throwDiceButton.Size = new System.Drawing.Size(180, 44);
            this.throwDiceButton.TabIndex = 2;
            this.throwDiceButton.Text = "Rzuć Kostką";
            this.throwDiceButton.UseVisualStyleBackColor = false;
            this.throwDiceButton.Click += new System.EventHandler(this.throwDiceButton_Click);
            // 
            // showResultButton
            // 
            this.showResultButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.showResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.showResultButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showResultButton.Location = new System.Drawing.Point(165, 347);
            this.showResultButton.Name = "showResultButton";
            this.showResultButton.Size = new System.Drawing.Size(180, 44);
            this.showResultButton.TabIndex = 3;
            this.showResultButton.Text = "Pokaż wyniki";
            this.showResultButton.UseVisualStyleBackColor = false;
            this.showResultButton.Click += new System.EventHandler(this.showResultButton_Click);
            // 
            // dice1Label
            // 
            this.dice1Label.AutoSize = true;
            this.dice1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.dice1Label.Location = new System.Drawing.Point(200, 213);
            this.dice1Label.Name = "dice1Label";
            this.dice1Label.Size = new System.Drawing.Size(72, 26);
            this.dice1Label.TabIndex = 4;
            this.dice1Label.Text = "Wynik";
            // 
            // dice2Label
            // 
            this.dice2Label.AutoSize = true;
            this.dice2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.dice2Label.Location = new System.Drawing.Point(517, 213);
            this.dice2Label.Name = "dice2Label";
            this.dice2Label.Size = new System.Drawing.Size(72, 26);
            this.dice2Label.TabIndex = 5;
            this.dice2Label.Text = "Wynik";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.nameTextBox.Location = new System.Drawing.Point(505, 296);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(149, 25);
            this.nameTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(387, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Podaj Imie";
            // 
            // confirmNameButton
            // 
            this.confirmNameButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.confirmNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.confirmNameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmNameButton.Location = new System.Drawing.Point(660, 296);
            this.confirmNameButton.Name = "confirmNameButton";
            this.confirmNameButton.Size = new System.Drawing.Size(109, 25);
            this.confirmNameButton.TabIndex = 8;
            this.confirmNameButton.Text = "Zatwierdz";
            this.confirmNameButton.UseVisualStyleBackColor = false;
            this.confirmNameButton.Click += new System.EventHandler(this.confirmNameButton_Click);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.playerNameLabel.Location = new System.Drawing.Point(354, 27);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(0, 20);
            this.playerNameLabel.TabIndex = 9;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.editButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editButton.Location = new System.Drawing.Point(660, 327);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(109, 25);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Edytuj";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // resultsListBox
            // 
            this.resultsListBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.resultsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.resultsListBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 17;
            this.resultsListBox.Location = new System.Drawing.Point(341, 94);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(120, 89);
            this.resultsListBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.confirmNameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dice2Label);
            this.Controls.Add(this.dice1Label);
            this.Controls.Add(this.showResultButton);
            this.Controls.Add(this.throwDiceButton);
            this.Controls.Add(this.DicePictureBox2);
            this.Controls.Add(this.DicePictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gra w kosci";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DicePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DicePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DicePictureBox1;
        private System.Windows.Forms.PictureBox DicePictureBox2;
        private System.Windows.Forms.Button throwDiceButton;
        private System.Windows.Forms.Button showResultButton;
        private System.Windows.Forms.Label dice1Label;
        private System.Windows.Forms.Label dice2Label;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmNameButton;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ListBox resultsListBox;
    }
}

