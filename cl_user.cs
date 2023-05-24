using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabRegister
{
    class cl_user
    {
        private string id;
        private string nome;
        private string cpf;
        private string tel;
        private string email;
        private string genero;
        private string endereco;
        private string dtnasc;

        public string Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Dtnasc { get => dtnasc; set => dtnasc = value; }
    }
}
