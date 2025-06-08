namespace P2
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btLogin = new Button();
            lbUsuario = new Label();
            lbSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btLogin.Location = new Point(131, 214);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(101, 23);
            btLogin.TabIndex = 0;
            btLogin.Text = "LOGIN";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbUsuario.Location = new Point(40, 159);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.RightToLeft = RightToLeft.No;
            lbUsuario.Size = new Size(64, 15);
            lbUsuario.TabIndex = 1;
            lbUsuario.Text = "USUÁRIO:";
            lbUsuario.UseWaitCursor = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSenha.Location = new Point(55, 188);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(49, 15);
            lbSenha.TabIndex = 2;
            lbSenha.Text = "SENHA:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(110, 156);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(146, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(110, 185);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(146, 23);
            txtSenha.TabIndex = 4;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 378);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lbSenha);
            Controls.Add(lbUsuario);
            Controls.Add(btLogin);
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLogin;
        private Label lbUsuario;
        private Label lbSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
    }
}
