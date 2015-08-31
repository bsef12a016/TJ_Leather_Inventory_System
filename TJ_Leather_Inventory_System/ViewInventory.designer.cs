namespace GUI_Test_4
{
    partial class ViewInventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_tjDataSet = new GUI_Test_4.db_tjDataSet();
            this.tblItemsBindingSource = new System.Windows.Forms.BindingSource();
            this.tblItemsTableAdapter = new GUI_Test_4.db_tjDataSetTableAdapters.tblItemsTableAdapter();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemuomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemretailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemparentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemgroupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemconditionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemstatusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemmanuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemlocationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemShelfidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itembinidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemclassidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtaxableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemserializedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iteminventoryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemactiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itempoapprovedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finyearidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_tjDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemidDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.itemcodeDataGridViewTextBoxColumn,
            this.itemuomidDataGridViewTextBoxColumn,
            this.itemdescDataGridViewTextBoxColumn,
            this.itemcostDataGridViewTextBoxColumn,
            this.itemretailDataGridViewTextBoxColumn,
            this.itemparentidDataGridViewTextBoxColumn,
            this.itemtypeidDataGridViewTextBoxColumn,
            this.itemgroupidDataGridViewTextBoxColumn,
            this.itemconditionidDataGridViewTextBoxColumn,
            this.itemstatusidDataGridViewTextBoxColumn,
            this.itemmanuidDataGridViewTextBoxColumn,
            this.itemlocationidDataGridViewTextBoxColumn,
            this.itemShelfidDataGridViewTextBoxColumn,
            this.itembinidDataGridViewTextBoxColumn,
            this.itemclassidDataGridViewTextBoxColumn,
            this.itemtaxableDataGridViewCheckBoxColumn,
            this.itemserializedDataGridViewCheckBoxColumn,
            this.iteminventoryDataGridViewCheckBoxColumn,
            this.itemactiveDataGridViewCheckBoxColumn,
            this.itempoapprovedDataGridViewCheckBoxColumn,
            this.finyearidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblItemsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // db_tjDataSet
            // 
            this.db_tjDataSet.DataSetName = "db_tjDataSet";
            this.db_tjDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblItemsBindingSource
            // 
            this.tblItemsBindingSource.DataMember = "tblItems";
            this.tblItemsBindingSource.DataSource = this.db_tjDataSet;
            // 
            // tblItemsTableAdapter
            // 
            this.tblItemsTableAdapter.ClearBeforeFill = true;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "item_id";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "item_name";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            // 
            // itemcodeDataGridViewTextBoxColumn
            // 
            this.itemcodeDataGridViewTextBoxColumn.DataPropertyName = "item_code";
            this.itemcodeDataGridViewTextBoxColumn.HeaderText = "item_code";
            this.itemcodeDataGridViewTextBoxColumn.Name = "itemcodeDataGridViewTextBoxColumn";
            // 
            // itemuomidDataGridViewTextBoxColumn
            // 
            this.itemuomidDataGridViewTextBoxColumn.DataPropertyName = "item_uom_id";
            this.itemuomidDataGridViewTextBoxColumn.HeaderText = "item_uom_id";
            this.itemuomidDataGridViewTextBoxColumn.Name = "itemuomidDataGridViewTextBoxColumn";
            // 
            // itemdescDataGridViewTextBoxColumn
            // 
            this.itemdescDataGridViewTextBoxColumn.DataPropertyName = "item_desc";
            this.itemdescDataGridViewTextBoxColumn.HeaderText = "item_desc";
            this.itemdescDataGridViewTextBoxColumn.Name = "itemdescDataGridViewTextBoxColumn";
            // 
            // itemcostDataGridViewTextBoxColumn
            // 
            this.itemcostDataGridViewTextBoxColumn.DataPropertyName = "item_cost";
            this.itemcostDataGridViewTextBoxColumn.HeaderText = "item_cost";
            this.itemcostDataGridViewTextBoxColumn.Name = "itemcostDataGridViewTextBoxColumn";
            // 
            // itemretailDataGridViewTextBoxColumn
            // 
            this.itemretailDataGridViewTextBoxColumn.DataPropertyName = "item_retail";
            this.itemretailDataGridViewTextBoxColumn.HeaderText = "item_retail";
            this.itemretailDataGridViewTextBoxColumn.Name = "itemretailDataGridViewTextBoxColumn";
            // 
            // itemparentidDataGridViewTextBoxColumn
            // 
            this.itemparentidDataGridViewTextBoxColumn.DataPropertyName = "item_parent_id";
            this.itemparentidDataGridViewTextBoxColumn.HeaderText = "item_parent_id";
            this.itemparentidDataGridViewTextBoxColumn.Name = "itemparentidDataGridViewTextBoxColumn";
            // 
            // itemtypeidDataGridViewTextBoxColumn
            // 
            this.itemtypeidDataGridViewTextBoxColumn.DataPropertyName = "item_type_id";
            this.itemtypeidDataGridViewTextBoxColumn.HeaderText = "item_type_id";
            this.itemtypeidDataGridViewTextBoxColumn.Name = "itemtypeidDataGridViewTextBoxColumn";
            // 
            // itemgroupidDataGridViewTextBoxColumn
            // 
            this.itemgroupidDataGridViewTextBoxColumn.DataPropertyName = "item_group_id";
            this.itemgroupidDataGridViewTextBoxColumn.HeaderText = "item_group_id";
            this.itemgroupidDataGridViewTextBoxColumn.Name = "itemgroupidDataGridViewTextBoxColumn";
            // 
            // itemconditionidDataGridViewTextBoxColumn
            // 
            this.itemconditionidDataGridViewTextBoxColumn.DataPropertyName = "item_condition_id";
            this.itemconditionidDataGridViewTextBoxColumn.HeaderText = "item_condition_id";
            this.itemconditionidDataGridViewTextBoxColumn.Name = "itemconditionidDataGridViewTextBoxColumn";
            // 
            // itemstatusidDataGridViewTextBoxColumn
            // 
            this.itemstatusidDataGridViewTextBoxColumn.DataPropertyName = "item_status_id";
            this.itemstatusidDataGridViewTextBoxColumn.HeaderText = "item_status_id";
            this.itemstatusidDataGridViewTextBoxColumn.Name = "itemstatusidDataGridViewTextBoxColumn";
            // 
            // itemmanuidDataGridViewTextBoxColumn
            // 
            this.itemmanuidDataGridViewTextBoxColumn.DataPropertyName = "item_manu_id";
            this.itemmanuidDataGridViewTextBoxColumn.HeaderText = "item_manu_id";
            this.itemmanuidDataGridViewTextBoxColumn.Name = "itemmanuidDataGridViewTextBoxColumn";
            // 
            // itemlocationidDataGridViewTextBoxColumn
            // 
            this.itemlocationidDataGridViewTextBoxColumn.DataPropertyName = "item_location_id";
            this.itemlocationidDataGridViewTextBoxColumn.HeaderText = "item_location_id";
            this.itemlocationidDataGridViewTextBoxColumn.Name = "itemlocationidDataGridViewTextBoxColumn";
            // 
            // itemShelfidDataGridViewTextBoxColumn
            // 
            this.itemShelfidDataGridViewTextBoxColumn.DataPropertyName = "item_Shelf_id";
            this.itemShelfidDataGridViewTextBoxColumn.HeaderText = "item_Shelf_id";
            this.itemShelfidDataGridViewTextBoxColumn.Name = "itemShelfidDataGridViewTextBoxColumn";
            // 
            // itembinidDataGridViewTextBoxColumn
            // 
            this.itembinidDataGridViewTextBoxColumn.DataPropertyName = "item_bin_id";
            this.itembinidDataGridViewTextBoxColumn.HeaderText = "item_bin_id";
            this.itembinidDataGridViewTextBoxColumn.Name = "itembinidDataGridViewTextBoxColumn";
            // 
            // itemclassidDataGridViewTextBoxColumn
            // 
            this.itemclassidDataGridViewTextBoxColumn.DataPropertyName = "item_class_id";
            this.itemclassidDataGridViewTextBoxColumn.HeaderText = "item_class_id";
            this.itemclassidDataGridViewTextBoxColumn.Name = "itemclassidDataGridViewTextBoxColumn";
            // 
            // itemtaxableDataGridViewCheckBoxColumn
            // 
            this.itemtaxableDataGridViewCheckBoxColumn.DataPropertyName = "item_taxable";
            this.itemtaxableDataGridViewCheckBoxColumn.HeaderText = "item_taxable";
            this.itemtaxableDataGridViewCheckBoxColumn.Name = "itemtaxableDataGridViewCheckBoxColumn";
            // 
            // itemserializedDataGridViewCheckBoxColumn
            // 
            this.itemserializedDataGridViewCheckBoxColumn.DataPropertyName = "item_serialized";
            this.itemserializedDataGridViewCheckBoxColumn.HeaderText = "item_serialized";
            this.itemserializedDataGridViewCheckBoxColumn.Name = "itemserializedDataGridViewCheckBoxColumn";
            // 
            // iteminventoryDataGridViewCheckBoxColumn
            // 
            this.iteminventoryDataGridViewCheckBoxColumn.DataPropertyName = "item_inventory";
            this.iteminventoryDataGridViewCheckBoxColumn.HeaderText = "item_inventory";
            this.iteminventoryDataGridViewCheckBoxColumn.Name = "iteminventoryDataGridViewCheckBoxColumn";
            // 
            // itemactiveDataGridViewCheckBoxColumn
            // 
            this.itemactiveDataGridViewCheckBoxColumn.DataPropertyName = "item_active";
            this.itemactiveDataGridViewCheckBoxColumn.HeaderText = "item_active";
            this.itemactiveDataGridViewCheckBoxColumn.Name = "itemactiveDataGridViewCheckBoxColumn";
            // 
            // itempoapprovedDataGridViewCheckBoxColumn
            // 
            this.itempoapprovedDataGridViewCheckBoxColumn.DataPropertyName = "item_po_approved";
            this.itempoapprovedDataGridViewCheckBoxColumn.HeaderText = "item_po_approved";
            this.itempoapprovedDataGridViewCheckBoxColumn.Name = "itempoapprovedDataGridViewCheckBoxColumn";
            // 
            // finyearidDataGridViewTextBoxColumn
            // 
            this.finyearidDataGridViewTextBoxColumn.DataPropertyName = "finyear_id";
            this.finyearidDataGridViewTextBoxColumn.HeaderText = "finyear_id";
            this.finyearidDataGridViewTextBoxColumn.Name = "finyearidDataGridViewTextBoxColumn";
            // 
            // ViewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewInventory";
            this.ShowIcon = false;
            this.Text = "ViewInventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_tjDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private db_tjDataSet db_tjDataSet;
        private System.Windows.Forms.BindingSource tblItemsBindingSource;
        private db_tjDataSetTableAdapters.tblItemsTableAdapter tblItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemuomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemretailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemparentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemtypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemgroupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemconditionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemstatusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemmanuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemlocationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemShelfidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itembinidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemclassidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemtaxableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemserializedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iteminventoryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemactiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itempoapprovedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finyearidDataGridViewTextBoxColumn;
    }
}