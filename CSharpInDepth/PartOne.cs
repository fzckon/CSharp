using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpInDepth.Model;

namespace CSharpInDepth
{
    public class PartOne
    {
        
        class ProductNameComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                var first = (Product)x; 
                var second = (Product)y;
                return first.Name.CompareTo(second.Name);
            }
        }

       
    }
}
