using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInDepth.Model
{
    public class Product
    {
        public Product(string Name, decimal Price, int SupplierID)
        {
            this.Name = Name;
            this.Price = Price;
            this.SupplierID = SupplierID;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SupplierID { get; set; }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product (Name:"West Side Story",Price:9.99m ,SupplierID:1),
                new Product (Name:"Assassins",Price:14.99m ,SupplierID:2),
                new Product (Name:"Frogs",Price:13.99m ,SupplierID:1),
                new Product (Name:"Sweeney Todd",Price:10.99m,SupplierID:3 ),
            };
        }
    }
}
