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
    public partial class Modify_Profuct : Form
    {
        private bool search;
        private BindingList<backend.Part> searchlist;
        private BindingList<backend.Part> CandidateParts;
        private int aindex;
        private int cindex;
        private int productindex;
        private BindingList<backend.Part> AssociatedParts;
        public Modify_Profuct(backend.Product product, int ProductIndex)
        {
            InitializeComponent();
            this.search = false;
            this.AssociatedParts = new BindingList<backend.Part>();
            for (int i = 0; i < product.AssociatedParts.Count; i++)
            {
                AssociatedParts.Add(product.AssociatedParts[i]);
            }
            this.CandidateParts = MainMenu.Inventory.Parts;
            datagrid_Candidate.DataSource = this.CandidateParts;
            datagrid_Parts.DataSource = this.AssociatedParts;
            this.productindex = ProductIndex;
            this.aindex = 0;
            this.cindex = 0;
            this.txtbox_ID.Text = Convert.ToString(product.ProductID);
            this.txtbox_Name.Text = product.Name;
            this.txtbox_Inventory.Text = Convert.ToString(product.inStock);
            this.txtbox_Price.Text = Convert.ToString(product.Price);
            this.txtbox_Min.Text = Convert.ToString(product.Min);
            this.txtbox_Max.Text = Convert.ToString(product.Max);
            this.txtbox_ID.ReadOnly = true;
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
                id,name,price,instock,min,max);
            MainMenu.Inventory.updateProducts(this.productindex, product);
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (this.search == true)
            {
                this.AssociatedParts.Add(this.searchlist[this.cindex]);
            }
            else
            {
                this.AssociatedParts.Add(MainMenu.Inventory.Parts[this.cindex]);
            }
        }

        private void datagrid_Candidate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cindex = e.RowIndex;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datagrid_Parts_CellClick(object sender, DataGridViewCellEventArgs e)
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
            catch (ArgumentOutOfRangeException)
            {
                lbl_Error.Text = "Nothing to delete.";
            }
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
                    BindingList<backend.Part> part = new BindingList<backend.Part>();
                    part.Add(MainMenu.Inventory.Parts[i]);
                    this.datagrid_Candidate.DataSource = part;
                    this.searchlist = part;
                    this.search = true;
                }
                else if (search == "")
                {
                    this.search = false;
                    this.datagrid_Candidate.DataSource = MainMenu.Inventory.Parts;
                }
            }
        }


    }
}
