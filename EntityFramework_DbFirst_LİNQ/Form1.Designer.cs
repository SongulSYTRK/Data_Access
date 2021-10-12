
namespace EntityFramework_DbFirst_LİNQ
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTolist = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnexample_16 = new System.Windows.Forms.Button();
            this.btnMax_Min = new System.Windows.Forms.Button();
            this.btnexample_14 = new System.Windows.Forms.Button();
            this.btnexample_13 = new System.Windows.Forms.Button();
            this.btnexample_12 = new System.Windows.Forms.Button();
            this.btnStart_End_With = new System.Windows.Forms.Button();
            this.btnContai = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnfirst_default = new System.Windows.Forms.Button();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnorderby = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnsingleordefault = new System.Windows.Forms.Button();
            this.btnsingle = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(512, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 212);
            this.listBox1.TabIndex = 1;
            // 
            // btnTolist
            // 
            this.btnTolist.Location = new System.Drawing.Point(21, 12);
            this.btnTolist.Name = "btnTolist";
            this.btnTolist.Size = new System.Drawing.Size(74, 44);
            this.btnTolist.TabIndex = 2;
            this.btnTolist.Text = "ToList";
            this.btnTolist.UseVisualStyleBackColor = true;
            this.btnTolist.Click += new System.EventHandler(this.btnTolist_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(302, 62);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(99, 45);
            this.btnGroupBy.TabIndex = 21;
            this.btnGroupBy.Text = "GroupBy";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnexample_16
            // 
            this.btnexample_16.Location = new System.Drawing.Point(503, 112);
            this.btnexample_16.Name = "btnexample_16";
            this.btnexample_16.Size = new System.Drawing.Size(99, 46);
            this.btnexample_16.TabIndex = 20;
            this.btnexample_16.Text = "Distinct";
            this.btnexample_16.UseVisualStyleBackColor = true;
            this.btnexample_16.Click += new System.EventHandler(this.btnexample_16_Click);
            // 
            // btnMax_Min
            // 
            this.btnMax_Min.Location = new System.Drawing.Point(408, 109);
            this.btnMax_Min.Name = "btnMax_Min";
            this.btnMax_Min.Size = new System.Drawing.Size(89, 49);
            this.btnMax_Min.TabIndex = 19;
            this.btnMax_Min.Text = "Max-Min";
            this.btnMax_Min.UseVisualStyleBackColor = true;
            this.btnMax_Min.Click += new System.EventHandler(this.btnexample_15_Click);
            // 
            // btnexample_14
            // 
            this.btnexample_14.Location = new System.Drawing.Point(503, 62);
            this.btnexample_14.Name = "btnexample_14";
            this.btnexample_14.Size = new System.Drawing.Size(99, 45);
            this.btnexample_14.TabIndex = 18;
            this.btnexample_14.Text = "Sum";
            this.btnexample_14.UseVisualStyleBackColor = true;
            this.btnexample_14.Click += new System.EventHandler(this.btnexample_14_Click);
            // 
            // btnexample_13
            // 
            this.btnexample_13.Location = new System.Drawing.Point(503, 11);
            this.btnexample_13.Name = "btnexample_13";
            this.btnexample_13.Size = new System.Drawing.Size(99, 45);
            this.btnexample_13.TabIndex = 17;
            this.btnexample_13.Text = "Count";
            this.btnexample_13.UseVisualStyleBackColor = true;
            this.btnexample_13.Click += new System.EventHandler(this.btnexample_13_Click);
            // 
            // btnexample_12
            // 
            this.btnexample_12.Location = new System.Drawing.Point(408, 62);
            this.btnexample_12.Name = "btnexample_12";
            this.btnexample_12.Size = new System.Drawing.Size(89, 45);
            this.btnexample_12.TabIndex = 16;
            this.btnexample_12.Text = "Any";
            this.btnexample_12.UseVisualStyleBackColor = true;
            this.btnexample_12.Click += new System.EventHandler(this.btnexample_12_Click);
            // 
            // btnStart_End_With
            // 
            this.btnStart_End_With.Location = new System.Drawing.Point(407, 12);
            this.btnStart_End_With.Name = "btnStart_End_With";
            this.btnStart_End_With.Size = new System.Drawing.Size(90, 44);
            this.btnStart_End_With.TabIndex = 15;
            this.btnStart_End_With.Text = "Start_End With";
            this.btnStart_End_With.UseVisualStyleBackColor = true;
            this.btnStart_End_With.Click += new System.EventHandler(this.btnStart_End_With_Click);
            // 
            // btnContai
            // 
            this.btnContai.Location = new System.Drawing.Point(302, 113);
            this.btnContai.Name = "btnContai";
            this.btnContai.Size = new System.Drawing.Size(99, 45);
            this.btnContai.TabIndex = 14;
            this.btnContai.Text = "Contains";
            this.btnContai.UseVisualStyleBackColor = true;
            this.btnContai.Click += new System.EventHandler(this.btnContai_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(302, 12);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(99, 44);
            this.btnSkip.TabIndex = 13;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(197, 113);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(99, 51);
            this.btnTake.TabIndex = 11;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(197, 62);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(99, 45);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnexample_7_Click);
            // 
            // btnfirst_default
            // 
            this.btnfirst_default.Location = new System.Drawing.Point(197, 12);
            this.btnfirst_default.Name = "btnfirst_default";
            this.btnfirst_default.Size = new System.Drawing.Size(99, 44);
            this.btnfirst_default.TabIndex = 8;
            this.btnfirst_default.Text = "First Or Default ";
            this.btnfirst_default.UseVisualStyleBackColor = true;
            this.btnfirst_default.Click += new System.EventHandler(this.btnfirst_default_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(101, 113);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(90, 51);
            this.BtnFirst.TabIndex = 7;
            this.BtnFirst.Text = "First ";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(21, 113);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(74, 51);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(21, 62);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(74, 45);
            this.btnWhere.TabIndex = 22;
            this.btnWhere.Text = "WHERE";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnorderby
            // 
            this.btnorderby.Location = new System.Drawing.Point(101, 62);
            this.btnorderby.Name = "btnorderby";
            this.btnorderby.Size = new System.Drawing.Size(90, 45);
            this.btnorderby.TabIndex = 6;
            this.btnorderby.Text = "OrderBy";
            this.btnorderby.UseVisualStyleBackColor = true;
            this.btnorderby.Click += new System.EventHandler(this.btnorderby_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(101, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = "OrderbyDescendindg";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnsingleordefault
            // 
            this.btnsingleordefault.Location = new System.Drawing.Point(608, 12);
            this.btnsingleordefault.Name = "btnsingleordefault";
            this.btnsingleordefault.Size = new System.Drawing.Size(142, 44);
            this.btnsingleordefault.TabIndex = 23;
            this.btnsingleordefault.Text = "SingleorDefault";
            this.btnsingleordefault.UseVisualStyleBackColor = true;
            this.btnsingleordefault.Click += new System.EventHandler(this.btnsingleordefault_Click);
            // 
            // btnsingle
            // 
            this.btnsingle.Location = new System.Drawing.Point(609, 63);
            this.btnsingle.Name = "btnsingle";
            this.btnsingle.Size = new System.Drawing.Size(141, 57);
            this.btnsingle.TabIndex = 24;
            this.btnsingle.Text = "Single";
            this.btnsingle.UseVisualStyleBackColor = true;
            this.btnsingle.Click += new System.EventHandler(this.btnsingle_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(609, 127);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(141, 54);
            this.btnJoin.TabIndex = 25;
            this.btnJoin.Text = "Join_Example";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnsingle);
            this.Controls.Add(this.btnsingleordefault);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnexample_16);
            this.Controls.Add(this.btnMax_Min);
            this.Controls.Add(this.btnexample_14);
            this.Controls.Add(this.btnexample_13);
            this.Controls.Add(this.btnexample_12);
            this.Controls.Add(this.btnStart_End_With);
            this.Controls.Add(this.btnContai);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnfirst_default);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnorderby);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnTolist);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTolist;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnexample_16;
        private System.Windows.Forms.Button btnMax_Min;
        private System.Windows.Forms.Button btnexample_14;
        private System.Windows.Forms.Button btnexample_13;
        private System.Windows.Forms.Button btnexample_12;
        private System.Windows.Forms.Button btnStart_End_With;
        private System.Windows.Forms.Button btnContai;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnfirst_default;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnorderby;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnsingleordefault;
        private System.Windows.Forms.Button btnsingle;
        private System.Windows.Forms.Button btnJoin;
    }
}

