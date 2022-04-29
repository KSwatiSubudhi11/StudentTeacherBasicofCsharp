using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcepts
{
    class PartTimeEmployee : Employee, IEmployeeBenifits
    {
        public int HourlySalary { get; set; }
        public PartTimeEmployee(int id, string name, string dept, int hourlySalary, IFinanceTeam team) : base(id, name, dept, team)
        {
            this.HourlySalary = hourlySalary;
        }

        public void GetBenifit()
        {
            throw new NotImplementedException();
        }
    }
}

