namespace Adicionar_Tabela
{
    partial class Resultado
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
            this.tx_resultado = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_resultado
            // 
            this.tx_resultado.Location = new System.Drawing.Point(12, 12);
            this.tx_resultado.Multiline = true;
            this.tx_resultado.Name = "tx_resultado";
            this.tx_resultado.Size = new System.Drawing.Size(301, 229);
            this.tx_resultado.TabIndex = 0;
            this.tx_resultado.TextChanged += new System.EventHandler(this.tx_result_TextChanged);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(319, 218);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "Sair";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Voltar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.tx_resultado);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_resultado;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button button1;
    }
}