namespace Seznami
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVnos = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdstrani = new System.Windows.Forms.Button();
            this.btnPrvi = new System.Windows.Forms.Button();
            this.btnIzpiši = new System.Windows.Forms.Button();
            this.txtKonzola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vnesi niz";
            // 
            // txtVnos
            // 
            this.txtVnos.Location = new System.Drawing.Point(202, 26);
            this.txtVnos.Name = "txtVnos";
            this.txtVnos.Size = new System.Drawing.Size(208, 31);
            this.txtVnos.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(466, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(160, 45);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdstrani
            // 
            this.btnOdstrani.Location = new System.Drawing.Point(32, 88);
            this.btnOdstrani.Name = "btnOdstrani";
            this.btnOdstrani.Size = new System.Drawing.Size(160, 45);
            this.btnOdstrani.TabIndex = 3;
            this.btnOdstrani.Text = "Odstrani";
            this.btnOdstrani.UseVisualStyleBackColor = true;
            this.btnOdstrani.Click += new System.EventHandler(this.btnOdstrani_Click);
            // 
            // btnPrvi
            // 
            this.btnPrvi.Location = new System.Drawing.Point(231, 88);
            this.btnPrvi.Name = "btnPrvi";
            this.btnPrvi.Size = new System.Drawing.Size(160, 45);
            this.btnPrvi.TabIndex = 4;
            this.btnPrvi.Text = "Prvi";
            this.btnPrvi.UseVisualStyleBackColor = true;
            this.btnPrvi.Click += new System.EventHandler(this.btnPrvi_Click);
            // 
            // btnIzpiši
            // 
            this.btnIzpiši.Location = new System.Drawing.Point(466, 88);
            this.btnIzpiši.Name = "btnIzpiši";
            this.btnIzpiši.Size = new System.Drawing.Size(160, 45);
            this.btnIzpiši.TabIndex = 5;
            this.btnIzpiši.Text = "Izpiši";
            this.btnIzpiši.UseVisualStyleBackColor = true;
            this.btnIzpiši.Click += new System.EventHandler(this.btnIzpiši_Click);
            // 
            // txtKonzola
            // 
            this.txtKonzola.Location = new System.Drawing.Point(44, 285);
            this.txtKonzola.Multiline = true;
            this.txtKonzola.Name = "txtKonzola";
            this.txtKonzola.ReadOnly = true;
            this.txtKonzola.Size = new System.Drawing.Size(573, 332);
            this.txtKonzola.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 646);
            this.Controls.Add(this.txtKonzola);
            this.Controls.Add(this.btnIzpiši);
            this.Controls.Add(this.btnPrvi);
            this.Controls.Add(this.btnOdstrani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtVnos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVnos;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdstrani;
        private System.Windows.Forms.Button btnPrvi;
        private System.Windows.Forms.Button btnIzpiši;
        private System.Windows.Forms.TextBox txtKonzola;
    }
}

