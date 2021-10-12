
namespace LinQ_To_Sql_Example
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
            this.btnExample_1 = new System.Windows.Forms.Button();
            this.btnExample_2 = new System.Windows.Forms.Button();
            this.btnexample_3 = new System.Windows.Forms.Button();
            this.btnExample_4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExample_1
            // 
            this.btnExample_1.Location = new System.Drawing.Point(34, 12);
            this.btnExample_1.Name = "btnExample_1";
            this.btnExample_1.Size = new System.Drawing.Size(100, 69);
            this.btnExample_1.TabIndex = 1;
            this.btnExample_1.Text = "Example_1";
            this.btnExample_1.UseVisualStyleBackColor = true;
            this.btnExample_1.Click += new System.EventHandler(this.btnExample_1_Click);
            // 
            // btnExample_2
            // 
            this.btnExample_2.Location = new System.Drawing.Point(152, 13);
            this.btnExample_2.Name = "btnExample_2";
            this.btnExample_2.Size = new System.Drawing.Size(106, 68);
            this.btnExample_2.TabIndex = 2;
            this.btnExample_2.Text = "Example_2";
            this.btnExample_2.UseVisualStyleBackColor = true;
            this.btnExample_2.Click += new System.EventHandler(this.btnExample_2_Click);
            // 
            // btnexample_3
            // 
            this.btnexample_3.Location = new System.Drawing.Point(275, 13);
            this.btnexample_3.Name = "btnexample_3";
            this.btnexample_3.Size = new System.Drawing.Size(116, 68);
            this.btnexample_3.TabIndex = 3;
            this.btnexample_3.Text = "Example_3";
            this.btnexample_3.UseVisualStyleBackColor = true;
            this.btnexample_3.Click += new System.EventHandler(this.btnexample_3_Click);
            // 
            // btnExample_4
            // 
            this.btnExample_4.Location = new System.Drawing.Point(415, 13);
            this.btnExample_4.Name = "btnExample_4";
            this.btnExample_4.Size = new System.Drawing.Size(131, 68);
            this.btnExample_4.TabIndex = 4;
            this.btnExample_4.Text = "Example_4";
            this.btnExample_4.UseVisualStyleBackColor = true;
            this.btnExample_4.Click += new System.EventHandler(this.btnExample_4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExample_4);
            this.Controls.Add(this.btnexample_3);
            this.Controls.Add(this.btnExample_2);
            this.Controls.Add(this.btnExample_1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExample_1;
        private System.Windows.Forms.Button btnExample_2;
        private System.Windows.Forms.Button btnexample_3;
        private System.Windows.Forms.Button btnExample_4;
    }
}

