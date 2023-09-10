using FactoryMethodDesignPattern.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Services
{
    internal class EmpLevelOne : IEmpServices
    {
        public decimal GetBonusPercentsge()
        {
            return 10;
        }

        public decimal GetHourlyPay()
        {
            return 25;
        }
        public decimal GetTravelBudget()
        {
            return 200;
        }
    }
}
