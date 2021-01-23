using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();

            customer.Id = 1;
            customer.Name = "Harry";
            customer.Surname = "Potter";
            customer.Address = "Hogwarts School of Witchcraft and Wizardry";
            customer.Birthday = "31.07.1980";




            CustomerManager cmanager = new CustomerManager();
            cmanager.Create(customer);

            Console.WriteLine("create method checked\n==============================");

            cmanager.ReadInfo(customer);
            Console.WriteLine("read method checked\n==============================");


            customer.Id = 2;
            customer.Name = "Ronald";
            customer.Surname = "Weasley";
            customer.Address = "Shell Cottage";
            customer.Birthday = "01.05.1980";
            cmanager.Update(customer);
            Console.WriteLine("update method checked\n==============================");
            cmanager.Delete(customer);
            Console.WriteLine("delete method checked\n==============================");
        }
    }
}
