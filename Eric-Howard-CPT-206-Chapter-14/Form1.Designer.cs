namespace Eric_Howard_CPT_206_Chapter_14
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNumberTextBox = new System.Windows.Forms.TextBox();
            this.productNumberLabel = new System.Windows.Forms.Label();
            this.productDescTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prodNumberBtn = new System.Windows.Forms.Button();
            this.prodDescBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.gtUnitsTextBox = new System.Windows.Forms.TextBox();
            this.unitsOnHandGTlabel = new System.Windows.Forms.Label();
            this.gtUnitsBtn = new System.Windows.Forms.Button();
            this.ascendingOnhandBtn = new System.Windows.Forms.Button();
            this.ltUnitsTextBox = new System.Windows.Forms.TextBox();
            this.unitsOnHandLT = new System.Windows.Forms.Label();
            this.ltUnitsBtn = new System.Windows.Forms.Button();
            this.sortPriceAscBtn = new System.Windows.Forms.Button();
            this.gtPriceTextBox = new System.Windows.Forms.TextBox();
            this.priceGTLabel = new System.Windows.Forms.Label();
            this.gtPriceBtn = new System.Windows.Forms.Button();
            this.ltPriceTextBox = new System.Windows.Forms.TextBox();
            this.priceLTLabel = new System.Windows.Forms.Label();
            this.ltPriceBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(1067, 25);
            this.productBindingNavigator.TabIndex = 0;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Eric_Howard_CPT_206_Chapter_14.Product);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Enabled = false;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(0, 34);
            this.productDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(611, 505);
            this.productDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // productNumberTextBox
            // 
            this.productNumberTextBox.Location = new System.Drawing.Point(752, 58);
            this.productNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productNumberTextBox.Name = "productNumberTextBox";
            this.productNumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.productNumberTextBox.TabIndex = 2;
            // 
            // productNumberLabel
            // 
            this.productNumberLabel.AutoSize = true;
            this.productNumberLabel.Location = new System.Drawing.Point(619, 62);
            this.productNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNumberLabel.Name = "productNumberLabel";
            this.productNumberLabel.Size = new System.Drawing.Size(104, 16);
            this.productNumberLabel.TabIndex = 3;
            this.productNumberLabel.Text = "Product Number";
            // 
            // productDescTextBox
            // 
            this.productDescTextBox.Location = new System.Drawing.Point(752, 100);
            this.productDescTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productDescTextBox.Name = "productDescTextBox";
            this.productDescTextBox.Size = new System.Drawing.Size(132, 22);
            this.productDescTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Desc";
            // 
            // prodNumberBtn
            // 
            this.prodNumberBtn.Location = new System.Drawing.Point(912, 55);
            this.prodNumberBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodNumberBtn.Name = "prodNumberBtn";
            this.prodNumberBtn.Size = new System.Drawing.Size(100, 28);
            this.prodNumberBtn.TabIndex = 4;
            this.prodNumberBtn.Text = "Search";
            this.prodNumberBtn.UseVisualStyleBackColor = true;
            this.prodNumberBtn.Click += new System.EventHandler(this.prodNumberBtn_Click);
            // 
            // prodDescBtn
            // 
            this.prodDescBtn.Location = new System.Drawing.Point(912, 97);
            this.prodDescBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodDescBtn.Name = "prodDescBtn";
            this.prodDescBtn.Size = new System.Drawing.Size(100, 28);
            this.prodDescBtn.TabIndex = 4;
            this.prodDescBtn.Text = "Search";
            this.prodDescBtn.UseVisualStyleBackColor = true;
            this.prodDescBtn.Click += new System.EventHandler(this.prodDescBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(623, 375);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(169, 47);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // gtUnitsTextBox
            // 
            this.gtUnitsTextBox.Location = new System.Drawing.Point(752, 140);
            this.gtUnitsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtUnitsTextBox.Name = "gtUnitsTextBox";
            this.gtUnitsTextBox.Size = new System.Drawing.Size(132, 22);
            this.gtUnitsTextBox.TabIndex = 2;
            // 
            // unitsOnHandGTlabel
            // 
            this.unitsOnHandGTlabel.AutoSize = true;
            this.unitsOnHandGTlabel.Location = new System.Drawing.Point(619, 149);
            this.unitsOnHandGTlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitsOnHandGTlabel.Name = "unitsOnHandGTlabel";
            this.unitsOnHandGTlabel.Size = new System.Drawing.Size(101, 16);
            this.unitsOnHandGTlabel.TabIndex = 3;
            this.unitsOnHandGTlabel.Text = "Units on hand > ";
            // 
            // gtUnitsBtn
            // 
            this.gtUnitsBtn.Location = new System.Drawing.Point(912, 138);
            this.gtUnitsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtUnitsBtn.Name = "gtUnitsBtn";
            this.gtUnitsBtn.Size = new System.Drawing.Size(100, 28);
            this.gtUnitsBtn.TabIndex = 4;
            this.gtUnitsBtn.Text = "Search";
            this.gtUnitsBtn.UseVisualStyleBackColor = true;
            this.gtUnitsBtn.Click += new System.EventHandler(this.gtUnitsBtn_Click);
            // 
            // ascendingOnhandBtn
            // 
            this.ascendingOnhandBtn.Location = new System.Drawing.Point(619, 318);
            this.ascendingOnhandBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ascendingOnhandBtn.Name = "ascendingOnhandBtn";
            this.ascendingOnhandBtn.Size = new System.Drawing.Size(173, 50);
            this.ascendingOnhandBtn.TabIndex = 6;
            this.ascendingOnhandBtn.Text = "Sort by Units on hand  Asc.";
            this.ascendingOnhandBtn.UseVisualStyleBackColor = true;
            this.ascendingOnhandBtn.Click += new System.EventHandler(this.ascendingOnhandBtn_Click);
            // 
            // ltUnitsTextBox
            // 
            this.ltUnitsTextBox.Location = new System.Drawing.Point(752, 181);
            this.ltUnitsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltUnitsTextBox.Name = "ltUnitsTextBox";
            this.ltUnitsTextBox.Size = new System.Drawing.Size(132, 22);
            this.ltUnitsTextBox.TabIndex = 2;
            // 
            // unitsOnHandLT
            // 
            this.unitsOnHandLT.AutoSize = true;
            this.unitsOnHandLT.Location = new System.Drawing.Point(619, 190);
            this.unitsOnHandLT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitsOnHandLT.Name = "unitsOnHandLT";
            this.unitsOnHandLT.Size = new System.Drawing.Size(98, 16);
            this.unitsOnHandLT.TabIndex = 3;
            this.unitsOnHandLT.Text = "Units on hand <";
            // 
            // ltUnitsBtn
            // 
            this.ltUnitsBtn.Location = new System.Drawing.Point(912, 178);
            this.ltUnitsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltUnitsBtn.Name = "ltUnitsBtn";
            this.ltUnitsBtn.Size = new System.Drawing.Size(100, 28);
            this.ltUnitsBtn.TabIndex = 4;
            this.ltUnitsBtn.Text = "Search";
            this.ltUnitsBtn.UseVisualStyleBackColor = true;
            this.ltUnitsBtn.Click += new System.EventHandler(this.ltUnitsBtn_Click);
            // 
            // sortPriceAscBtn
            // 
            this.sortPriceAscBtn.Location = new System.Drawing.Point(820, 318);
            this.sortPriceAscBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortPriceAscBtn.Name = "sortPriceAscBtn";
            this.sortPriceAscBtn.Size = new System.Drawing.Size(167, 50);
            this.sortPriceAscBtn.TabIndex = 7;
            this.sortPriceAscBtn.Text = "Sory by Price Asc.";
            this.sortPriceAscBtn.UseVisualStyleBackColor = true;
            this.sortPriceAscBtn.Click += new System.EventHandler(this.sortPriceAscBtn_Click);
            // 
            // gtPriceTextBox
            // 
            this.gtPriceTextBox.Location = new System.Drawing.Point(752, 219);
            this.gtPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtPriceTextBox.Name = "gtPriceTextBox";
            this.gtPriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.gtPriceTextBox.TabIndex = 2;
            // 
            // priceGTLabel
            // 
            this.priceGTLabel.AutoSize = true;
            this.priceGTLabel.Location = new System.Drawing.Point(619, 228);
            this.priceGTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceGTLabel.Name = "priceGTLabel";
            this.priceGTLabel.Size = new System.Drawing.Size(55, 16);
            this.priceGTLabel.TabIndex = 3;
            this.priceGTLabel.Text = "Prices <";
            // 
            // gtPriceBtn
            // 
            this.gtPriceBtn.Location = new System.Drawing.Point(912, 217);
            this.gtPriceBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gtPriceBtn.Name = "gtPriceBtn";
            this.gtPriceBtn.Size = new System.Drawing.Size(100, 28);
            this.gtPriceBtn.TabIndex = 4;
            this.gtPriceBtn.Text = "Search";
            this.gtPriceBtn.UseVisualStyleBackColor = true;
            this.gtPriceBtn.Click += new System.EventHandler(this.gtPriceBtn_Click);
            // 
            // ltPriceTextBox
            // 
            this.ltPriceTextBox.Location = new System.Drawing.Point(752, 251);
            this.ltPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltPriceTextBox.Name = "ltPriceTextBox";
            this.ltPriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.ltPriceTextBox.TabIndex = 2;
            // 
            // priceLTLabel
            // 
            this.priceLTLabel.AutoSize = true;
            this.priceLTLabel.Location = new System.Drawing.Point(619, 260);
            this.priceLTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLTLabel.Name = "priceLTLabel";
            this.priceLTLabel.Size = new System.Drawing.Size(55, 16);
            this.priceLTLabel.TabIndex = 3;
            this.priceLTLabel.Text = "Prices >";
            // 
            // ltPriceBtn
            // 
            this.ltPriceBtn.Location = new System.Drawing.Point(912, 249);
            this.ltPriceBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltPriceBtn.Name = "ltPriceBtn";
            this.ltPriceBtn.Size = new System.Drawing.Size(100, 28);
            this.ltPriceBtn.TabIndex = 4;
            this.ltPriceBtn.Text = "Search";
            this.ltPriceBtn.UseVisualStyleBackColor = true;
            this.ltPriceBtn.Click += new System.EventHandler(this.ltPriceBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(820, 375);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(167, 47);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sortPriceAscBtn);
            this.Controls.Add(this.ascendingOnhandBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.ltPriceBtn);
            this.Controls.Add(this.gtPriceBtn);
            this.Controls.Add(this.ltUnitsBtn);
            this.Controls.Add(this.gtUnitsBtn);
            this.Controls.Add(this.prodDescBtn);
            this.Controls.Add(this.prodNumberBtn);
            this.Controls.Add(this.priceLTLabel);
            this.Controls.Add(this.priceGTLabel);
            this.Controls.Add(this.unitsOnHandLT);
            this.Controls.Add(this.ltPriceTextBox);
            this.Controls.Add(this.gtPriceTextBox);
            this.Controls.Add(this.unitsOnHandGTlabel);
            this.Controls.Add(this.ltUnitsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gtUnitsTextBox);
            this.Controls.Add(this.productDescTextBox);
            this.Controls.Add(this.productNumberLabel);
            this.Controls.Add(this.productNumberTextBox);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.productBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 14";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox productNumberTextBox;
        private System.Windows.Forms.Label productNumberLabel;
        private System.Windows.Forms.TextBox productDescTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prodNumberBtn;
        private System.Windows.Forms.Button prodDescBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox gtUnitsTextBox;
        private System.Windows.Forms.Label unitsOnHandGTlabel;
        private System.Windows.Forms.Button gtUnitsBtn;
        private System.Windows.Forms.Button ascendingOnhandBtn;
        private System.Windows.Forms.TextBox ltUnitsTextBox;
        private System.Windows.Forms.Label unitsOnHandLT;
        private System.Windows.Forms.Button ltUnitsBtn;
        private System.Windows.Forms.Button sortPriceAscBtn;
        private System.Windows.Forms.TextBox gtPriceTextBox;
        private System.Windows.Forms.Label priceGTLabel;
        private System.Windows.Forms.Button gtPriceBtn;
        private System.Windows.Forms.TextBox ltPriceTextBox;
        private System.Windows.Forms.Label priceLTLabel;
        private System.Windows.Forms.Button ltPriceBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}

