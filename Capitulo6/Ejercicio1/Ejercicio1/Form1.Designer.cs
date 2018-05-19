namespace Ejercicio1
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
            this.PalabratextBox = new System.Windows.Forms.TextBox();
            this.RegresaPalabraLabel1 = new System.Windows.Forms.Label();
            this.PrecionarClickButton = new System.Windows.Forms.Button();
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.DigiteNumeroLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PalabratextBox
            // 
            this.PalabratextBox.Location = new System.Drawing.Point(12, 86);
            this.PalabratextBox.Name = "PalabratextBox";
            this.PalabratextBox.Size = new System.Drawing.Size(205, 20);
            this.PalabratextBox.TabIndex = 14;
            // 
            // RegresaPalabraLabel1
            // 
            this.RegresaPalabraLabel1.AutoSize = true;
            this.RegresaPalabraLabel1.Location = new System.Drawing.Point(12, 69);
            this.RegresaPalabraLabel1.Name = "RegresaPalabraLabel1";
            this.RegresaPalabraLabel1.Size = new System.Drawing.Size(46, 13);
            this.RegresaPalabraLabel1.TabIndex = 13;
            this.RegresaPalabraLabel1.Text = "Palabra ";
            // 
            // PrecionarClickButton
            // 
            this.PrecionarClickButton.Location = new System.Drawing.Point(65, 128);
            this.PrecionarClickButton.Name = "PrecionarClickButton";
            this.PrecionarClickButton.Size = new System.Drawing.Size(96, 38);
            this.PrecionarClickButton.TabIndex = 12;
            this.PrecionarClickButton.Text = "Precionar";
            this.PrecionarClickButton.UseVisualStyleBackColor = true;
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(14, 38);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(203, 20);
            this.NumerotextBox.TabIndex = 11;
            // 
            // DigiteNumeroLabel1
            // 
            this.DigiteNumeroLabel1.AutoSize = true;
            this.DigiteNumeroLabel1.Location = new System.Drawing.Point(12, 21);
            this.DigiteNumeroLabel1.Name = "DigiteNumeroLabel1";
            this.DigiteNumeroLabel1.Size = new System.Drawing.Size(90, 13);
            this.DigiteNumeroLabel1.TabIndex = 10;
            this.DigiteNumeroLabel1.Text = "Digites el Numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 206);
            this.Controls.Add(this.PalabratextBox);
            this.Controls.Add(this.RegresaPalabraLabel1);
            this.Controls.Add(this.PrecionarClickButton);
            this.Controls.Add(this.NumerotextBox);
            this.Controls.Add(this.DigiteNumeroLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PalabratextBox;
        private System.Windows.Forms.Label RegresaPalabraLabel1;
        private System.Windows.Forms.Button PrecionarClickButton;
        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Label DigiteNumeroLabel1;
    }
}

