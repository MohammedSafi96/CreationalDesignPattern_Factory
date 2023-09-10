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
    internal class EmpLevelOneFactory : BaseEmpServiceFactory
    {
        public EmpLevelOneFactory(EmployeeDTO emp) : base(emp)
        {
        }

        public override IEmpServices Create()
        {
            EmpLevelOne empLevelOne = new EmpLevelOne();
            emp.TravelBudget = empLevelOne.GetTravelBudget();
            return empLevelOne;
        }
    }
}
