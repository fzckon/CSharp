using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInDepth.Model
{
    public class Supplier
    {
        public Supplier(string Name, int SupplierID)
        {
            this.Name = Name;
            this.SupplierID = SupplierID;
        }

        public string Name { get; set; }
        public int SupplierID { get; set; }

        public static List<Supplier> GetSampleSuppliers()
        {
            return new List<Supplier>
            {
                new Supplier (Name:"Solely Snodheim",SupplierID:1 ),
                new Supplier (Name:"CD-by-CD-by-Sondheim",SupplierID:2 ),
                new Supplier (Name:"Barbershop CDs",SupplierID:3 )
            };
        }
    }
}
