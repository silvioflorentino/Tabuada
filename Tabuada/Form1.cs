using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class TelaTabuada : Form
    {
        public TelaTabuada()
        {
            InitializeComponent();
        }

        private void CalcularTabuada()
        {
            lBoxResul.Items.Clear();
           
            int valor = Convert.ToInt32(txtNum.Text);
            for( int i = 0; i<=10; i++)
            {
                lBoxResul.Items.Add(valor + " x " + i + " = " + (valor * i ));
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '\r')
            {
                if(e.KeyChar == '\r')
                {
                    CalcularTabuada();
                }
                txtNum.Focus();
                txtNum.Clear();
            }
            else
            {
                e.KeyChar = '\0';
            }
           
        }
    }
}
