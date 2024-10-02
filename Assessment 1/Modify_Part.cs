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
    public partial class Modify_Part : Form
    {
        private backend.Part part;
        private int partindex;
        public Modify_Part(backend.Part part, int index)
        {
            InitializeComponent();
            this.part = part;
            this.partindex = index;
            this.txtbox_ID.Text = Convert.ToString(part.PartID);
            this.txtbox_Name.Text = part.Name;
            this.txtbox_Inventory.Text = Convert.ToString(part.Instock);
            this.txtbox_Price.Text = Convert.ToString(part.Price);
            this.txtbox_Min.Text = Convert.ToString(part.Min);
            this.txtbox_Max.Text = Convert.ToString(part.Max);
            this.txtbox_ID.ReadOnly = true;
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
                MainMenu.Inventory.updatePart(this.partindex, newpart);
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
                MainMenu.Inventory.updatePart(this.partindex, newpart);
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
