using FactoryMethodDesignPattern.IServices;
using FactoryMethodDesignPattern.Models;
using FactoryMethodDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Factory.FactoryMethod
{
    internal abstract class BaseEmpServiceFactory
    {
        protected EmployeeDTO emp;
        public BaseEmpServiceFactory(EmployeeDTO emp)
        {
            this.emp = emp;
        }
        public EmployeeDTO GetBenefits()
        {
            IEmpServices manager = Create();
            emp.BonusPercentage = manager.GetBonusPercentsge();
            emp.HourlyPay = manager.GetHourlyPay();
            return emp;
        }
        public abstract IEmpServices Create();
    }
}
