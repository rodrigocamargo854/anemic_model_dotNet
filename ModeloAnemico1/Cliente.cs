using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloAnemico1
{
    internal sealed class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }


        public Cliente(int id, string nome, string endereco)
        {
            Validar(id, Nome, Endereco);
            Id = id;
            Nome = Nome;
            Endereco = endereco;
        }

        public void Update(int id, string nome, string endereco)
        {
            Validar(id, Nome, Endereco);
            Id = id;
            Nome = Nome;
            Endereco = endereco;
        }

        private void Validar(int id, string nome, string endereco)
        {
            if (id < 0)
                throw new InvalidOperationException("O Id tem que ser maior que 0");

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
                throw new InvalidOperationException("Nome é requerido");

            if (nome.Length < 3)
                throw new InvalidOperationException("O nome deve ter no minimo 3 caracteres");

            if (nome.Length < 100)
                throw new ArgumentException("O nome excedeu 100 caracteres");

        }
    }

   
    
}
