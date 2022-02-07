using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_listas
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public double Sal { get; set; }

        public Funcionario(int id, string nome, double sal)
        {
            Id = id;
            Nome = nome;
            Sal = sal;
        }

        public void NovoSal(double porc)
        {
            Sal += porc / 100 * Sal;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Sal;
        }

    }
}
