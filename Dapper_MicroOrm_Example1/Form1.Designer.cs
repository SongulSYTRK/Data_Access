
namespace Dapper_MicroOrm_Example1
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
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnContain = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnQuarySingle = new System.Windows.Forms.Button();
            this.btnQueryMultiple = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnFirstOrdeFault = new System.Windows.Forms.Button();
            this.btnSingleOrDefault = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnStoreProcedure_Example = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnGorupby = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(459, 154);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(12, 12);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(77, 73);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Category-Where";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.Location = new System.Drawing.Point(9, 91);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(80, 73);
            this.btnproduct.TabIndex = 2;
            this.btnproduct.Text = "Product-Orderby";
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "OrderBy Descending";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(96, 92);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(113, 72);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Top";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(215, 12);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(90, 73);
            this.btnLike.TabIndex = 5;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnContain
            // 
            this.btnContain.Location = new System.Drawing.Point(216, 92);
            this.btnContain.Name = "btnContain";
            this.btnContain.Size = new System.Drawing.Size(89, 72);
            this.btnContain.TabIndex = 6;
            this.btnContain.Text = "Contain";
            this.btnContain.UseVisualStyleBackColor = true;
            this.btnContain.Click += new System.EventHandler(this.btnContain_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(311, 13);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(102, 72);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(737, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 72);
            this.button5.TabIndex = 7;
            this.button5.Text = "QueryFirst ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(471, 178);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 260);
            this.listBox1.TabIndex = 8;
            // 
            // btnQuarySingle
            // 
            this.btnQuarySingle.Location = new System.Drawing.Point(845, 13);
            this.btnQuarySingle.Name = "btnQuarySingle";
            this.btnQuarySingle.Size = new System.Drawing.Size(103, 72);
            this.btnQuarySingle.TabIndex = 9;
            this.btnQuarySingle.Text = "QuarySingle ";
            this.btnQuarySingle.UseVisualStyleBackColor = true;
            this.btnQuarySingle.Click += new System.EventHandler(this.btnQuarySingle_Click);
            // 
            // btnQueryMultiple
            // 
            this.btnQueryMultiple.Location = new System.Drawing.Point(954, 15);
            this.btnQueryMultiple.Name = "btnQueryMultiple";
            this.btnQueryMultiple.Size = new System.Drawing.Size(76, 71);
            this.btnQueryMultiple.TabIndex = 10;
            this.btnQueryMultiple.Text = "Query   Multiple";
            this.btnQueryMultiple.UseVisualStyleBackColor = true;
            this.btnQueryMultiple.Click += new System.EventHandler(this.btnQueryMultiple_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 336);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(459, 102);
            this.dataGridView2.TabIndex = 11;
            // 
            // btnFirstOrdeFault
            // 
            this.btnFirstOrdeFault.Location = new System.Drawing.Point(737, 93);
            this.btnFirstOrdeFault.Name = "btnFirstOrdeFault";
            this.btnFirstOrdeFault.Size = new System.Drawing.Size(102, 72);
            this.btnFirstOrdeFault.TabIndex = 12;
            this.btnFirstOrdeFault.Text = "QueryFirstOrDefault";
            this.btnFirstOrdeFault.UseVisualStyleBackColor = true;
            this.btnFirstOrdeFault.Click += new System.EventHandler(this.btnFirstOrdeFault_Click);
            // 
            // btnSingleOrDefault
            // 
            this.btnSingleOrDefault.Location = new System.Drawing.Point(845, 91);
            this.btnSingleOrDefault.Name = "btnSingleOrDefault";
            this.btnSingleOrDefault.Size = new System.Drawing.Size(100, 72);
            this.btnSingleOrDefault.TabIndex = 13;
            this.btnSingleOrDefault.Text = "QuerySingleOrDEfault";
            this.btnSingleOrDefault.UseVisualStyleBackColor = true;
            this.btnSingleOrDefault.Click += new System.EventHandler(this.btnSingleOrDefault_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(311, 92);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(102, 72);
            this.btnJoin.TabIndex = 14;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnStoreProcedure_Example
            // 
            this.btnStoreProcedure_Example.Location = new System.Drawing.Point(573, 15);
            this.btnStoreProcedure_Example.Name = "btnStoreProcedure_Example";
            this.btnStoreProcedure_Example.Size = new System.Drawing.Size(116, 71);
            this.btnStoreProcedure_Example.TabIndex = 15;
            this.btnStoreProcedure_Example.Text = "StoreProcedure_Example";
            this.btnStoreProcedure_Example.UseVisualStyleBackColor = true;
            this.btnStoreProcedure_Example.Click += new System.EventHandler(this.btnStoreProcedure_Example_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(420, 15);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(96, 70);
            this.btnSum.TabIndex = 16;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnGorupby
            // 
            this.btnGorupby.Location = new System.Drawing.Point(420, 93);
            this.btnGorupby.Name = "btnGorupby";
            this.btnGorupby.Size = new System.Drawing.Size(96, 70);
            this.btnGorupby.TabIndex = 17;
            this.btnGorupby.Text = "GroupBy";
            this.btnGorupby.UseVisualStyleBackColor = true;
            this.btnGorupby.Click += new System.EventHandler(this.btnGorupby_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.btnGorupby);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnStoreProcedure_Example);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnSingleOrDefault);
            this.Controls.Add(this.btnFirstOrdeFault);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnQueryMultiple);
            this.Controls.Add(this.btnQuarySingle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnContain);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnContain;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnQuarySingle;
        private System.Windows.Forms.Button btnQueryMultiple;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnFirstOrdeFault;
        private System.Windows.Forms.Button btnSingleOrDefault;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnStoreProcedure_Example;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnGorupby;
    }
}

