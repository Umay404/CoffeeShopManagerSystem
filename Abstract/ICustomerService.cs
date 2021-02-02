using CoffeeShopManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopManagerSystem.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
