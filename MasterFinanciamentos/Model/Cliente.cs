using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MasterFinanciamentos.Model
{
    public class Cliente
    {
        private int id;
        private string nome;
        private DateOnly dataNascimento;
        private string endereco;
        private string telefone;
        private string cpf;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateOnly DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        public string jsonConvert(Cliente cliente)
        {
            string json = JsonConvert.SerializeObject(cliente);
            return json;
        }
    }
}
