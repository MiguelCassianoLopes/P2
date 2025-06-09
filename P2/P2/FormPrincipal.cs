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

        private string usuarioAdmin;


        public FormPrincipal(string usuario)
        {
            InitializeComponent();
            usuarioAdmin = usuario;
            tsUsuarios.Visible = usuario == "ADMIN";
        }

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
            form.ShowDialog();
        }

        private void tsProdutos_Click(object sender, EventArgs e)
        {
            var form = new FormProdutos();
            form.ShowDialog();
        }

        private void tsPedidos_Click(object sender, EventArgs e)
        {
            var form = new FormPedidos();
            form.ShowDialog();
        }

        private void tsUsuarios_Click(object sender, EventArgs e)
        {
            var form = new FormUsuarios();
            form.ShowDialog();
        }
    }
}
