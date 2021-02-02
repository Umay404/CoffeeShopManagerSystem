using CoffeeShopManagerSystem.Abstract;
using CoffeeShopManagerSystem.Adapters;
using CoffeeShopManagerSystem.Concrete;
using CoffeeShopManagerSystem.Entities;
using System;

namespace CoffeeShopManagerSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {
                DateOfBirth=new DateTime(1994,01,01),
                FirstName="Umay Serap",
                LastName="KOÇ",
                NationalityId= "92540780870"});
            Console.ReadLine();
        }
    }
}
