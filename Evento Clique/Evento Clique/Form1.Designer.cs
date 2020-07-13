namespace Evento_Clique
{
    partial class Clique
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
            this.Texto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto.Location = new System.Drawing.Point(-2, 79);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(34, 24);
            this.Texto.TabIndex = 0;
            this.Texto.Text = "....";
            this.Texto.Click += new System.EventHandler(this.Texto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clique";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextoBox
            // 
            this.TextoBox.Location = new System.Drawing.Point(2, 42);
            this.TextoBox.Name = "TextoBox";
            this.TextoBox.Size = new System.Drawing.Size(100, 20);
            this.TextoBox.TabIndex = 2;
            // 
            // Clique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 196);
            this.Controls.Add(this.TextoBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Texto);
            this.Name = "Clique";
            this.Text = "Evento de Clique";
            this.Load += new System.EventHandler(this.Clique_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextoBox;
    }
}

