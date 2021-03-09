using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Cliente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public virtual double ObterValorCheque()
        {
            return 5000.89;
        }

        public virtual double ObterValorCheque(int fatorMultiplicador)
        {
            return ObterValorCheque() * fatorMultiplicador;
        }
    }
}
