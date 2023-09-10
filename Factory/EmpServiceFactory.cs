using FactoryMethodDesignPattern.IServices;
using FactoryMethodDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Factory
{
    internal class EmpServiceFactory
    {
        public IEmpServices GetEmpDetails(int empLevel)
        {
            IEmpServices empServices = null;
            // the factory will decide which instance should initiate depends on the client input
            if (empLevel == 1)
            {
                empServices = new EmpLevelOne();
            }
            else if (empLevel == 2)
            {
                empServices = new EmpLevelTwo();
            }
            else
            {
                Console.WriteLine("the entered level is ont found!");
            }
            return empServices;
        }
    }
}
