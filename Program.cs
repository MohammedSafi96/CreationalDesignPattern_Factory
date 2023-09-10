

using FactoryMethodDesignPattern.Factory.FactoryMethod;
using FactoryMethodDesignPattern.IServices;
using FactoryMethodDesignPattern.Models;
// Ask the factory to get Emp details based on client input (emp level) 
// so the factory will create an istance from the target service 

// Simple Factory //
IEmpServices client1 = new FactoryMethodDesignPattern.Factory.EmpServiceFactory().GetEmpDetails(1);
if (client1 is not null)
{
    Console.WriteLine($"Emp level 1 details => Bonus: {client1.GetBonusPercentsge()} | Hourly Pay: {client1.GetHourlyPay()}");
}

Console.WriteLine("-----------------------------------------------------------------");

// Factory Method //
EmployeeDTO emp = new EmployeeDTO()
{
    empLevel = 22,
};

BaseEmpServiceFactory empServiceFactory = new FactoryMethodDesignPattern.Factory.FactoryMethod.EmpServiceFactory().CreateFactory(emp);
if (empServiceFactory is not null)
{
    empServiceFactory.GetBenefits();
    Console.WriteLine($"Emp level {emp.empLevel} Details: ");
    Console.Write($"HourlyPay: {emp.HourlyPay}, ");
    Console.Write($"BonusPercentage: {emp.BonusPercentage}, ");
    Console.Write($"MedicalBudget: {emp.MedicalBudget}, ");
    Console.Write($"TravelBudget: {emp.TravelBudget} ");
}

Console.ReadLine();