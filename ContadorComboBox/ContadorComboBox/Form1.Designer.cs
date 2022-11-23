namespace ContadorComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbValor1 = new System.Windows.Forms.ComboBox();
            this.cbValor2 = new System.Windows.Forms.ComboBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbValor1
            // 
            this.cbValor1.FormattingEnabled = true;
            this.cbValor1.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbValor1.Location = new System.Drawing.Point(166, 123);
            this.cbValor1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbValor1.Name = "cbValor1";
            this.cbValor1.Size = new System.Drawing.Size(238, 33);
            this.cbValor1.TabIndex = 0;
            this.cbValor1.SelectedIndexChanged += new System.EventHandler(this.cbValor1_SelectedIndexChanged);
            // 
            // cbValor2
            // 
            this.cbValor2.FormattingEnabled = true;
            this.cbValor2.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbValor2.Location = new System.Drawing.Point(509, 123);
            this.cbValor2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbValor2.Name = "cbValor2";
            this.cbValor2.Size = new System.Drawing.Size(238, 33);
            this.cbValor2.TabIndex = 1;
            this.cbValor2.SelectedIndexChanged += new System.EventHandler(this.cbValor2_SelectedIndexChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(166, 203);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(581, 312);
            this.txtResultado.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 605);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.cbValor2);
            this.Controls.Add(this.cbValor1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbValor1;
        private System.Windows.Forms.ComboBox cbValor2;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

