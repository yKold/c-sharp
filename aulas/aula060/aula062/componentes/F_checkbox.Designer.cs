﻿namespace componentes
{
    partial class F_checkbox
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
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_navio = new System.Windows.Forms.CheckBox();
            this.cb_onibus = new System.Windows.Forms.CheckBox();
            this.btn_transportesMarcados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(23, 14);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(51, 17);
            this.cb_carro.TabIndex = 4;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(23, 38);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(53, 17);
            this.cb_aviao.TabIndex = 5;
            this.cb_aviao.Text = "Avião";
            this.cb_aviao.UseVisualStyleBackColor = true;
            // 
            // cb_navio
            // 
            this.cb_navio.AutoSize = true;
            this.cb_navio.Location = new System.Drawing.Point(23, 62);
            this.cb_navio.Name = "cb_navio";
            this.cb_navio.Size = new System.Drawing.Size(54, 17);
            this.cb_navio.TabIndex = 6;
            this.cb_navio.Text = "Navio";
            this.cb_navio.UseVisualStyleBackColor = true;
            // 
            // cb_onibus
            // 
            this.cb_onibus.AutoSize = true;
            this.cb_onibus.Location = new System.Drawing.Point(23, 86);
            this.cb_onibus.Name = "cb_onibus";
            this.cb_onibus.Size = new System.Drawing.Size(59, 17);
            this.cb_onibus.TabIndex = 7;
            this.cb_onibus.Text = "Ônibus";
            this.cb_onibus.UseVisualStyleBackColor = true;
            // 
            // btn_transportesMarcados
            // 
            this.btn_transportesMarcados.Location = new System.Drawing.Point(197, 14);
            this.btn_transportesMarcados.Name = "btn_transportesMarcados";
            this.btn_transportesMarcados.Size = new System.Drawing.Size(202, 23);
            this.btn_transportesMarcados.TabIndex = 8;
            this.btn_transportesMarcados.Text = "transportes marcados";
            this.btn_transportesMarcados.UseVisualStyleBackColor = true;
            this.btn_transportesMarcados.Click += new System.EventHandler(this.btn_transportesMarcados_Click);
            // 
            // F_checkbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_transportesMarcados);
            this.Controls.Add(this.cb_onibus);
            this.Controls.Add(this.cb_navio);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_checkbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_carro;
        private System.Windows.Forms.CheckBox cb_aviao;
        private System.Windows.Forms.CheckBox cb_navio;
        private System.Windows.Forms.CheckBox cb_onibus;
        private System.Windows.Forms.Button btn_transportesMarcados;
    }
}