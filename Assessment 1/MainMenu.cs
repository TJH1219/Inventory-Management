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
    public partial class MainMenu : Form
    {
        private bool search;
        private BindingList<backend.Part> partsearch;
        private BindingList<backend.Product> productsearch;
        private int partindex;
        private int productindex;
        public static backend.inventory Inventory;
        public MainMenu()
        {
            InitializeComponent();
            this.search = false;
            Inventory = new backend.inventory();
            dataview_Parts.DataSource = Inventory.Parts;
            datagrid_Products.DataSource = Inventory.Products;
            this.partindex = 0;
            this.productindex = 0;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_PartAdd_Click(object sender, EventArgs e)
        {
            Form form = new Add_Part();
            form.ShowDialog();
        }

        private void btn_ProductAdd_Click(object sender, EventArgs e)
        {
            Form form = new Add_Product();
            form.ShowDialog();
        }

        private void btn_PartDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.deletePart(this.partindex);
            }
            catch (ArgumentOutOfRangeException)
            {
                lbl_Error.Text = "Argument out of range.";
            }
        }

        private void dataview_Parts_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            this.partindex = e.RowIndex;
        }

        private void btn_ProductModify_Click(object sender, EventArgs e)
        {
            backend.Product product;
            Form form;
            if (this.search == true)
            {
                product = this.productsearch[this.productindex];
                form = new Modify_Profuct(product, this.productindex);
            }
            else
            {
                product = Inventory.Products[this.productindex];
                form = new Modify_Profuct(product, this.productindex);
            }
            form.ShowDialog();
        }

        private void btn_ProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.removeProduct(this.productindex);
            }
            catch (ArgumentOutOfRangeException)
            {
                lbl_Error.Text = "Argument out of range.";
            }
        }

        private void datagrid_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.productindex = e.RowIndex;
        }

        private void btn_PartModify_Click(object sender, EventArgs e)
        {
            Form form;
            if (this.search == true)
            {
                form = new Modify_Part(this.partsearch[this.productindex], this.partindex);
            }
            else
            {
                form = new Modify_Part(Inventory.Parts[this.partindex], this.partindex);
            }
            form.ShowDialog();
        }

        private void btn_PartsSearch_Click(object sender, EventArgs e)
        {
            string search = txtbox_PartSearch.Text;
            for (int i = 0; i < Inventory.Parts.Count; i++)
            {
                if (Inventory.Parts[i].Name.ToLower() == search.ToLower())
                {
                    BindingList<backend.Part> part = new BindingList<backend.Part>();
                    part.Add(Inventory.Parts[i]);
                    this.dataview_Parts.DataSource = part;
                    this.partsearch = part;
                    this.search = true;
                }
                else if (search == "")
                {
                    this.search = false;
                    this.dataview_Parts.DataSource = Inventory.Parts;
                }
            }
        }

        private void btn_ProductSearch_Click(object sender, EventArgs e)
        {
            string search = txtbox_ProductSearch.Text;
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (Inventory.Products[i].Name.ToLower() == search.ToLower())
                {
                    BindingList<backend.Product> product = new BindingList<backend.Product>();
                    product.Add(Inventory.Products[i]);
                    this.datagrid_Products.DataSource = product;
                    this.productsearch = product;
                    this.search = true;
                }
                else if (search == "")
                {
                    this.search = false;
                    this.datagrid_Products.DataSource = Inventory.Products;
                }
            }
        }
    }
}
