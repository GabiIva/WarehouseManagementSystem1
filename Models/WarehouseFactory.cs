using System;
using WarehouseManagementSystem.Models;

namespace Õ¿œ»ÿ»_“” _—⁄Ÿ»ﬂ_NAMESPACE_Œ“_PRODUCT_CS
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