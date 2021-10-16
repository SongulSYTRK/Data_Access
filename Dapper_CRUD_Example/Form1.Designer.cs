
namespace Dapper_CRUD_Example
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpCreateProduct = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtunitInStockCreate = new System.Windows.Forms.TextBox();
            this.txtcreateunitprice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpUpdateProduct = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnitstockUpdateProduct = new System.Windows.Forms.TextBox();
            this.txtUnitpriceProduct = new System.Windows.Forms.TextBox();
            this.txtNameUpdatePRoduct = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.grpCategories = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCatgoryID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpCreateProduct.SuspendLayout();
            this.grpUpdateProduct.SuspendLayout();
            this.grpCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // grpCreateProduct
            // 
            this.grpCreateProduct.Controls.Add(this.label3);
            this.grpCreateProduct.Controls.Add(this.label2);
            this.grpCreateProduct.Controls.Add(this.label1);
            this.grpCreateProduct.Controls.Add(this.txtunitInStockCreate);
            this.grpCreateProduct.Controls.Add(this.txtcreateunitprice);
            this.grpCreateProduct.Controls.Add(this.txtProductName);
            this.grpCreateProduct.Controls.Add(this.btnCreateProduct);
            this.grpCreateProduct.Location = new System.Drawing.Point(12, 12);
            this.grpCreateProduct.Name = "grpCreateProduct";
            this.grpCreateProduct.Size = new System.Drawing.Size(241, 183);
            this.grpCreateProduct.TabIndex = 5;
            this.grpCreateProduct.TabStop = false;
            this.grpCreateProduct.Text = "Create Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "UnitINStock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "UnitPrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ProductName";
            // 
            // txtunitInStockCreate
            // 
            this.txtunitInStockCreate.Location = new System.Drawing.Point(107, 83);
            this.txtunitInStockCreate.Name = "txtunitInStockCreate";
            this.txtunitInStockCreate.Size = new System.Drawing.Size(100, 22);
            this.txtunitInStockCreate.TabIndex = 8;
            // 
            // txtcreateunitprice
            // 
            this.txtcreateunitprice.Location = new System.Drawing.Point(107, 55);
            this.txtcreateunitprice.Name = "txtcreateunitprice";
            this.txtcreateunitprice.Size = new System.Drawing.Size(100, 22);
            this.txtcreateunitprice.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(107, 21);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 22);
            this.txtProductName.TabIndex = 6;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(60, 124);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(99, 43);
            this.btnCreateProduct.TabIndex = 5;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(142, 47);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(91, 33);
            this.btnProductDelete.TabIndex = 6;
            this.btnProductDelete.Text = "Delete ";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Listele ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpUpdateProduct
            // 
            this.grpUpdateProduct.Controls.Add(this.ID);
            this.grpUpdateProduct.Controls.Add(this.txtId);
            this.grpUpdateProduct.Controls.Add(this.btnProductDelete);
            this.grpUpdateProduct.Controls.Add(this.button1);
            this.grpUpdateProduct.Controls.Add(this.label4);
            this.grpUpdateProduct.Controls.Add(this.label5);
            this.grpUpdateProduct.Controls.Add(this.label6);
            this.grpUpdateProduct.Controls.Add(this.txtUnitstockUpdateProduct);
            this.grpUpdateProduct.Controls.Add(this.txtUnitpriceProduct);
            this.grpUpdateProduct.Controls.Add(this.txtNameUpdatePRoduct);
            this.grpUpdateProduct.Location = new System.Drawing.Point(259, 12);
            this.grpUpdateProduct.Name = "grpUpdateProduct";
            this.grpUpdateProduct.Size = new System.Drawing.Size(241, 229);
            this.grpUpdateProduct.TabIndex = 5;
            this.grpUpdateProduct.TabStop = false;
            this.grpUpdateProduct.Text = "Update Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Update Product ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "UnitINStock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "UnitPrice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "ProductName";
            // 
            // txtUnitstockUpdateProduct
            // 
            this.txtUnitstockUpdateProduct.Location = new System.Drawing.Point(106, 150);
            this.txtUnitstockUpdateProduct.Name = "txtUnitstockUpdateProduct";
            this.txtUnitstockUpdateProduct.Size = new System.Drawing.Size(100, 22);
            this.txtUnitstockUpdateProduct.TabIndex = 8;
            // 
            // txtUnitpriceProduct
            // 
            this.txtUnitpriceProduct.Location = new System.Drawing.Point(106, 122);
            this.txtUnitpriceProduct.Name = "txtUnitpriceProduct";
            this.txtUnitpriceProduct.Size = new System.Drawing.Size(100, 22);
            this.txtUnitpriceProduct.TabIndex = 7;
            // 
            // txtNameUpdatePRoduct
            // 
            this.txtNameUpdatePRoduct.Location = new System.Drawing.Point(106, 88);
            this.txtNameUpdatePRoduct.Name = "txtNameUpdatePRoduct";
            this.txtNameUpdatePRoduct.Size = new System.Drawing.Size(100, 22);
            this.txtNameUpdatePRoduct.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(36, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(9, 55);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 17);
            this.ID.TabIndex = 15;
            this.ID.Text = "ID";
            // 
            // grpCategories
            // 
            this.grpCategories.Controls.Add(this.txtCatgoryID);
            this.grpCategories.Controls.Add(this.label9);
            this.grpCategories.Controls.Add(this.label8);
            this.grpCategories.Controls.Add(this.label7);
            this.grpCategories.Controls.Add(this.txtDescription);
            this.grpCategories.Controls.Add(this.txtCategoryName);
            this.grpCategories.Controls.Add(this.btnUpdate);
            this.grpCategories.Controls.Add(this.btnCreate);
            this.grpCategories.Controls.Add(this.btnDelete);
            this.grpCategories.Controls.Add(this.btnListele);
            this.grpCategories.Location = new System.Drawing.Point(506, 12);
            this.grpCategories.Name = "grpCategories";
            this.grpCategories.Size = new System.Drawing.Size(259, 223);
            this.grpCategories.TabIndex = 8;
            this.grpCategories.TabStop = false;
            this.grpCategories.Text = "Categories";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(20, 133);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 29);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(138, 130);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 32);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(138, 163);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(138, 42);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(100, 22);
            this.txtCategoryName.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(138, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "CategoryNamr ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "CategoryId";
            // 
            // txtCatgoryID
            // 
            this.txtCatgoryID.Location = new System.Drawing.Point(138, 11);
            this.txtCatgoryID.Name = "txtCatgoryID";
            this.txtCatgoryID.Size = new System.Drawing.Size(100, 22);
            this.txtCatgoryID.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.grpCategories);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grpUpdateProduct);
            this.Controls.Add(this.grpCreateProduct);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpCreateProduct.ResumeLayout(false);
            this.grpCreateProduct.PerformLayout();
            this.grpUpdateProduct.ResumeLayout(false);
            this.grpUpdateProduct.PerformLayout();
            this.grpCategories.ResumeLayout(false);
            this.grpCategories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpCreateProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtunitInStockCreate;
        private System.Windows.Forms.TextBox txtcreateunitprice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpUpdateProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitstockUpdateProduct;
        private System.Windows.Forms.TextBox txtUnitpriceProduct;
        private System.Windows.Forms.TextBox txtNameUpdatePRoduct;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox grpCategories;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCatgoryID;
        private System.Windows.Forms.Label label9;
    }
}

