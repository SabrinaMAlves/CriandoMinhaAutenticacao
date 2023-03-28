using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoMinhaAutenticacao
{
    public class Pessoas
    {
        public string Nome;
        public string Idade;
        public string Email;
        public string Id;

        public override string ToString()
        {
            return Nome + " - " + Idade;
        }
        public Pessoas(string nome, string idade, string email, string id)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
            Id = id;

        }
    }

}

