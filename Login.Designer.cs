namespace CriandoMinhaAutenticacao
{
    partial class Login
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
            TxtEmail = new TextBox();
            TxtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbllSenha = new LinkLabel();
            BtnEntrar = new Button();
            BtnCadastrar = new Button();
            SuspendLayout();
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(114, 67);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Nome@servidor.com";
            TxtEmail.Size = new Size(128, 23);
            TxtEmail.TabIndex = 0;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(115, 133);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PasswordChar = '☻';
            TxtSenha.PlaceholderText = "Uzumaki";
            TxtSenha.Size = new Size(127, 23);
            TxtSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 40);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite seu E-mail :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 104);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "Digite sua senha :";
            // 
            // lbllSenha
            // 
            lbllSenha.AutoSize = true;
            lbllSenha.Location = new Point(118, 172);
            lbllSenha.Name = "lbllSenha";
            lbllSenha.Size = new Size(118, 15);
            lbllSenha.TabIndex = 4;
            lbllSenha.TabStop = true;
            lbllSenha.Text = "Esqueci minha senha";
            // 
            // BtnEntrar
            // 
            BtnEntrar.Location = new Point(87, 213);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(75, 23);
            BtnEntrar.TabIndex = 5;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = true;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Location = new Point(190, 213);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(75, 23);
            BtnCadastrar.TabIndex = 6;
            BtnCadastrar.Text = "Cadastro";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 320);
            Controls.Add(BtnCadastrar);
            Controls.Add(BtnEntrar);
            Controls.Add(lbllSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtSenha);
            Controls.Add(TxtEmail);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEmail;
        private TextBox TxtSenha;
        private Label label1;
        private Label label2;
        private LinkLabel lbllSenha;
        private Button BtnEntrar;
        private Button BtnCadastrar;
    }
}