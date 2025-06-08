using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tsClientes_Click(object sender, EventArgs e)
        {
            var form = new FormClientes();
        }

        private void tsProdutos_Click(object sender, EventArgs e)
        {

        }

        private void tsPedidos_Click(object sender, EventArgs e)
        {

        }

        private void tsUsuarios_Click(object sender, EventArgs e)
        {

        }
    }
}
