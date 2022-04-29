using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IFinanceTeam
    {
        void CalculateSalary();
        void SendSalary();
        void TakeRequestFromEmployee();
    }
}
