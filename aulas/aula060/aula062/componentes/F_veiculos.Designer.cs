namespace componentes
{
    partial class F_veiculos
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
            this.tb_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_box
            // 
            this.tb_box.Location = new System.Drawing.Point(2, 2);
            this.tb_box.Multiline = true;
            this.tb_box.Name = "tb_box";
            this.tb_box.Size = new System.Drawing.Size(525, 521);
            this.tb_box.TabIndex = 0;
            this.tb_box.TextChanged += new System.EventHandler(this.tb_box_TextChanged);
            // 
            // F_veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 524);
            this.Controls.Add(this.tb_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lista de veiculos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_veiculos_FormClosed);
            this.Load += new System.EventHandler(this.F_veiculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_box;
    }
}