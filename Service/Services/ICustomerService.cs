using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface ICustomerService 
    {
        public Customer[] GetAge();
        public Customer[] GetCustomers();
        public double GetAverageAge();
        public Customer[] SearchByFullName(string searchText);
        public Customer[] GetById(int searchId);
        public Customer[] SortByAge(string input);
    }
}
