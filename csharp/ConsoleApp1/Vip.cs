using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Vip: Cliente
    {
        public Vip(string nome, string sobrenome):
            base(nome, sobrenome)
        {

        }

        public override double ObterValorCheque()
        {
            return 10000.67;
        }

    }
}
