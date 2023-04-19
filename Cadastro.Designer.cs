namespace CriandoMinhaAutenticacao
{
    partial class Cadastro
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
            TxtEmail = new TextBox();
            TxtSenha = new TextBox();
            Txtconfirmar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label = new Label();
            BtnCadastrar = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(52, 76);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "E-mail existente";
            TxtEmail.Size = new Size(170, 23);
            TxtEmail.TabIndex = 0;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(52, 165);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PasswordChar = '☻';
            TxtSenha.PlaceholderText = "Mínimo de 8 caracteres";
            TxtSenha.Size = new Size(170, 23);
            TxtSenha.TabIndex = 1;
            // 
            // Txtconfirmar
            // 
            Txtconfirmar.Location = new Point(52, 247);
            Txtconfirmar.Name = "Txtconfirmar";
            Txtconfirmar.PasswordChar = '*';
            Txtconfirmar.PlaceholderText = "Digita novamente a senha";
            Txtconfirmar.Size = new Size(170, 23);
            Txtconfirmar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 41);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 3;
            label1.Text = "Digite seu E-mail : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 134);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 4;
            label2.Text = "Digite sua senha : ";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(50, 214);
            label.Name = "label";
            label.Size = new Size(118, 15);
            label.TabIndex = 5;
            label.Text = "Confirme sua senha :";
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Location = new Point(50, 318);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(75, 23);
            BtnCadastrar.TabIndex = 6;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(171, 318);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 429);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnCadastrar);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txtconfirmar);
            Controls.Add(TxtSenha);
            Controls.Add(TxtEmail);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEmail;
        private TextBox TxtSenha;
        private TextBox Txtconfirmar;
        private Label label1;
        private Label label2;
        private Label label;
        private Button BtnCadastrar;
        private Button BtnCancelar;
    }
}