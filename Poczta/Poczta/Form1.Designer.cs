namespace Poczta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.posterRadioBtn = new System.Windows.Forms.RadioButton();
            this.letterRadioBtn = new System.Windows.Forms.RadioButton();
            this.boxRadioBtn = new System.Windows.Forms.RadioButton();
            this.checkPriceBtn = new System.Windows.Forms.Button();
            this.cena = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.postCodeTextBox = new System.Windows.Forms.Label();
            this.postCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxRadioBtn);
            this.groupBox1.Controls.Add(this.letterRadioBtn);
            this.groupBox1.Controls.Add(this.posterRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(80, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rodzaj przesyłki";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // posterRadioBtn
            // 
            this.posterRadioBtn.AutoSize = true;
            this.posterRadioBtn.Location = new System.Drawing.Point(24, 19);
            this.posterRadioBtn.Name = "posterRadioBtn";
            this.posterRadioBtn.Size = new System.Drawing.Size(78, 17);
            this.posterRadioBtn.TabIndex = 0;
            this.posterRadioBtn.TabStop = true;
            this.posterRadioBtn.Text = "Pocztówka";
            this.posterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // letterRadioBtn
            // 
            this.letterRadioBtn.AutoSize = true;
            this.letterRadioBtn.Location = new System.Drawing.Point(24, 42);
            this.letterRadioBtn.Name = "letterRadioBtn";
            this.letterRadioBtn.Size = new System.Drawing.Size(41, 17);
            this.letterRadioBtn.TabIndex = 1;
            this.letterRadioBtn.TabStop = true;
            this.letterRadioBtn.Text = "List";
            this.letterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // boxRadioBtn
            // 
            this.boxRadioBtn.AutoSize = true;
            this.boxRadioBtn.Location = new System.Drawing.Point(24, 65);
            this.boxRadioBtn.Name = "boxRadioBtn";
            this.boxRadioBtn.Size = new System.Drawing.Size(61, 17);
            this.boxRadioBtn.TabIndex = 2;
            this.boxRadioBtn.TabStop = true;
            this.boxRadioBtn.Text = "Paczka";
            this.boxRadioBtn.UseVisualStyleBackColor = true;
            // 
            // checkPriceBtn
            // 
            this.checkPriceBtn.Location = new System.Drawing.Point(80, 177);
            this.checkPriceBtn.Name = "checkPriceBtn";
            this.checkPriceBtn.Size = new System.Drawing.Size(164, 23);
            this.checkPriceBtn.TabIndex = 3;
            this.checkPriceBtn.Text = "Sprawdź cene";
            this.checkPriceBtn.UseVisualStyleBackColor = true;
            this.checkPriceBtn.Click += new System.EventHandler(this.checkPriceBtn_Click);
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Location = new System.Drawing.Point(276, 215);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(0, 13);
            this.cena.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cityTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.postCode);
            this.groupBox2.Controls.Add(this.postCodeTextBox);
            this.groupBox2.Controls.Add(this.streetTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(408, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 184);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane z adresu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ulica z numerem";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(18, 45);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(263, 20);
            this.streetTextBox.TabIndex = 1;
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.AutoSize = true;
            this.postCodeTextBox.Location = new System.Drawing.Point(15, 68);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(74, 13);
            this.postCodeTextBox.TabIndex = 2;
            this.postCodeTextBox.Text = "Kod pocztowy";
            // 
            // postCode
            // 
            this.postCode.Location = new System.Drawing.Point(18, 87);
            this.postCode.Name = "postCode";
            this.postCode.Size = new System.Drawing.Size(263, 20);
            this.postCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Miasto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(18, 129);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(263, 20);
            this.cityTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(479, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.checkPriceBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Nadaj przesyłke";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton boxRadioBtn;
        private System.Windows.Forms.RadioButton letterRadioBtn;
        private System.Windows.Forms.RadioButton posterRadioBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button checkPriceBtn;
        private System.Windows.Forms.Label cena;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox postCode;
        private System.Windows.Forms.Label postCodeTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button button1;
    }
}

