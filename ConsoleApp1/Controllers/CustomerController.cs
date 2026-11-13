using System;
using System.Collections.Generic;
using System.Text;
using Service.Models;
using Service.Services;

namespace ConsoleApp1.Controllers
{
    public class CustomerController
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        #region Task1
        public void ExecuteGetAge()
        {
            var customers = _customerService.GetAge();
            foreach (var item in customers)
            {
                Console.WriteLine($"{item.FullName}:{item.Age}");
            }
        }
        #endregion
        #region Task2
        public void ExecuteGetCustomers()
        {
            var customers = _customerService.GetCustomers();
            foreach (var item in customers)
            {
                Console.WriteLine($"{item.Id}.{item.FullName},{item.Age},{item.Email},{item.Address}");
            }
        }
        #endregion
        #region Task3
        public void ExecuteGetAverageAge()
        {
            Console.WriteLine(_customerService.GetAverageAge());
        }
        #endregion
        #region Task4
        public void ExecuteSearchByFullName()
        {
            string searchText = Console.ReadLine();
            var customers = _customerService.SearchByFullName(searchText);
            foreach (var item in customers)
            {
                Console.WriteLine(item.FullName);
            }
        }
        #endregion
        #region Task5
        public void ExecuteGetById()
        {
            bool searchId = int.TryParse(Console.ReadLine(),out int searchId2);
            var customers = _customerService.GetById(searchId2);
            foreach (var item in customers)
            {
                Console.WriteLine(item.FullName);
            }
        }
        #endregion
        #region Task6
        public void ExecuteSortByAge()
        {
            string input = Console.ReadLine();
            var customers = _customerService.SortByAge(input);
            foreach (var item in customers)
            {
                Console.WriteLine(item.FullName);
            }
        }
        #endregion
    }
}
