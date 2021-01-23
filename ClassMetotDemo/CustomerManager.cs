
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Create(Customer customer)
        {
            Console.WriteLine($"{customer.Name} Created");
        }
        public void ReadInfo(Customer customer)
        {
            Console.WriteLine($"---> \n{customer.Id}\n{customer.Name}\n{customer.Surname}\n{customer.Birthday}\n{customer.Address}\n==============================");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine($"---> \n{customer.Id}\n{customer.Name}\n{customer.Surname}\n{customer.Birthday}\n{customer.Address}\n==============================");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.Name} Deleted");
        }
    }
}