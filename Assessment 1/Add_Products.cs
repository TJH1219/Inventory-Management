using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assessment_1
{
    public partial class Add_Product : Form
    {
        private bool search;
        private int cindex;
        private int aindex;
        private BindingList<backend.Part> SearchList;
        private BindingList<backend.Part> AssociatedParts;
        public Add_Product()
        {
            InitializeComponent();
            this.AssociatedParts = new BindingList<backend.Part>();
            this.datagrid_CParts.DataSource = MainMenu.Inventory.Parts;
            this.datagrid_Associated.DataSource = this.AssociatedParts;
            this.SearchList = new BindingList<backend.Part>();
            this.cindex = 0;
            this.aindex = 0;
            this.search = false;
            this.Set_ID();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var id = this.Convert_ID();
            var name = txtbox_Name.Text;
            var price = this.Convert_Price();
            var instock = this.Convert_Inventory();
            var min = this.Convert_Min();
            var max = this.Convert_Max();
            backend.Product product = new backend.Product(this.AssociatedParts,
                id, name, price, instock, min, max);
            MainMenu.Inventory.addProduct(product);
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (this.search == true)
            {
                this.AssociatedParts.Add(this.SearchList[this.cindex]);
            }
            else
            {
                this.AssociatedParts.Add(MainMenu.Inventory.Parts[this.cindex]);
            }
            
        }

        private void datagrid_CParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cindex = e.RowIndex;
        }

        private void datagrid_Associated_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.aindex = e.RowIndex;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                backend.Part part = this.AssociatedParts[aindex];
                this.AssociatedParts.Remove(part);
            }
            catch(ArgumentOutOfRangeException)
            {
                lbl_Error.Text = "Nothing to delete.";
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int Convert_ID()
        {
            int id;
            try
            {
                id = Convert.ToInt32(txtbox_ID.Text);
            }
            catch (System.FormatException)
            {
                id = -1;
            }
            return id;
        }
        private decimal Convert_Price()
        {
            decimal Price;
            try
            {
                Price = Convert.ToDecimal(txtbox_Price.Text);
            }
            catch (System.FormatException)
            {
                Price = -1;
            }
            return Price;
        }
        private int Convert_Inventory()
        {
            int Inv;
            try
            {
                Inv = Convert.ToInt32(txtbox_Inventory.Text);
            }
            catch (System.FormatException)
            {
                Inv = -1;
            }
            return Inv;
        }
        private int Convert_Min()
        {
            int Min;
            try
            {
                Min = Convert.ToInt32(txtbox_Min.Text);
            }
            catch (System.FormatException)
            {
                Min = -1;
            }
            return Min;
        }
        private int Convert_Max()
        {
            int Max;
            try
            {
                Max = Convert.ToInt32(txtbox_Max.Text);
            }
            catch (System.FormatException)
            {
                Max = -1;
            }
            return Max;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = txtBox_search.Text;
            for (int i = 0; i < MainMenu.Inventory.Parts.Count; i++)
            {
                if (MainMenu.Inventory.Parts[i].Name.ToLower() == search.ToLower())
                {
                    this.search = true;
                    this.SearchList.Add(MainMenu.Inventory.Parts[i]);
                    this.datagrid_CParts.DataSource = this.SearchList;

                }
                else if (search == "")
                {
                    this.search = false;
                    this.datagrid_CParts.DataSource = MainMenu.Inventory.Parts;
                }
            }
        }
        
        private void Set_ID()
        {
            int index = MainMenu.Inventory.Products.Count();
            int id = MainMenu.Inventory.Products[index - 1].ProductID;
            id += 1;
            this.txtbox_ID.Text = Convert.ToString(id);
            this.txtbox_ID.ReadOnly = true;
        }
    }
}
