using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1.backend
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Instock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Part(int PartId, string name, decimal price, int instock, int min, int max)
        {
            this.PartID = PartId;
            this.Name = name;
            this.Price = price;
            this.Instock = instock;
            this.Min = min;
            this.Max = max;
        }
    }

    public class inHouse : Part
    {
        int MachineID { get; set; }
        public inHouse(int machineID, int PartId, string name, decimal price, int instock, int min, int max) : base(PartId, name, price,instock,min,max)
        {
            this.MachineID = machineID;
        }
    }

    public class outsourced: Part
    {
        string CompanyName { get; set; }
        public outsourced(string companyName, int PartId, string name, decimal price, int instock, int min, int max) : base(PartId, name, price, instock, min, max)
        {
            CompanyName = companyName;
        }
    }
}
