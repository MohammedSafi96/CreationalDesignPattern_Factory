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
    internal class EmpLevelTwoFactory : BaseEmpServiceFactory
    {
        public EmpLevelTwoFactory(EmployeeDTO emp) : base(emp)
        {
        }

        public override IEmpServices Create()
        {
            EmpLevelTwo empLevelTwo = new EmpLevelTwo();
            emp.MedicalBudget =  empLevelTwo.GetMedicalBudget();
            return empLevelTwo;
        }
    }
}
