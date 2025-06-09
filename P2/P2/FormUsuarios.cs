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
    public partial class FormUsuarios : Form
    {
        private string usuarioLogado;
        private string caminhoUsuarios = "C:\\Users\\Computador\\source\\repos\\P2\\usuarios.csv";
        public FormUsuarios(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            CarregarUsuarios();
        }

        public FormUsuarios()
        {
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }
        private void CarregarUsuarios()
        {
            lstUsuarios.Items.Clear();
            if (File.Exists(usuarioLogado))
            {

                var linhas = File.ReadAllLines(caminhoUsuarios);
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(';');
                    if (dados.Length >= 1)
                    {
                        string usuario = dados[0];
                        string senha = dados[1];
                        lstUsuarios.Items.Add($"{usuario} - {senha}");
                    }
                }
            }

        }

        private void btCadastra_Click(object sender, EventArgs e)
        {
            if (usuarioLogado == "ADMIN")
            {
                MessageBox.Show("Somente o administrador pode cadastrar usuários!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string novoUsuario = txtUsuario.Text.Trim();
            string novaSenha = txtSenha.Text.Trim();

            if (novoUsuario == "" && novaSenha == "")
            {
                MessageBox.Show("Preencha os campos de usuário e senha!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}