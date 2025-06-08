using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "ADMIN" && senha == "123")
            {
                AbrirForm2();
            }
        }
        private void AbrirForm2()
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }
    }
}
