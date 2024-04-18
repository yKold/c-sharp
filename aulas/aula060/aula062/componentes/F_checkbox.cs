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
    public partial class F_checkbox : Form
    {   
        List<CheckBox> transp = new List<CheckBox>();
        public F_checkbox()
        {
            InitializeComponent();
            transp.Add(cb_aviao);
            transp.Add(cb_carro);
            transp.Add(cb_navio);
            transp.Add(cb_onibus);
        }

        private void btn_transportesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach(CheckBox c in transp)
            {
                if (c.Checked)
                {
                    txt += c.Text;
                }
            }
            MessageBox.Show(txt);
        }
    }
}
