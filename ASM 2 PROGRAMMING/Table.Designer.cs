namespace ASM_2_PROGRAMMING
{
    partial class Table
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtThis = new System.Windows.Forms.TextBox();
            this.comboBoxCustomerType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.comboBoxNumOfPeople = new System.Windows.Forms.ComboBox();
            this.btnSE = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Customer Name";
            columnHeader1.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Month\'s Reading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(29, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "This Month\'s Reading";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(29, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(29, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of People";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(204, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(204, 56);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(121, 20);
            this.txtLast.TabIndex = 6;
            // 
            // txtThis
            // 
            this.txtThis.Location = new System.Drawing.Point(204, 92);
            this.txtThis.Name = "txtThis";
            this.txtThis.Size = new System.Drawing.Size(121, 20);
            this.txtThis.TabIndex = 7;
            // 
            // comboBoxCustomerType
            // 
            this.comboBoxCustomerType.FormattingEnabled = true;
            this.comboBoxCustomerType.Items.AddRange(new object[] {
            "household",
            "administrative",
            "production",
            "business"});
            this.comboBoxCustomerType.Location = new System.Drawing.Point(204, 121);
            this.comboBoxCustomerType.Name = "comboBoxCustomerType";
            this.comboBoxCustomerType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCustomerType.TabIndex = 8;
            this.comboBoxCustomerType.Text = "household";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 315);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(820, 154);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Month\'s Reading";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "This Month\'s Reading";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Customer Type";
            this.columnHeader5.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Number of People";
            this.columnHeader6.Width = 106;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total Bill";
            this.columnHeader7.Width = 102;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(300, 250);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // comboBoxNumOfPeople
            // 
            this.comboBoxNumOfPeople.FormattingEnabled = true;
            this.comboBoxNumOfPeople.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxNumOfPeople.Location = new System.Drawing.Point(204, 157);
            this.comboBoxNumOfPeople.Name = "comboBoxNumOfPeople";
            this.comboBoxNumOfPeople.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNumOfPeople.TabIndex = 15;
            this.comboBoxNumOfPeople.Text = "1";
            // 
            // btnSE
            // 
            this.btnSE.Location = new System.Drawing.Point(33, 278);
            this.btnSE.Name = "btnSE";
            this.btnSE.Size = new System.Drawing.Size(75, 23);
            this.btnSE.TabIndex = 16;
            this.btnSE.Text = "Search";
            this.btnSE.UseVisualStyleBackColor = true;
            this.btnSE.Click += new System.EventHandler(this.btnSE_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(33, 252);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 17;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(114, 277);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(42, 23);
            this.btnSort.TabIndex = 18;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(219, 203);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(436, 48);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(391, 127);
            this.txtShow.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 494);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSE);
            this.Controls.Add(this.comboBoxNumOfPeople);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBoxCustomerType);
            this.Controls.Add(this.txtThis);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtThis;
        private System.Windows.Forms.ComboBox comboBoxCustomerType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox comboBoxNumOfPeople;
        private System.Windows.Forms.Button btnSE;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtShow;
    }
}

