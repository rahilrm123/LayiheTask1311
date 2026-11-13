using Service.Data;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class CustomerService :ICustomerService
    {
        private readonly AppDbContext _context;
        private readonly Customer[] _customer;
        public CustomerService()
        {
            _context = new AppDbContext();
            _customer = _context.GetAllCustomers();
        }
        #region Task1
        public Customer[] GetAge()
        {
            
            return _customer;
        }
        #endregion
        #region Task2
        public Customer[] GetCustomers()
        {
            return _customer;
        }
        #endregion
        #region Task3
        public double GetAverageAge()
        {
            return _customer.Average(a => a.Age);
        }
        #endregion
        #region Task4
        public Customer[] SearchByFullName(string searchText)
        {
            return _customer.Where(a => a.FullName.Trim().ToLower() == searchText.Trim().ToLower()).ToArray();
        }
        #endregion
        #region Task5
        public Customer[] GetById(int searchId)
        {
            return _customer.Where(a => a.Id == searchId).ToArray();
        }
        #endregion
        #region Task6
        public Customer[] SortByAge(string input)
        {
        input: switch (input)
            {
                case "asc":
                    return _customer.OrderBy(a => a.Age).ToArray();
                case "desc":
                    return _customer.OrderBy(a => a.Age).ToArray();
                default:
                    Console.WriteLine("Enter asc or desc");
                    goto input;
            }
        }
        #endregion
        #region Task7
        public Customer[] GetByAddress()
        {
            return _customer;
        }
        #endregion
    }
}
