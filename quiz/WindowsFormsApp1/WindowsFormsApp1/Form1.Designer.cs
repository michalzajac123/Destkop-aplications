namespace WindowsFormsApp1
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.Odpowiedzi = new System.Windows.Forms.GroupBox();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.Button();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.correctAnswerLabel = new System.Windows.Forms.Label();
            this.pointCounterLabel = new System.Windows.Forms.Label();
            this.Odpowiedzi.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(47, 79);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(84, 25);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Pytanie";
            // 
            // Odpowiedzi
            // 
            this.Odpowiedzi.Controls.Add(this.radioButtonD);
            this.Odpowiedzi.Controls.Add(this.radioButtonC);
            this.Odpowiedzi.Controls.Add(this.radioButtonB);
            this.Odpowiedzi.Controls.Add(this.radioButtonA);
            this.Odpowiedzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odpowiedzi.Location = new System.Drawing.Point(50, 120);
            this.Odpowiedzi.Name = "Odpowiedzi";
            this.Odpowiedzi.Size = new System.Drawing.Size(200, 128);
            this.Odpowiedzi.TabIndex = 1;
            this.Odpowiedzi.TabStop = false;
            this.Odpowiedzi.Text = "odpowiedzi";
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(20, 19);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(67, 22);
            this.radioButtonA.TabIndex = 0;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "Odp A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(20, 42);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(68, 22);
            this.radioButtonB.TabIndex = 1;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "Odp B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(20, 65);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(69, 22);
            this.radioButtonC.TabIndex = 2;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "Odp C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(20, 88);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(69, 22);
            this.radioButtonD.TabIndex = 3;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "Odp D";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkButton.Location = new System.Drawing.Point(84, 263);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(109, 41);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Sprawdz";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.nextQuestionButton.Enabled = false;
            this.nextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextQuestionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextQuestionButton.Location = new System.Drawing.Point(594, 67);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(213, 37);
            this.nextQuestionButton.TabIndex = 3;
            this.nextQuestionButton.Text = "Następne pytanie";
            this.nextQuestionButton.UseVisualStyleBackColor = false;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // correctAnswerLabel
            // 
            this.correctAnswerLabel.AutoSize = true;
            this.correctAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.correctAnswerLabel.Location = new System.Drawing.Point(268, 132);
            this.correctAnswerLabel.Name = "correctAnswerLabel";
            this.correctAnswerLabel.Size = new System.Drawing.Size(247, 29);
            this.correctAnswerLabel.TabIndex = 4;
            this.correctAnswerLabel.Text = "Poprawna odpowiedz";
            // 
            // pointCounterLabel
            // 
            this.pointCounterLabel.AutoSize = true;
            this.pointCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointCounterLabel.Location = new System.Drawing.Point(45, 344);
            this.pointCounterLabel.Name = "pointCounterLabel";
            this.pointCounterLabel.Size = new System.Drawing.Size(203, 29);
            this.pointCounterLabel.TabIndex = 5;
            this.pointCounterLabel.Text = "Liczba puntków: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.pointCounterLabel);
            this.Controls.Add(this.correctAnswerLabel);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.Odpowiedzi);
            this.Controls.Add(this.questionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Odpowiedzi.ResumeLayout(false);
            this.Odpowiedzi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.GroupBox Odpowiedzi;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Label correctAnswerLabel;
        private System.Windows.Forms.Label pointCounterLabel;
    }
}

