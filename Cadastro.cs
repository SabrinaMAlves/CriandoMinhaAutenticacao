using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Documentação oficial google 
//using FirebaseAdmin;
//using FirebaseAdmin.Auth;
//using Google.Apis.Auth.OAuth2;

namespace CriandoMinhaAutenticacao
{
    public partial class Cadastro : Form
    {
        FirebaseAuth auth = FirebaseAuth.DefaultInstance; // instalação de pacote do firabase 


        public Cadastro()
        {
            InitializeComponent();
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("auth.json") // caminho do arquivo JSON
            });
        }

        private void BtnCancelar_Click(object sender, EventArgs e) // retorna para login 
        {
            Login login = new Login();
            Hide(); // escondendo o formulario
            login.Closed += fecharFormulario;
            login.Show();
        }
        private void fecharFormulario(Object? enviado, EventArgs args)
        {
            Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TxtSenha.Text != Txtconfirmar.Text)// verificando se a senha é a mesma, se for diferente 
            {
                MessageBox.Show(" As senhas não batem, por favor revisar"); // caso seja diferente apresenta mensagem.
                return;
            }
            if (TxtSenha.Text.Length <= 8) // senha maior ou igual a 8 digitos
            {
                MessageBox.Show("Digite uma senha com no minimo 8 caracteres");
                return;
            }
            try
            {

                var usuario = FirebaseAuth.DefaultInstance.CreateUserAsync(new UserRecordArgs()
                {
                    Email = TxtEmail.Text,
                    Password = TxtSenha.Text,
                }).Result;
                MessageBox.Show(usuario.Uid);
                MessageBox.Show(usuario.EmailVerified.ToString());
                 Principal principal = new Principal();
                 Hide();
                 principal.Closed += fecharFormulario;
                 principal.Show(); 

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The user with the provided email already exists (EMAIL_EXISTS"))
                {
                    MessageBox.Show("Já existe o e-mail cadastrado");
                }
                else
                {

                    MessageBox.Show("Erro:" + ex.Message);
                   //  Clipboard.SetText(ex.Message); //
                }
            }
            
        }
    }
}
