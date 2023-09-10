using FactoryMethodDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Factory.FactoryMethod
{
    internal class EmpServiceFactory
    {
        public BaseEmpServiceFactory CreateFactory(EmployeeDTO emp)
        {
            BaseEmpServiceFactory factory = null;
            if (emp.empLevel == 1)
            {
                factory = new EmpLevelOneFactory(emp);
            }
            else if (emp.empLevel == 2)
            {
                factory = new EmpLevelTwoFactory(emp);
            }
            else
            {
                Console.WriteLine("the entered level is ont found!");
            }
            return factory;
        }
    }
}
