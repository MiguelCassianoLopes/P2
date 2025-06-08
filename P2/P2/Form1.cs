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
                return;

            }

            string caminhoCsv = "C:\\Users\\Computador\\source\\repos\\P2\\usuarios.csv";

            if (File.Exists(caminhoCsv))

            {
                var linhas = File.ReadAllLines(caminhoCsv);

                bool usuarioEncontrado = linhas.Any(linha =>
                {
                    var partes = linha.Split(';');
                    return partes.Length >= 2 && partes[0] == usuario && partes[1] == senha;
                });
                if (usuarioEncontrado)
                {
                    AbrirForm2();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
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
