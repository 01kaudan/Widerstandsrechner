namespace Widerstände
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.farbring1 = new System.Windows.Forms.ComboBox();
            this.farbring2 = new System.Windows.Forms.ComboBox();
            this.farbring3 = new System.Windows.Forms.ComboBox();
            this.Toleranz = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.berechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // farbring1
            // 
            this.farbring1.FormattingEnabled = true;
            this.farbring1.Items.AddRange(new object[] {
            "schwarz",
            "braun",
            "rot",
            "orange",
            "gelb",
            "grün",
            "blau",
            "violett",
            "grau",
            "weiß"});
            this.farbring1.Location = new System.Drawing.Point(231, 93);
            this.farbring1.Name = "farbring1";
            this.farbring1.Size = new System.Drawing.Size(195, 24);
            this.farbring1.TabIndex = 0;
            this.farbring1.Text = "1. Farbring";
            this.farbring1.SelectedIndexChanged += new System.EventHandler(this.farbring1_SelectedIndexChanged);
            // 
            // farbring2
            // 
            this.farbring2.FormattingEnabled = true;
            this.farbring2.Items.AddRange(new object[] {
            "schwarz",
            "braun",
            "rot",
            "orange",
            "gelb",
            "grün",
            "blau",
            "violett",
            "grau",
            "weiß"});
            this.farbring2.Location = new System.Drawing.Point(545, 93);
            this.farbring2.Name = "farbring2";
            this.farbring2.Size = new System.Drawing.Size(195, 24);
            this.farbring2.TabIndex = 1;
            this.farbring2.Text = "2. Farbring";
            this.farbring2.SelectedIndexChanged += new System.EventHandler(this.farbring2_SelectedIndexChanged);
            // 
            // farbring3
            // 
            this.farbring3.FormattingEnabled = true;
            this.farbring3.Items.AddRange(new object[] {
            "schwarz",
            "braun",
            "rot",
            "orange",
            "gelb",
            "grün",
            "blau",
            "violett",
            "grau",
            "weiß"});
            this.farbring3.Location = new System.Drawing.Point(880, 93);
            this.farbring3.Name = "farbring3";
            this.farbring3.Size = new System.Drawing.Size(195, 24);
            this.farbring3.TabIndex = 2;
            this.farbring3.Text = "3. Farbring";
            this.farbring3.SelectedIndexChanged += new System.EventHandler(this.farbring3_SelectedIndexChanged);
            // 
            // Toleranz
            // 
            this.Toleranz.FormattingEnabled = true;
            this.Toleranz.Items.AddRange(new object[] {
            "silver",
            "gold",
            "rot",
            "braun",
            "grün",
            "blau",
            "violett"});
            this.Toleranz.Location = new System.Drawing.Point(1159, 93);
            this.Toleranz.Name = "Toleranz";
            this.Toleranz.Size = new System.Drawing.Size(195, 24);
            this.Toleranz.TabIndex = 3;
            this.Toleranz.Text = "Toleranz";
            this.Toleranz.SelectedIndexChanged += new System.EventHandler(this.Toleranz_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(545, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 75);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // berechnen
            // 
            this.berechnen.Location = new System.Drawing.Point(1159, 370);
            this.berechnen.Name = "berechnen";
            this.berechnen.Size = new System.Drawing.Size(125, 75);
            this.berechnen.TabIndex = 5;
            this.berechnen.Text = "berechnen";
            this.berechnen.UseVisualStyleBackColor = true;
            this.berechnen.Click += new System.EventHandler(this.berechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 797);
            this.Controls.Add(this.berechnen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Toleranz);
            this.Controls.Add(this.farbring3);
            this.Controls.Add(this.farbring2);
            this.Controls.Add(this.farbring1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox farbring1;
        private System.Windows.Forms.ComboBox farbring2;
        private System.Windows.Forms.ComboBox farbring3;
        private System.Windows.Forms.ComboBox Toleranz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button berechnen;
    }
}

