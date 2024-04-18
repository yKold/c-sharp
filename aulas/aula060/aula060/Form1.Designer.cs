namespace aula060
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
            this.bt_enviar = new System.Windows.Forms.Button();
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_enviar
            // 
            this.bt_enviar.Location = new System.Drawing.Point(105, 105);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(100, 48);
            this.bt_enviar.TabIndex = 0;
            this.bt_enviar.Text = "ENVIAR";
            this.bt_enviar.UseVisualStyleBackColor = true;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // lb_nome
            // 
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(102, 166);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(103, 30);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "NOME";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(105, 79);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 2;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(989, 633);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.bt_enviar);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_luiz;
        private System.Windows.Forms.Button bt_julio;
        private System.Windows.Forms.TextBox tb_box1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_enviar;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tb_nome;
    }
}

