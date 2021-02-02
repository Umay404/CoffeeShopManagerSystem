using CoffeeShopManagerSystem.Abstract;
using CoffeeShopManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopManagerSystem.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
