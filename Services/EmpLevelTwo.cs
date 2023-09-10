using FactoryMethodDesignPattern.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Services
{
    internal class EmpLevelTwo : IEmpServices
    {
        public decimal GetBonusPercentsge()
        {
            return 5;
        }
        public decimal GetHourlyPay()
        {
            return 15;
        }
        public decimal GetMedicalBudget()
        {
            return 500;
        }
    }
}
