using System;
using System.Collections.Generic;

namespace exercicio_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionarios serão resgistrados: ");
            int qnt = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < qnt; i++)
            {
                Console.WriteLine("Funcionario #" + i);
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("ID");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Salario");
                double sal = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(id, nome, sal));

            }

            Console.WriteLine("Entre o id do funcionario");
            int Idplus = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == Idplus);
            if (func != null)
            {
                Console.WriteLine("Entre a porcentagem do aumento do salario");
                double porc = double.Parse(Console.ReadLine());
                func.NovoSal(porc);
            }
            else
            {
                Console.WriteLine("Não existe esse id");
            }

            Console.WriteLine("Lista de funcionarios: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }





        }
    }
}
