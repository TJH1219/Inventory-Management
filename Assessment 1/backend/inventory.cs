using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Assessment_1.backend
{
    public class inventory
    {
        public BindingList<Product> Products;
        public BindingList<Part> Parts;

        public inventory()
        {
            this.Products = new BindingList<Product>();
            this.Parts = new BindingList<Part>();
            this.Parts.Add(new inHouse(001,0,"Wheel",10.99M,1000,1,10));
            this.Parts.Add(new outsourced("Bike Comp", 1, "Pedal", 2.99M, 1000, 1, 10));
            this.Parts.Add(new inHouse(002, 2, "Chain", 15.99M, 1000, 1, 10));
            this.Parts.Add(new inHouse(003, 3, "Seat", 5.99M, 1000, 1, 10));
            this.Products.Add(new Product(Parts, 0, "Red Bycycle", 11.44M, 15, 1, 25));
            this.Products.Add(new Product(Parts, 1, "Yellow Bycycle", 9.99M, 15, 1, 25));
            this.Products.Add(new Product(Parts, 2, "Blue Bycycle", 10.99M, 9, 1, 25));
        }

        public void addProduct(Product product)
        {
            //adds product
            this.Products.Add(product);
        }

        public bool removeProduct(int Place)
        {
               Product toremove = Products[Place];
               this.Products.Remove(toremove);
               return false;
        }

        public Product lookupProduct(int place)
        {
            return this.Products[place];
        }

        public void updateProducts(int place, Product product)
        {
            Product toremove = Products[place];
            this.Products.Remove(toremove);
            this.Products.Add(product);
            return;
        }

        public void addPart(Part part)
        {
            this.Parts.Add(part);
        }

        public bool deletePart(int index)
        {
            Part part = this.Parts[index];
            this.Parts.Remove(part);
            return true;
        }

        public Part lookupPart(int place)
        {
            return this.Parts[place];
        }

        public void updatePart(int place, Part part)
        {
            Part toremove = Parts[place];
            this.Parts.Remove(toremove);
            this.Parts.Add(part);
        }
    }
}
