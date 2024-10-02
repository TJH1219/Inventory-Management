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
    public partial class Add_Part : Form
    {
        public Add_Part()
        {
            InitializeComponent();
            this.Set_ID();
        }

        private void rbtn_InHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_InHouse.Checked)
            {
                lbl_type.Text = "MachineID";
            }
        }

        private void rbtn_OutSourced_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_OutSourced.Checked)
            {
                lbl_type.Text = "Company Name";
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (rbtn_InHouse.Checked == true)
            {
                int type = this.Convert_Inhouse();
                if (type == -1) 
                { 
                    lbl_Error.Text = "MachineID must be an integer";
                    return;
                }
                var id = this.Convert_ID();
                if (id == -1)
                {
                    lbl_Error.Text = "id must be an integer";
                    return;
                }
                var name = txtbox_Name.Text;
                var Price = this.Convert_Price();
                if (Price == -1)
                {
                    lbl_Error.Text = "Price must be an integer";
                    return;
                }
                var inventory = this.Convert_Inventory();
                if (inventory == -1)
                {
                    lbl_Error.Text = "Inventory must be an integer";
                    return;
                }
                var min = this.Convert_Min();
                if (min == -1)
                {
                    lbl_Error.Text = "min must be an integer";
                    return;
                }
                var max = this.Convert_Max();
                if (max == -1)
                {
                    lbl_Error.Text = "MachineID must be an integer";
                    return;
                }
                backend.inHouse newpart = new backend.inHouse(type, id, name, Price, inventory, min, max);
                MainMenu.Inventory.Parts.Add(newpart);
                this.Close();
            }
            else
            {
                var type = txtbox_type.Text;
                var id = this.Convert_ID();
                if (id == -1)
                {
                    lbl_Error.Text = "id must be an integer";
                    return;
                }
                var name = txtbox_Name.Text;
                var Price = this.Convert_Price();
                if (Price == -1)
                {
                    lbl_Error.Text = "Price must be an integer";
                    return;
                }
                var inventory = this.Convert_Inventory();
                if (inventory == -1)
                {
                    lbl_Error.Text = "Inventory must be an integer";
                    return;
                }
                var min = this.Convert_Min();
                if (min == -1)
                {
                    lbl_Error.Text = "min must be an integer";
                    return;
                }
                var max = this.Convert_Max();
                if (max == -1)
                {
                    lbl_Error.Text = "MachineID must be an integer";
                    return;
                }
                backend.outsourced newpart = new backend.outsourced(type, id, name, Price, inventory, min, max);
                MainMenu.Inventory.Parts.Add(newpart);
                this.Close();
            }
        }
        private int Convert_Inhouse()
        {
            int type;
            try
            {
                type = Convert.ToInt32(txtbox_type.Text);
            }
            catch (System.FormatException)
            {
                type = -1;
            }
            return type;
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

        private void Add_Part_Load(object sender, EventArgs e)
        {

        }

        private void Set_ID()
        {
            int index = MainMenu.Inventory.Parts.Count();
            int id = MainMenu.Inventory.Parts[index - 1].PartID;
            this.txtbox_ID.Text = Convert.ToString(id);
            id += 1;
            this.txtbox_ID.ReadOnly = true;
        }
    }
}
