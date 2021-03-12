using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6Listas
{
    class Employee
    {
        //--------------------< AUTO IMPLEMENTED PROPRIERTIES ]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        //--------------------< CONSTRUCTORS ]
        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

        //--------------------< METHODS ]

        public void ChangeSalary(double percent)
        {
            Salary = Salary+ (Salary * (percent / 100));
        }
        public override string ToString()
        {
            return "\n--------------------\nID: " + ID
                    + "\nName: " + Name
                    + "\nSalary: " + Salary;
        }
    }
}
