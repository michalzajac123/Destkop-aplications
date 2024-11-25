namespace Gra_w_kosci
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
            this.diceBox1 = new System.Windows.Forms.PictureBox();
            this.diceBox2 = new System.Windows.Forms.PictureBox();
            this.diceLabel1 = new System.Windows.Forms.Label();
            this.diceLabel2 = new System.Windows.Forms.Label();
            this.diceTotal = new System.Windows.Forms.Label();
            this.diceSum = new System.Windows.Forms.Label();
            this.throwDicesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // diceBox1
            // 
            this.diceBox1.Location = new System.Drawing.Point(206, 114);
            this.diceBox1.Name = "diceBox1";
            this.diceBox1.Size = new System.Drawing.Size(100, 50);
            this.diceBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceBox1.TabIndex = 0;
            this.diceBox1.TabStop = false;
            // 
            // diceBox2
            // 
            this.diceBox2.Location = new System.Drawing.Point(373, 114);
            this.diceBox2.Name = "diceBox2";
            this.diceBox2.Size = new System.Drawing.Size(100, 50);
            this.diceBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceBox2.TabIndex = 1;
            this.diceBox2.TabStop = false;
            // 
            // diceLabel1
            // 
            this.diceLabel1.AutoSize = true;
            this.diceLabel1.Location = new System.Drawing.Point(203, 182);
            this.diceLabel1.Name = "diceLabel1";
            this.diceLabel1.Size = new System.Drawing.Size(35, 13);
            this.diceLabel1.TabIndex = 2;
            this.diceLabel1.Text = "label1";
            // 
            // diceLabel2
            // 
            this.diceLabel2.AutoSize = true;
            this.diceLabel2.Location = new System.Drawing.Point(370, 182);
            this.diceLabel2.Name = "diceLabel2";
            this.diceLabel2.Size = new System.Drawing.Size(35, 13);
            this.diceLabel2.TabIndex = 3;
            this.diceLabel2.Text = "label2";
            // 
            // diceTotal
            // 
            this.diceTotal.AutoSize = true;
            this.diceTotal.Location = new System.Drawing.Point(678, 114);
            this.diceTotal.Name = "diceTotal";
            this.diceTotal.Size = new System.Drawing.Size(35, 13);
            this.diceTotal.TabIndex = 4;
            this.diceTotal.Text = "label3";
            // 
            // diceSum
            // 
            this.diceSum.AutoSize = true;
            this.diceSum.Location = new System.Drawing.Point(678, 165);
            this.diceSum.Name = "diceSum";
            this.diceSum.Size = new System.Drawing.Size(35, 13);
            this.diceSum.TabIndex = 5;
            this.diceSum.Text = "label4";
            // 
            // throwDicesButton
            // 
            this.throwDicesButton.Location = new System.Drawing.Point(206, 275);
            this.throwDicesButton.Name = "throwDicesButton";
            this.throwDicesButton.Size = new System.Drawing.Size(100, 39);
            this.throwDicesButton.TabIndex = 6;
            this.throwDicesButton.Text = "Rzuć kościami";
            this.throwDicesButton.UseVisualStyleBackColor = true;
            this.throwDicesButton.Click += new System.EventHandler(this.throw_Dice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.throwDicesButton);
            this.Controls.Add(this.diceSum);
            this.Controls.Add(this.diceTotal);
            this.Controls.Add(this.diceLabel2);
            this.Controls.Add(this.diceLabel1);
            this.Controls.Add(this.diceBox2);
            this.Controls.Add(this.diceBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox diceBox1;
        private System.Windows.Forms.PictureBox diceBox2;
        private System.Windows.Forms.Label diceLabel1;
        private System.Windows.Forms.Label diceLabel2;
        private System.Windows.Forms.Label diceTotal;
        private System.Windows.Forms.Label diceSum;
        private System.Windows.Forms.Button throwDicesButton;
    }
}

