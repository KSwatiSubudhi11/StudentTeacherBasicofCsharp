using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcepts
{
    class FullTimeEmployee : Employee, IEmployeeBenifits
    {
        public int MonthlySalary { get; set; }
        public FullTimeEmployee(int id, string name, string dept, int monthlySal, IFinanceTeam team) : base(id, name, dept, team)
        {
            this.MonthlySalary = monthlySal;
        }

        public void GetBenifit()
        {
            // Logic
        }

        public int GetBenifit(string benifitName)
        {
            return 1;
        }

        public virtual void GetSalary()
        {
            Console.WriteLine("Getting salary in fulltime employee class");
        }
    }
}
