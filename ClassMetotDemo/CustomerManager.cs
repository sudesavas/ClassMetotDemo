using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.UserName + " : Kayıt oldu");
        }
    
        public void  Delete(Customer customer)
        {
            Console.WriteLine(customer.UserName + " : Kayıt silindi");
        }
        
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.UserName + ": Kayıt güncellendi");
        }
    
        public void List(Customer[] customers)
        {
            foreach(var customer in customers)
            {
                Console.WriteLine(customer.UserName);
                Console.WriteLine(customer.BirthYear);
                Console.WriteLine(customer.job);
                Console.WriteLine("----------------");
            }
            Console.WriteLine("Kayıtlar listelendi");
        }
    
    
    }
}
