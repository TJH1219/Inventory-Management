using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Assessment_1.backend
{
    public class Product
    {
        public BindingList<Part> AssociatedParts;
        public int ProductID {get; set;}
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int inStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public Product(BindingList<Part> associatedParts, int productID, string name, decimal price, int instock, int min, int max)
        {
            this.AssociatedParts = associatedParts;
            this.ProductID = productID;
            this.Name = name;
            this.Price = price;
            this.inStock = instock;
            this.Min = min;
            this.Max = max;
        }
        public void addAssociatedParts(Part part)
        { 
            // add parts
            this.AssociatedParts.Add(part);
        }
        public bool removeAssociatedParts(int part)        
        {
            // Gets the part from the binding list and then removes it
            Part to_remove = AssociatedParts[part];
            this.AssociatedParts.Remove(to_remove);
            return false;
        }
        public Part lookupAssociatedPart(int part)
        {
            //returns the associated part
            return this.AssociatedParts[part];
        }

    }
}
