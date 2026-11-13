using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Data
{
    internal class AppDbContext
    {
        public Customer[] GetAllCustomers()
        {

            Customer customer1 = new()
            {
                Id = 1,
                FullName = "Ali Mammadov",
                Age = 25,
                Email = "ali@gmail.com",
                Address = "Baku, Azerbaijan"
            };

            Customer customer2 = new()
            {
                Id = 2,
                FullName = "Leyla Aliyeva",
                Age = 30,
                Email = "leyla@gmail.com",
                Address = "Ganja, Azerbaijan"
            };

            Customer customer3 = new()
            {
                Id = 3,
                FullName = "Murad Hasanov",
                Age = 22,
                Email = "murad@gmail.com",
                Address = "Sumgait, Azerbaijan"
            };

            Customer customer4 = new()
            {
                Id = 4,
                FullName = "Aysel Karimova",
                Age = 28,
                Email = "aysel@gmail.com",
                Address = "Shaki, Azerbaijan"
            };

            Customer customer5 = new()
            {
                Id = 5,
                FullName = "Nihad Huseynov",
                Age = 35,
                Email = "nihad@gmail.com",
                Address = "Lankaran, Azerbaijan"
            };
            return [customer1, customer2, customer3, customer4, customer5];

        }
    }

}

