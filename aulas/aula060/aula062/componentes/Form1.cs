using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componentes
{
    public partial class F_principal : Form
    {
        public int num;
        public F_principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um veículo");
                tb_veiculo.Focus();
                return;
            } else
            {
                tb_listaVeiculos.Text += tb_veiculo.Text + ",  ";
                tb_veiculo.Clear();
                tb_veiculo.Focus();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear();
            tb_listaVeiculos.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_veiculos f_Veiculos = new F_veiculos(tb_listaVeiculos.Text, this);
            f_Veiculos.Show();
        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_checkbox f_Checkbox = new F_checkbox();
            f_Checkbox.ShowDialog();
        }

        private void checkedListboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_checkedlistbox f_Checkedlistbox = new F_checkedlistbox();
            f_Checkedlistbox.ShowDialog();
        }
    }
}
