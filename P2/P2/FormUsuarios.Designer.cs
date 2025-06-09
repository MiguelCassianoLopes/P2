namespace P2
{
    partial class FormUsuarios
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
            lbUsuario = new Label();
            lbSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btCadastra = new Button();
            btAlterarSenha = new Button();
            btExcluir = new Button();
            lstUsuarios = new ListBox();
            SuspendLayout();
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbUsuario.Location = new Point(25, 75);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(52, 15);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Usuário:";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSenha.Location = new Point(33, 98);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(44, 15);
            lbSenha.TabIndex = 1;
            lbSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(83, 72);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(203, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(83, 98);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(203, 23);
            txtSenha.TabIndex = 3;
            // 
            // btCadastra
            // 
            btCadastra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCadastra.Location = new Point(83, 127);
            btCadastra.Name = "btCadastra";
            btCadastra.Size = new Size(84, 23);
            btCadastra.TabIndex = 4;
            btCadastra.Text = "Cadastrar";
            btCadastra.UseVisualStyleBackColor = true;
            // 
            // btAlterarSenha
            // 
            btAlterarSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btAlterarSenha.Location = new Point(134, 156);
            btAlterarSenha.Name = "btAlterarSenha";
            btAlterarSenha.Size = new Size(105, 23);
            btAlterarSenha.TabIndex = 5;
            btAlterarSenha.Text = "Alterar Senha";
            btAlterarSenha.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            btExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btExcluir.Location = new Point(202, 127);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(84, 23);
            btExcluir.TabIndex = 6;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // lstUsuarios
            // 
            lstUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.Items.AddRange(new object[] { "Exibir Usuario" });
            lstUsuarios.Location = new Point(306, 12);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(455, 424);
            lstUsuarios.TabIndex = 7;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 450);
            Controls.Add(lstUsuarios);
            Controls.Add(btExcluir);
            Controls.Add(btAlterarSenha);
            Controls.Add(btCadastra);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lbSenha);
            Controls.Add(lbUsuario);
            Name = "FormUsuarios";
            Text = "Cadastro de Usuários";
            Load += FormUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsuario;
        private Label lbSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btCadastra;
        private Button btAlterarSenha;
        private Button btExcluir;
        private ListBox lstUsuarios;
    }
}