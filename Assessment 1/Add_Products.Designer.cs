namespace Assessment_1
{
    partial class Add_Product
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_search = new System.Windows.Forms.TextBox();
            this.datagrid_CParts = new System.Windows.Forms.DataGridView();
            this.lbl_allCandidateParts = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.datagrid_Associated = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
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
            this.lbl_AssociatedParts = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_CParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Associated)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Products";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox_search
            // 
            this.txtBox_search.Location = new System.Drawing.Point(508, 34);
            this.txtBox_search.Name = "txtBox_search";
            this.txtBox_search.Size = new System.Drawing.Size(236, 23);
            this.txtBox_search.TabIndex = 2;
            // 
            // datagrid_CParts
            // 
            this.datagrid_CParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_CParts.Location = new System.Drawing.Point(294, 75);
            this.datagrid_CParts.Name = "datagrid_CParts";
            this.datagrid_CParts.RowTemplate.Height = 25;
            this.datagrid_CParts.Size = new System.Drawing.Size(450, 141);
            this.datagrid_CParts.TabIndex = 3;
            this.datagrid_CParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CParts_CellClick);
            // 
            // lbl_allCandidateParts
            // 
            this.lbl_allCandidateParts.AutoSize = true;
            this.lbl_allCandidateParts.Location = new System.Drawing.Point(294, 57);
            this.lbl_allCandidateParts.Name = "lbl_allCandidateParts";
            this.lbl_allCandidateParts.Size = new System.Drawing.Size(107, 15);
            this.lbl_allCandidateParts.TabIndex = 4;
            this.lbl_allCandidateParts.Text = "All Candidate Parts";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(692, 222);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(52, 23);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // datagrid_Associated
            // 
            this.datagrid_Associated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Associated.Location = new System.Drawing.Point(291, 251);
            this.datagrid_Associated.Name = "datagrid_Associated";
            this.datagrid_Associated.RowTemplate.Height = 25;
            this.datagrid_Associated.Size = new System.Drawing.Size(453, 141);
            this.datagrid_Associated.TabIndex = 6;
            this.datagrid_Associated.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Associated_CellClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(692, 398);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(52, 23);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(634, 428);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(52, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(692, 428);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(52, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(29, 170);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 15);
            this.lbl_ID.TabIndex = 10;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(29, 199);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(39, 15);
            this.lbl_Name.TabIndex = 11;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Location = new System.Drawing.Point(29, 226);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(57, 15);
            this.lbl_Inventory.TabIndex = 12;
            this.lbl_Inventory.Text = "Inventory";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(29, 251);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(33, 15);
            this.lbl_Price.TabIndex = 13;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Max
            // 
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Location = new System.Drawing.Point(22, 277);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(30, 15);
            this.lbl_Max.TabIndex = 14;
            this.lbl_Max.Text = "Max";
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.Location = new System.Drawing.Point(164, 280);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(28, 15);
            this.lbl_Min.TabIndex = 15;
            this.lbl_Min.Text = "Min";
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Location = new System.Drawing.Point(92, 162);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.Size = new System.Drawing.Size(100, 23);
            this.txtbox_ID.TabIndex = 16;
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(92, 191);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(100, 23);
            this.txtbox_Name.TabIndex = 17;
            // 
            // txtbox_Inventory
            // 
            this.txtbox_Inventory.Location = new System.Drawing.Point(92, 219);
            this.txtbox_Inventory.Name = "txtbox_Inventory";
            this.txtbox_Inventory.Size = new System.Drawing.Size(100, 23);
            this.txtbox_Inventory.TabIndex = 18;
            // 
            // txtbox_Price
            // 
            this.txtbox_Price.Location = new System.Drawing.Point(92, 248);
            this.txtbox_Price.Name = "txtbox_Price";
            this.txtbox_Price.Size = new System.Drawing.Size(100, 23);
            this.txtbox_Price.TabIndex = 19;
            // 
            // txtbox_Max
            // 
            this.txtbox_Max.Location = new System.Drawing.Point(58, 277);
            this.txtbox_Max.Name = "txtbox_Max";
            this.txtbox_Max.Size = new System.Drawing.Size(100, 23);
            this.txtbox_Max.TabIndex = 20;
            // 
            // txtbox_Min
            // 
            this.txtbox_Min.Location = new System.Drawing.Point(198, 277);
            this.txtbox_Min.Name = "txtbox_Min";
            this.txtbox_Min.Size = new System.Drawing.Size(87, 23);
            this.txtbox_Min.TabIndex = 21;
            // 
            // lbl_AssociatedParts
            // 
            this.lbl_AssociatedParts.AutoSize = true;
            this.lbl_AssociatedParts.Location = new System.Drawing.Point(294, 233);
            this.lbl_AssociatedParts.Name = "lbl_AssociatedParts";
            this.lbl_AssociatedParts.Size = new System.Drawing.Size(164, 15);
            this.lbl_AssociatedParts.TabIndex = 22;
            this.lbl_AssociatedParts.Text = "Parts Associated with Product";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(105, 100);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 15);
            this.lbl_Error.TabIndex = 23;
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 463);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.lbl_AssociatedParts);
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
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.datagrid_Associated);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_allCandidateParts);
            this.Controls.Add(this.datagrid_CParts);
            this.Controls.Add(this.txtBox_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Add_Product";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_CParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Associated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtBox_search;
        private DataGridView datagrid_CParts;
        private Label lbl_allCandidateParts;
        private Button btn_Add;
        private DataGridView datagrid_Associated;
        private Button btn_Delete;
        private Button btn_Save;
        private Button btn_Cancel;
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
        private Label lbl_AssociatedParts;
        private Label lbl_Error;
    }
}