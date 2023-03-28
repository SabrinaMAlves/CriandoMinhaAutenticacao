using System.Runtime.InteropServices.ObjectiveC;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;


namespace CriandoMinhaAutenticacao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e) // retornar para cadastrar 
        {
            Cadastro cadastro = new Cadastro();
            Hide(); // escondendo o formulario
            cadastro.Closed += fecharFormulario;
            cadastro.Show();
            // this.Close(); // login será fechado ( metodo já criado)   

        }

        private void fecharFormulario(Object? enviado, EventArgs args)
        {
            Close();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
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
                var auth = Cliente.SignInWithEmailAndPasswordAsync(
                    TxtEmail.Text, TxtSenha.Text
                    ).Result;
                MessageBox.Show(auth.User.Uid);
                Thread.Sleep(1000);
                lboPrincipal principal = new lboPrincipal();
                Hide();
                principal.Closed += fecharFormulario;
                principal.Show();
            }
            catch (Exception ex)  
            {
                if (ex.Message.Contains("EMAIL_NOT_FOUND"))
                    MessageBox.Show("Não existe esse usuario");
                else if (ex.Message.Contains("INVALID_PASSWORD"))
                    MessageBox.Show("Senha incorreta");
                else  MessageBox.Show(ex.Message);
            }
        }
    }

}