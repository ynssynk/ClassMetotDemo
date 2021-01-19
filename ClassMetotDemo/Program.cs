using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[]
            {
                new Customer
                {
                    Id = 1, FirstName = "Ahmet", LastName = "Yılmaz", Address = "2.nci sokak birinci ev",
                    City = "istanbul", PhoneNumber = "05124554592", DateOfRegister = DateTime.Now
                },
                new Customer
                {
                    Id = 2, FirstName = "Deniz", LastName = "Kaynar", Address = "100.YIL BULVARI ", City = "Ankara",
                    PhoneNumber = "0565789577", DateOfRegister = DateTime.Now
                },
                new Customer
                {
                    Id = 3, FirstName = "Yakup", LastName = "Kaçmaz", Address = "ALINTERİ BUL N 216", City = "Samsun",
                    PhoneNumber = "05245695567", DateOfRegister = DateTime.Now
                },
                new Customer
                {
                    Id = 4, FirstName = "Ali", LastName = "Ozan", Address = " DORUK ÇRŞ NO 143 ", City = "Bursa",
                    PhoneNumber = "05102569242", DateOfRegister = DateTime.Now
                },
                new Customer
                {
                    Id = 5, FirstName = "Asu", LastName = "Lem", Address = "BUTTİM İŞ MERKEZİ D BLOK",
                    City = "istanbul",
                    PhoneNumber = "05123548587", DateOfRegister = DateTime.Now
                }
            };

            customerManager.Add(customers[0]);
            customerManager.Update(customers[1]);
            customerManager.Delete(customers[4]);
            customerManager.GetAll(customers);

        }

    }



}

