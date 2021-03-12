using System;
using System.Collections.Generic;

namespace Ex6Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salário)");
            Console.WriteLine("de N funcionários. Não deve haver repetição de Id. Em seguida, efetuar o aumento de X por");
            Console.WriteLine("cento no salário de um determinado funcionário.Para isso, o programa deve ler um Id e o valor");
            Console.WriteLine("X. Se o Id informado não existir, mostrar uma mensagem e abortar a operação. Ao final, mostrar");
            Console.WriteLine("a listagem atualizada dos funcionários, conforme exemplos. Lembre - se de aplicar a técnica ");
            Console.WriteLine("de encapsulamento para não permitir que o salário possa ser mudado livremente.Um salário só ");
            Console.WriteLine("pode ser aumentado com base em uma operação de aumento por porcentagem dada. ");

            Console.WriteLine("\n****** Employee Payment Console Sytem ******");
            
            Console.WriteLine("\nHow many Employees will be registred?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>(); 

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n--------------------");
                Console.WriteLine("Employee Number " + (i + 1) + ": ");
                Console.Write("*ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("*Name: ");
                string name = Console.ReadLine();
                Console.Write("*Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
            }
            Console.WriteLine("\n--------------------");
            Console.WriteLine("Enter the Employee Id that will have salary increase");
            int compareId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.ID == compareId);
            if (emp != null)
            {
                Console.WriteLine("Enter the Percentage: ");
                double percent = double.Parse(Console.ReadLine());
                emp.ChangeSalary(percent);
            }
            else
            {
                Console.WriteLine("This Id does not exist.");
            }
            Console.WriteLine("\n--------------------");
            Console.WriteLine("Updated List of employees: ");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
