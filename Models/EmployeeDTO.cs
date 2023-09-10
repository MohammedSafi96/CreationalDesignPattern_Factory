using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Models
{
    internal class EmployeeDTO
    {
        public int empLevel { get; set; }
        public decimal BonusPercentage { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal? TravelBudget { get; set; }
        public decimal? MedicalBudget { get; set; }
    }
}
