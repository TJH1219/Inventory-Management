namespace Assessment_1
{
    partial class Add_Part
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_AddPart = new System.Windows.Forms.Label();
            this.rbtn_InHouse = new System.Windows.Forms.RadioButton();
            this.rbtn_OutSourced = new System.Windows.Forms.RadioButton();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Inventory = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Max = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_Inventory = new System.Windows.Forms.TextBox();
            this.txtbox_Price = new System.Windows.Forms.TextBox();
            this.txtbox_Max = new System.Windows.Forms.TextBox();
            this.txtbox_Min = new System.Windows.Forms.TextBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.txtbox_type = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_AddPart
            // 
            this.lbl_AddPart.AutoSize = true;
            this.lbl_AddPart.Location = new System.Drawing.Point(12, 9);
            this.lbl_AddPart.Name = "lbl_AddPart";
            this.lbl_AddPart.Size = new System.Drawing.Size(53, 15);
            this.lbl_AddPart.TabIndex = 0;
            this.lbl_AddPart.Text = "Add Part";
            // 
            // rbtn_InHouse
            // 
            this.rbtn_InHouse.AutoSize = true;
            this.rbtn_InHouse.Checked = true;
            this.rbtn_InHouse.Location = new System.Drawing.Point(88, 7);
            this.rbtn_InHouse.Name = "rbtn_InHouse";
            this.rbtn_InHouse.Size = new System.Drawing.Size(70, 19);
            this.rbtn_InHouse.TabIndex = 1;
            this.rbtn_InHouse.TabStop = true;
            this.rbtn_InHouse.Text = "In house";
            this.rbtn_InHouse.UseVisualStyleBackColor = true;
            this.rbtn_InHouse.CheckedChanged += new System.EventHandler(this.rbtn_InHouse_CheckedChanged);
            // 
            // rbtn_OutSourced
            // 
            this.rbtn_OutSourced.AutoSize = true;
            this.rbtn_OutSourced.Location = new System.Drawing.Point(197, 5);
            this.rbtn_OutSourced.Name = "rbtn_OutSourced";
            this.rbtn_OutSourced.Size = new System.Drawing.Size(91, 19);
            this.rbtn_OutSourced.TabIndex = 2;
            this.rbtn_OutSourced.Text = "Out Sourced";
            this.rbtn_OutSourced.UseVisualStyleBackColor = true;
            this.rbtn_OutSourced.CheckedChanged += new System.EventHandler(this.rbtn_OutSourced_CheckedChanged);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(88, 44);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 15);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(88, 75);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(39, 15);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Location = new System.Drawing.Point(88, 105);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(57, 15);
            this.lbl_Inventory.TabIndex = 5;
            this.lbl_Inventory.Text = "Inventory";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(88, 138);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(68, 15);
            this.lbl_Price.TabIndex = 6;
            this.lbl_Price.Text = "Price / Cost";
            // 
            // lbl_Max
            // 
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Location = new System.Drawing.Point(88, 174);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(30, 15);
            this.lbl_Max.TabIndex = 7;
            this.lbl_Max.Text = "Max";
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.Location = new System.Drawing.Point(218, 174);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(28, 15);
            this.lbl_Min.TabIndex = 8;
            this.lbl_Min.Text = "Min";
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Location = new System.Drawing.Point(112, 41);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.Size = new System.Drawing.Size(113, 23);
            this.txtbox_ID.TabIndex = 9;
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(133, 72);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(113, 23);
            this.txtbox_Name.TabIndex = 10;
            // 
            // txtbox_Inventory
            // 
            this.txtbox_Inventory.Location = new System.Drawing.Point(151, 102);
            this.txtbox_Inventory.Name = "txtbox_Inventory";
            this.txtbox_Inventory.Size = new System.Drawing.Size(113, 23);
            this.txtbox_Inventory.TabIndex = 11;
            // 
            // txtbox_Price
            // 
            this.txtbox_Price.Location = new System.Drawing.Point(162, 135);
            this.txtbox_Price.Name = "txtbox_Price";
            this.txtbox_Price.Size = new System.Drawing.Size(113, 23);
            this.txtbox_Price.TabIndex = 12;
            // 
            // txtbox_Max
            // 
            this.txtbox_Max.Location = new System.Drawing.Point(124, 174);
            this.txtbox_Max.Name = "txtbox_Max";
            this.txtbox_Max.Size = new System.Drawing.Size(75, 23);
            this.txtbox_Max.TabIndex = 13;
            // 
            // txtbox_Min
            // 
            this.txtbox_Min.Location = new System.Drawing.Point(252, 174);
            this.txtbox_Min.Name = "txtbox_Min";
            this.txtbox_Min.Size = new System.Drawing.Size(75, 23);
            this.txtbox_Min.TabIndex = 14;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(60, 212);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(67, 15);
            this.lbl_type.TabIndex = 15;
            this.lbl_type.Text = "Machine ID";
            // 
            // txtbox_type
            // 
            this.txtbox_type.Location = new System.Drawing.Point(161, 209);
            this.txtbox_type.Name = "txtbox_type";
            this.txtbox_type.Size = new System.Drawing.Size(103, 23);
            this.txtbox_type.TabIndex = 16;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(189, 250);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(278, 250);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 18;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(12, 261);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 15);
            this.lbl_Error.TabIndex = 19;
            // 
            // Add_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 285);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtbox_type);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.txtbox_Min);
            this.Controls.Add(this.txtbox_Max);
            this.Controls.Add(this.txtbox_Price);
            this.Controls.Add(this.txtbox_Inventory);
            this.Controls.Add(this.txtbox_Name);
            this.Controls.Add(this.txtbox_ID);
            this.Controls.Add(this.lbl_Min);
            this.Controls.Add(this.lbl_Max);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Inventory);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.rbtn_OutSourced);
            this.Controls.Add(this.rbtn_InHouse);
            this.Controls.Add(this.lbl_AddPart);
            this.Name = "Add_Part";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.Add_Part_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_AddPart;
        private RadioButton rbtn_InHouse;
        private RadioButton rbtn_OutSourced;
        private Label lbl_ID;
        private Label lbl_Name;
        private Label lbl_Inventory;
        private Label lbl_Price;
        private Label lbl_Max;
        private Label lbl_Min;
        private TextBox txtbox_ID;
        private TextBox txtbox_Name;
        private TextBox txtbox_Inventory;
        private TextBox txtbox_Price;
        private TextBox txtbox_Max;
        private TextBox txtbox_Min;
        private Label lbl_type;
        private TextBox txtbox_type;
        private Button btn_Save;
        private Button btn_Cancel;
        private Label lbl_Error;
    }
}