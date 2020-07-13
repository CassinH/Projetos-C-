namespace Adicionar_Tabela
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
            this.Adicionar = new System.Windows.Forms.Button();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_resultado = new System.Windows.Forms.TextBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(124, 54);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 21);
            this.Adicionar.TabIndex = 0;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // tx_name
            // 
            this.tx_name.Location = new System.Drawing.Point(12, 54);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(106, 20);
            this.tx_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite:";
            // 
            // tx_resultado
            // 
            this.tx_resultado.Location = new System.Drawing.Point(12, 81);
            this.tx_resultado.Multiline = true;
            this.tx_resultado.Name = "tx_resultado";
            this.tx_resultado.Size = new System.Drawing.Size(187, 133);
            this.tx_resultado.TabIndex = 3;
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(12, 220);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(187, 26);
            this.Limpar.TabIndex = 4;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(13, 252);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(186, 23);
            this.Mostrar.TabIndex = 5;
            this.Mostrar.Text = "Mostrar Lista";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Valores na Tabela";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(243, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.mostrarListaToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            this.componentesToolStripMenuItem.Click += new System.EventHandler(this.componentesToolStripMenuItem_Click);
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // mostrarListaToolStripMenuItem
            // 
            this.mostrarListaToolStripMenuItem.Name = "mostrarListaToolStripMenuItem";
            this.mostrarListaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarListaToolStripMenuItem.Text = "Mostrar Lista";
            this.mostrarListaToolStripMenuItem.Click += new System.EventHandler(this.mostrarListaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.tx_resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_name);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tabela ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_resultado;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarListaToolStripMenuItem;
    }
}

