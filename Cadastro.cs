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
// Utilizãção para autenticação 
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;

namespace CriandoMinhaAutenticacao
{
    public partial class Cadastro : Form
    {
        //FirebaseAuth auth = FirebaseAuth.DefaultInstance; // instalação de pacote do firabase 


        public Cadastro()
        {
            InitializeComponent();
            /*FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("auth.json") // caminho do arquivo JSON
            });*/
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
                var config = new FirebaseAuthConfig
                {
                    ApiKey = "AIzaSyD7LUHpfYpYRNEP32olS3m-TWzU_y3yM6U",

                    AuthDomain = "aula-09-03-2023-138a2.firebaseapp.com",
                    Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                },
                    UserRepository = new FileUserRepository
                ("NossosDados")
                };
                var Cliente = new FirebaseAuthClient(config);
                Cliente.CreateUserWithEmailAndPasswordAsync
                (TxtEmail.Text, TxtSenha.Text);
                Thread.Sleep(1000);
                lboPrincipal principal = new lboPrincipal();
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

                }

                //Versão oficial do google 
                /*try
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
                }*/

            }
        }
    }
}
