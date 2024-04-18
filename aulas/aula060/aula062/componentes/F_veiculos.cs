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
    public partial class F_veiculos : Form
    {
        F_principal fp;
        public F_veiculos(string v, F_principal f)
        {
            InitializeComponent();
            tb_box.Text = v;

            fp = f;
            f.num = 10;
        }

        private void F_veiculos_Load(object sender, EventArgs e)
        {

        }

        private void tb_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaVeiculos.Text = tb_box.Text;
        }
    }
}
