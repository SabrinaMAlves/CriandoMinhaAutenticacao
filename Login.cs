using System.Runtime.InteropServices.ObjectiveC;

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
            // this.Close(); // login ser� fechado ( metodo j� criado)   

        }

        private void fecharFormulario(Object? enviado, EventArgs args)
        {
            Close();
        }




    }

}