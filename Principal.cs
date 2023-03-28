using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;

namespace CriandoMinhaAutenticacao
{
    public partial class lboPrincipal : Form
    {
        public lboPrincipal()
        {
            InitializeComponent();
        }

        public async void obtendoDados()
        {
            lboPrincipal.Items.Clear();
            var resultado = await cliente.Child("Pessoas").OnceAsJsonAsync();
            JsonDocument importandoMinhaBase = JsonDocument.Parse(resultado);
            JsonElement filho = importandoMinhaBase.RootElement;
            if (filho.ValueKind.ToString() == "Null") return;



            foreach (var item in filho.EnumerateObject())
            {
                JsonElement produtoFirebase = item.Value;
                string nome = produtoFirebase.GetProperty("Nome").GetString()!;
                string email = produtoFirebase.GetProperty("Email").GetString()!;
                string idade = produtoFirebase.GetProperty("Idade").GetString()!;
                string id = item.Name;
                Pessoas pessoa = new Pessoas(nome, idade, email, id);
                lboPrincipal.Items.Add(pessoa);
            }
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
