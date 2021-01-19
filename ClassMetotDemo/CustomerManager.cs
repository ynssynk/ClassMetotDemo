using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        
        public void GetAll(params Customer[] customers)
        {
            foreach (var customer in customers)
            {
                var result =
                    string.Format(
                        "Müşteri Adı: {0}\nMüşteri Soyadı: {1}\nŞehir: {2}\nAdres: {3}\nKayıt tarihi: {4}\n-*-*-*-*-*-*-",customer
                            .FirstName, customer.LastName, customer.City, customer.Address, customer.DateOfRegister);
                Console.WriteLine(result);
                
            }
        }
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi => {0}  {1}\n-----------",customer.FirstName,customer.LastName);
            
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri bilgileri güncellendi => {0}  {1}\n--------", customer.FirstName, customer.LastName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi => {0}  {1}\n----------", customer.FirstName, customer.LastName);
        }
    }
}
