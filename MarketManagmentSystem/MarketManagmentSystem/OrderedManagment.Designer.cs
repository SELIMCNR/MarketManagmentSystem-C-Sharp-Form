namespace MarketManagmentSystem
{
    partial class OrderedManagment
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
            this.components = new System.ComponentModel.Container();
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Order = new System.Windows.Forms.Button();
            this.Txt_Orderıd = new System.Windows.Forms.TextBox();
            this.Txt_Customer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Dat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_item = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Txt_Quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marketmanagmentsystemDataSet1 = new MarketManagmentSystem.MarketmanagmentsystemDataSet1();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ordermanagmentTableAdapter = new MarketManagmentSystem.MarketmanagmentsystemDataSet1TableAdapters.OrdermanagmentTableAdapter();
            this.marketmanagmentsystemDataSet2 = new MarketManagmentSystem.MarketmanagmentsystemDataSet2();
            this.ordermanagmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordermanagmentTableAdapter1 = new MarketManagmentSystem.MarketmanagmentsystemDataSet2TableAdapters.OrdermanagmentTableAdapter();
            this.ıtemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketmanagmentsystemDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketmanagmentsystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordermanagmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.Location = new System.Drawing.Point(292, 33);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Size = new System.Drawing.Size(100, 20);
            this.Txt_Phone.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Order);
            this.groupBox1.Controls.Add(this.Txt_Orderıd);
            this.groupBox1.Controls.Add(this.Txt_Customer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Dat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Phone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CustomerDetails";
            // 
            // Btn_Order
            // 
            this.Btn_Order.Location = new System.Drawing.Point(437, 30);
            this.Btn_Order.Name = "Btn_Order";
            this.Btn_Order.Size = new System.Drawing.Size(75, 23);
            this.Btn_Order.TabIndex = 3;
            this.Btn_Order.Text = "StartOrder";
            this.Btn_Order.UseVisualStyleBackColor = true;
            this.Btn_Order.Click += new System.EventHandler(this.Btn_Order_Click);
            // 
            // Txt_Orderıd
            // 
            this.Txt_Orderıd.Location = new System.Drawing.Point(98, 75);
            this.Txt_Orderıd.Name = "Txt_Orderıd";
            this.Txt_Orderıd.Size = new System.Drawing.Size(100, 20);
            this.Txt_Orderıd.TabIndex = 1;
            this.Txt_Orderıd.Visible = false;
            // 
            // Txt_Customer
            // 
            this.Txt_Customer.Location = new System.Drawing.Point(98, 33);
            this.Txt_Customer.Name = "Txt_Customer";
            this.Txt_Customer.Size = new System.Drawing.Size(100, 20);
            this.Txt_Customer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Id";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Name";
            // 
            // Txt_Dat
            // 
            this.Txt_Dat.Location = new System.Drawing.Point(292, 75);
            this.Txt_Dat.Name = "Txt_Dat";
            this.Txt_Dat.Size = new System.Drawing.Size(100, 20);
            this.Txt_Dat.TabIndex = 1;
            this.Txt_Dat.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            this.label1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mobile";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_item);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.Txt_Quantity);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 84);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // Btn_item
            // 
            this.Btn_item.Location = new System.Drawing.Point(437, 26);
            this.Btn_item.Name = "Btn_item";
            this.Btn_item.Size = new System.Drawing.Size(75, 23);
            this.Btn_item.TabIndex = 3;
            this.Btn_item.Text = "Add İtem";
            this.Btn_item.UseVisualStyleBackColor = true;
            this.Btn_item.Click += new System.EventHandler(this.Btn_item_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Select Product";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rondo ",
            "Albeni ",
            "Burçak",
            "Benimo",
            "Cino",
            "Tutku",
            "Karam",
            "Browni",
            "Çikolatalı Gofret"});
            this.comboBox1.Location = new System.Drawing.Point(98, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // Txt_Quantity
            // 
            this.Txt_Quantity.Location = new System.Drawing.Point(292, 29);
            this.Txt_Quantity.Name = "Txt_Quantity";
            this.Txt_Quantity.Size = new System.Drawing.Size(100, 20);
            this.Txt_Quantity.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıtemIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.pricePerUnitDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordermanagmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // marketmanagmentsystemDataSet1
            // 
            this.marketmanagmentsystemDataSet1.DataSetName = "MarketmanagmentsystemDataSet1";
            this.marketmanagmentsystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Save);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 99);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Visible = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(391, 39);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(99, 39);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "SaveOrder";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(167, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Amount : ";
            // 
            // ordermanagmentTableAdapter
            // 
            this.ordermanagmentTableAdapter.ClearBeforeFill = true;
            // 
            // marketmanagmentsystemDataSet2
            // 
            this.marketmanagmentsystemDataSet2.DataSetName = "MarketmanagmentsystemDataSet2";
            this.marketmanagmentsystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordermanagmentBindingSource
            // 
            this.ordermanagmentBindingSource.DataMember = "Ordermanagment";
            this.ordermanagmentBindingSource.DataSource = this.marketmanagmentsystemDataSet2;
            // 
            // ordermanagmentTableAdapter1
            // 
            this.ordermanagmentTableAdapter1.ClearBeforeFill = true;
            // 
            // ıtemIDDataGridViewTextBoxColumn
            // 
            this.ıtemIDDataGridViewTextBoxColumn.DataPropertyName = "Item ID";
            this.ıtemIDDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.ıtemIDDataGridViewTextBoxColumn.Name = "ıtemIDDataGridViewTextBoxColumn";
            this.ıtemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // pricePerUnitDataGridViewTextBoxColumn
            // 
            this.pricePerUnitDataGridViewTextBoxColumn.DataPropertyName = "PricePerUnit";
            this.pricePerUnitDataGridViewTextBoxColumn.HeaderText = "PricePerUnit";
            this.pricePerUnitDataGridViewTextBoxColumn.Name = "pricePerUnitDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // OrderedManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 525);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderedManagment";
            this.Text = "OrderedManagment";
            this.Load += new System.EventHandler(this.OrderedManagment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketmanagmentsystemDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketmanagmentsystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordermanagmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Order;
        private System.Windows.Forms.TextBox Txt_Customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Orderıd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Dat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_item;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Txt_Quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label label8;
        private MarketmanagmentsystemDataSet1 marketmanagmentsystemDataSet1;
        private MarketmanagmentsystemDataSet1TableAdapters.OrdermanagmentTableAdapter ordermanagmentTableAdapter;
        private System.Windows.Forms.TextBox Txt_Phone;
        private MarketmanagmentsystemDataSet2 marketmanagmentsystemDataSet2;
        private System.Windows.Forms.BindingSource ordermanagmentBindingSource;
        private MarketmanagmentsystemDataSet2TableAdapters.OrdermanagmentTableAdapter ordermanagmentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıtemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}