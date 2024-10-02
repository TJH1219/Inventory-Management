namespace Assessment_1
{
    partial class MainMenu
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.dataview_Parts = new System.Windows.Forms.DataGridView();
            this.datagrid_Products = new System.Windows.Forms.DataGridView();
            this.btn_PartsSearch = new System.Windows.Forms.Button();
            this.btn_PartAdd = new System.Windows.Forms.Button();
            this.btn_PartModify = new System.Windows.Forms.Button();
            this.btn_PartDelete = new System.Windows.Forms.Button();
            this.txtbox_PartSearch = new System.Windows.Forms.TextBox();
            this.txtbox_ProductSearch = new System.Windows.Forms.TextBox();
            this.btn_ProductSearch = new System.Windows.Forms.Button();
            this.btn_ProductDelete = new System.Windows.Forms.Button();
            this.btn_ProductModify = new System.Windows.Forms.Button();
            this.btn_ProductAdd = new System.Windows.Forms.Button();
            this.lbl_Part = new System.Windows.Forms.Label();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.lbl_SearchHelpPart = new System.Windows.Forms.Label();
            this.lbl_SearchHelpProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_Parts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1029, 364);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dataview_Parts
            // 
            this.dataview_Parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview_Parts.Location = new System.Drawing.Point(31, 75);
            this.dataview_Parts.Name = "dataview_Parts";
            this.dataview_Parts.RowTemplate.Height = 25;
            this.dataview_Parts.Size = new System.Drawing.Size(513, 215);
            this.dataview_Parts.TabIndex = 1;
            this.dataview_Parts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataview_Parts_CellClick);
            // 
            // datagrid_Products
            // 
            this.datagrid_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Products.Location = new System.Drawing.Point(574, 75);
            this.datagrid_Products.Name = "datagrid_Products";
            this.datagrid_Products.RowTemplate.Height = 25;
            this.datagrid_Products.Size = new System.Drawing.Size(531, 215);
            this.datagrid_Products.TabIndex = 2;
            this.datagrid_Products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Products_CellClick);
            // 
            // btn_PartsSearch
            // 
            this.btn_PartsSearch.Location = new System.Drawing.Point(158, 30);
            this.btn_PartsSearch.Name = "btn_PartsSearch";
            this.btn_PartsSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_PartsSearch.TabIndex = 3;
            this.btn_PartsSearch.Text = "Search";
            this.btn_PartsSearch.UseVisualStyleBackColor = true;
            this.btn_PartsSearch.Click += new System.EventHandler(this.btn_PartsSearch_Click);
            // 
            // btn_PartAdd
            // 
            this.btn_PartAdd.Location = new System.Drawing.Point(358, 305);
            this.btn_PartAdd.Name = "btn_PartAdd";
            this.btn_PartAdd.Size = new System.Drawing.Size(58, 23);
            this.btn_PartAdd.TabIndex = 4;
            this.btn_PartAdd.Text = "Add";
            this.btn_PartAdd.UseVisualStyleBackColor = true;
            this.btn_PartAdd.Click += new System.EventHandler(this.btn_PartAdd_Click);
            // 
            // btn_PartModify
            // 
            this.btn_PartModify.Location = new System.Drawing.Point(422, 305);
            this.btn_PartModify.Name = "btn_PartModify";
            this.btn_PartModify.Size = new System.Drawing.Size(58, 23);
            this.btn_PartModify.TabIndex = 5;
            this.btn_PartModify.Text = "Modify";
            this.btn_PartModify.UseVisualStyleBackColor = true;
            this.btn_PartModify.Click += new System.EventHandler(this.btn_PartModify_Click);
            // 
            // btn_PartDelete
            // 
            this.btn_PartDelete.Location = new System.Drawing.Point(486, 305);
            this.btn_PartDelete.Name = "btn_PartDelete";
            this.btn_PartDelete.Size = new System.Drawing.Size(58, 23);
            this.btn_PartDelete.TabIndex = 6;
            this.btn_PartDelete.Text = "Delete";
            this.btn_PartDelete.UseVisualStyleBackColor = true;
            this.btn_PartDelete.Click += new System.EventHandler(this.btn_PartDelete_Click);
            // 
            // txtbox_PartSearch
            // 
            this.txtbox_PartSearch.Location = new System.Drawing.Point(248, 30);
            this.txtbox_PartSearch.Name = "txtbox_PartSearch";
            this.txtbox_PartSearch.Size = new System.Drawing.Size(164, 23);
            this.txtbox_PartSearch.TabIndex = 10;
            // 
            // txtbox_ProductSearch
            // 
            this.txtbox_ProductSearch.Location = new System.Drawing.Point(940, 30);
            this.txtbox_ProductSearch.Name = "txtbox_ProductSearch";
            this.txtbox_ProductSearch.Size = new System.Drawing.Size(164, 23);
            this.txtbox_ProductSearch.TabIndex = 12;
            // 
            // btn_ProductSearch
            // 
            this.btn_ProductSearch.Location = new System.Drawing.Point(850, 30);
            this.btn_ProductSearch.Name = "btn_ProductSearch";
            this.btn_ProductSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_ProductSearch.TabIndex = 11;
            this.btn_ProductSearch.Text = "Search";
            this.btn_ProductSearch.UseVisualStyleBackColor = true;
            this.btn_ProductSearch.Click += new System.EventHandler(this.btn_ProductSearch_Click);
            // 
            // btn_ProductDelete
            // 
            this.btn_ProductDelete.Location = new System.Drawing.Point(1047, 305);
            this.btn_ProductDelete.Name = "btn_ProductDelete";
            this.btn_ProductDelete.Size = new System.Drawing.Size(58, 23);
            this.btn_ProductDelete.TabIndex = 15;
            this.btn_ProductDelete.Text = "Delete";
            this.btn_ProductDelete.UseVisualStyleBackColor = true;
            this.btn_ProductDelete.Click += new System.EventHandler(this.btn_ProductDelete_Click);
            // 
            // btn_ProductModify
            // 
            this.btn_ProductModify.Location = new System.Drawing.Point(983, 305);
            this.btn_ProductModify.Name = "btn_ProductModify";
            this.btn_ProductModify.Size = new System.Drawing.Size(58, 23);
            this.btn_ProductModify.TabIndex = 14;
            this.btn_ProductModify.Text = "Modify";
            this.btn_ProductModify.UseVisualStyleBackColor = true;
            this.btn_ProductModify.Click += new System.EventHandler(this.btn_ProductModify_Click);
            // 
            // btn_ProductAdd
            // 
            this.btn_ProductAdd.Location = new System.Drawing.Point(919, 305);
            this.btn_ProductAdd.Name = "btn_ProductAdd";
            this.btn_ProductAdd.Size = new System.Drawing.Size(58, 23);
            this.btn_ProductAdd.TabIndex = 13;
            this.btn_ProductAdd.Text = "Add";
            this.btn_ProductAdd.UseVisualStyleBackColor = true;
            this.btn_ProductAdd.Click += new System.EventHandler(this.btn_ProductAdd_Click);
            // 
            // lbl_Part
            // 
            this.lbl_Part.AutoSize = true;
            this.lbl_Part.Location = new System.Drawing.Point(31, 57);
            this.lbl_Part.Name = "lbl_Part";
            this.lbl_Part.Size = new System.Drawing.Size(33, 15);
            this.lbl_Part.TabIndex = 16;
            this.lbl_Part.Text = "Parts";
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Location = new System.Drawing.Point(574, 57);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(49, 15);
            this.lbl_Product.TabIndex = 17;
            this.lbl_Product.Text = "Product";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(544, 346);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 15);
            this.lbl_Error.TabIndex = 18;
            // 
            // lbl_SearchHelpPart
            // 
            this.lbl_SearchHelpPart.AutoSize = true;
            this.lbl_SearchHelpPart.Location = new System.Drawing.Point(267, 9);
            this.lbl_SearchHelpPart.Name = "lbl_SearchHelpPart";
            this.lbl_SearchHelpPart.Size = new System.Drawing.Size(117, 15);
            this.lbl_SearchHelpPart.TabIndex = 19;
            this.lbl_SearchHelpPart.Text = "Please use the name.";
            // 
            // lbl_SearchHelpProduct
            // 
            this.lbl_SearchHelpProduct.AutoSize = true;
            this.lbl_SearchHelpProduct.Location = new System.Drawing.Point(954, 9);
            this.lbl_SearchHelpProduct.Name = "lbl_SearchHelpProduct";
            this.lbl_SearchHelpProduct.Size = new System.Drawing.Size(117, 15);
            this.lbl_SearchHelpProduct.TabIndex = 20;
            this.lbl_SearchHelpProduct.Text = "Please use the name.";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 407);
            this.Controls.Add(this.lbl_SearchHelpProduct);
            this.Controls.Add(this.lbl_SearchHelpPart);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.lbl_Part);
            this.Controls.Add(this.btn_ProductDelete);
            this.Controls.Add(this.btn_ProductModify);
            this.Controls.Add(this.btn_ProductAdd);
            this.Controls.Add(this.txtbox_ProductSearch);
            this.Controls.Add(this.btn_ProductSearch);
            this.Controls.Add(this.txtbox_PartSearch);
            this.Controls.Add(this.btn_PartDelete);
            this.Controls.Add(this.btn_PartModify);
            this.Controls.Add(this.btn_PartAdd);
            this.Controls.Add(this.btn_PartsSearch);
            this.Controls.Add(this.datagrid_Products);
            this.Controls.Add(this.dataview_Parts);
            this.Controls.Add(this.btn_Exit);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataview_Parts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Exit;
        private DataGridView dataview_Parts;
        private DataGridView datagrid_Products;
        private Button btn_PartsSearch;
        private Button btn_PartAdd;
        private Button btn_PartModify;
        private Button btn_PartDelete;
        private TextBox txtbox_PartSearch;
        private TextBox txtbox_ProductSearch;
        private Button btn_ProductSearch;
        private Button btn_ProductDelete;
        private Button btn_ProductModify;
        private Button btn_ProductAdd;
        private Label lbl_Part;
        private Label lbl_Product;
        private Label lbl_Error;
        private Label lbl_SearchHelpPart;
        private Label lbl_SearchHelpProduct;
    }
}