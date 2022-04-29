using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class DependencyResolver
    {
        public static object GetInstance(string type)
        {
            switch (type)
            {
                case "IFinanceTeam":
                    {
                        return new FinanceTeam();
                    }
            }
            return null;
        }
    }
}
