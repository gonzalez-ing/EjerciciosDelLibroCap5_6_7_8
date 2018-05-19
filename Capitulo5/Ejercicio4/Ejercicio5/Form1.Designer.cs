namespace Ejercicio5
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
            this.BorrarBotton = new System.Windows.Forms.Button();
            this.PerimetroPoligonoLabel1 = new System.Windows.Forms.Label();
            this.PerimetroPoligonotextBox3 = new System.Windows.Forms.TextBox();
            this.DimecionPoligonotextBox2 = new System.Windows.Forms.TextBox();
            this.DimencionPoligonoLabel2 = new System.Windows.Forms.Label();
            this.NumeroLadotextBox1 = new System.Windows.Forms.TextBox();
            this.NumeroLadoLabel = new System.Windows.Forms.Label();
            this.CacularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BorrarBotton
            // 
            this.BorrarBotton.Location = new System.Drawing.Point(184, 99);
            this.BorrarBotton.Name = "BorrarBotton";
            this.BorrarBotton.Size = new System.Drawing.Size(75, 23);
            this.BorrarBotton.TabIndex = 23;
            this.BorrarBotton.Text = "Borrar";
            this.BorrarBotton.UseVisualStyleBackColor = true;
            // 
            // PerimetroPoligonoLabel1
            // 
            this.PerimetroPoligonoLabel1.AutoSize = true;
            this.PerimetroPoligonoLabel1.Location = new System.Drawing.Point(12, 108);
            this.PerimetroPoligonoLabel1.Name = "PerimetroPoligonoLabel1";
            this.PerimetroPoligonoLabel1.Size = new System.Drawing.Size(55, 13);
            this.PerimetroPoligonoLabel1.TabIndex = 22;
            this.PerimetroPoligonoLabel1.Text = "Resultado";
            // 
            // PerimetroPoligonotextBox3
            // 
            this.PerimetroPoligonotextBox3.Location = new System.Drawing.Point(14, 125);
            this.PerimetroPoligonotextBox3.Name = "PerimetroPoligonotextBox3";
            this.PerimetroPoligonotextBox3.Size = new System.Drawing.Size(100, 20);
            this.PerimetroPoligonotextBox3.TabIndex = 21;
            // 
            // DimecionPoligonotextBox2
            // 
            this.DimecionPoligonotextBox2.Location = new System.Drawing.Point(14, 80);
            this.DimecionPoligonotextBox2.Name = "DimecionPoligonotextBox2";
            this.DimecionPoligonotextBox2.Size = new System.Drawing.Size(100, 20);
            this.DimecionPoligonotextBox2.TabIndex = 20;
            // 
            // DimencionPoligonoLabel2
            // 
            this.DimencionPoligonoLabel2.AutoSize = true;
            this.DimencionPoligonoLabel2.Location = new System.Drawing.Point(12, 63);
            this.DimencionPoligonoLabel2.Name = "DimencionPoligonoLabel2";
            this.DimencionPoligonoLabel2.Size = new System.Drawing.Size(119, 13);
            this.DimencionPoligonoLabel2.TabIndex = 19;
            this.DimencionPoligonoLabel2.Text = "Dimencion de Poligono ";
            // 
            // NumeroLadotextBox1
            // 
            this.NumeroLadotextBox1.Location = new System.Drawing.Point(14, 39);
            this.NumeroLadotextBox1.Name = "NumeroLadotextBox1";
            this.NumeroLadotextBox1.Size = new System.Drawing.Size(100, 20);
            this.NumeroLadotextBox1.TabIndex = 18;
            // 
            // NumeroLadoLabel
            // 
            this.NumeroLadoLabel.AutoSize = true;
            this.NumeroLadoLabel.Location = new System.Drawing.Point(12, 22);
            this.NumeroLadoLabel.Name = "NumeroLadoLabel";
            this.NumeroLadoLabel.Size = new System.Drawing.Size(91, 13);
            this.NumeroLadoLabel.TabIndex = 17;
            this.NumeroLadoLabel.Text = "Numero de Lados";
            // 
            // CacularButton
            // 
            this.CacularButton.Location = new System.Drawing.Point(184, 34);
            this.CacularButton.Name = "CacularButton";
            this.CacularButton.Size = new System.Drawing.Size(75, 23);
            this.CacularButton.TabIndex = 16;
            this.CacularButton.Text = "Calcular";
            this.CacularButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.BorrarBotton);
            this.Controls.Add(this.PerimetroPoligonoLabel1);
            this.Controls.Add(this.PerimetroPoligonotextBox3);
            this.Controls.Add(this.DimecionPoligonotextBox2);
            this.Controls.Add(this.DimencionPoligonoLabel2);
            this.Controls.Add(this.NumeroLadotextBox1);
            this.Controls.Add(this.NumeroLadoLabel);
            this.Controls.Add(this.CacularButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BorrarBotton;
        private System.Windows.Forms.Label PerimetroPoligonoLabel1;
        private System.Windows.Forms.TextBox PerimetroPoligonotextBox3;
        private System.Windows.Forms.TextBox DimecionPoligonotextBox2;
        private System.Windows.Forms.Label DimencionPoligonoLabel2;
        private System.Windows.Forms.TextBox NumeroLadotextBox1;
        private System.Windows.Forms.Label NumeroLadoLabel;
        private System.Windows.Forms.Button CacularButton;
    }
}

