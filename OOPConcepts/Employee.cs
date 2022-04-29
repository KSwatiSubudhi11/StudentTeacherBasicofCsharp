using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcepts
{
    abstract class Employee
    {
        //public ITTeam ITTeam { get; set; }
        public IFinanceTeam FinanceTeam { get; set; }
        

        public Employee(int id, string name, string dept, IFinanceTeam team)
        {
            this.ID = id;
            this.Name = name;
            this.Department = dept;
            //ITTeam = new ITTeam(); // incorrect way.
            FinanceTeam = team;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public void DoWork()
        {
            // do work
            //ITTeam.SolveProblem(); // is this correct ?
        }

        public void GetSalary()
        {
            Console.WriteLine(this.ID);
            // Get Salary
            Console.WriteLine("Salary credited");
            FinanceTeam.TakeRequestFromEmployee();
        }

    }
}
