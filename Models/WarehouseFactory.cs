using System;
using WarehouseManagementSystem.Models;

namespace WarehouseManagementSystem.Models
{
    abstract class WarehouseCreator
    {
        public abstract WarehouseComponent FactoryMethod(string name);
    }

    class ProductCreator : WarehouseCreator
    {
        public override WarehouseComponent FactoryMethod(string name)
        {
            return new Product(name, 0m, 0, false);
        }
    }

    class CategoryCreator : WarehouseCreator
    {
        public override WarehouseComponent FactoryMethod(string name)
        {
            return new Category(name);
        }
    }
}
