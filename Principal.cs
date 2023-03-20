using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;

namespace CriandoMinhaAutenticacao
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnLogoff_Click(object sender, EventArgs e)
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
            Cliente.SignOut(); // saindo do cliente 
            Login login = new Login();
            Hide(); // escondendo o formulario
            login.Closed += fecharFormulario;
            login.Show();

        }
            private void fecharFormulario(Object? enviado, EventArgs args)
            {
             Close();
            }
    }
}
