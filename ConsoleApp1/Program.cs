using ConsoleApp1.Controllers;
using Service.Services;

CustomerController customerController = new(new CustomerService());