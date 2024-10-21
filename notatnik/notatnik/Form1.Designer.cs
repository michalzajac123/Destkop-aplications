namespace notatnik
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.createNewFileButton = new System.Windows.Forms.Button();
            this.pathToFileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 423);
            this.textBox1.TabIndex = 0;
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(594, 78);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(163, 43);
            this.saveAsButton.TabIndex = 1;
            this.saveAsButton.Text = "Zapisz jako";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(594, 127);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(163, 43);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Otwórz";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(594, 176);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(163, 43);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(594, 29);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(163, 43);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ścieżka";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(665, 260);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(0, 13);
            this.pathLabel.TabIndex = 6;
            // 
            // createNewFileButton
            // 
            this.createNewFileButton.Location = new System.Drawing.Point(594, 230);
            this.createNewFileButton.Name = "createNewFileButton";
            this.createNewFileButton.Size = new System.Drawing.Size(163, 43);
            this.createNewFileButton.TabIndex = 7;
            this.createNewFileButton.Text = "Stworz nowy";
            this.createNewFileButton.UseVisualStyleBackColor = true;
            this.createNewFileButton.Click += new System.EventHandler(this.createNewFileButton_Click);
            // 
            // pathToFileLabel
            // 
            this.pathToFileLabel.AutoSize = true;
            this.pathToFileLabel.Location = new System.Drawing.Point(126, 9);
            this.pathToFileLabel.Name = "pathToFileLabel";
            this.pathToFileLabel.Size = new System.Drawing.Size(159, 13);
            this.pathToFileLabel.TabIndex = 8;
            this.pathToFileLabel.Text = "Tutaj pojawi sie sciezka do pliku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pathToFileLabel);
            this.Controls.Add(this.createNewFileButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button createNewFileButton;
        private System.Windows.Forms.Label pathToFileLabel;
    }
}

