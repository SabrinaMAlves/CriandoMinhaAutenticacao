using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Firebase.Auth;

namespace CriandoMinhaAutenticacao
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
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
            Thread.Sleep(1000);
            if (Cliente.User != null)
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new lboPrincipal());

            }
            else
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Login());
            }
        }
    }
}