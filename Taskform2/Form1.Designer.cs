namespace Taskform2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Idlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prating = new System.Windows.Forms.TextBox();
            this.imdbrating = new System.Windows.Forms.TextBox();
            this.realeasedate = new System.Windows.Forms.TextBox();
            this.revenue = new System.Windows.Forms.TextBox();
            this.company = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(366, 228);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Idlabel.Location = new System.Drawing.Point(67, 219);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(21, 15);
            this.Idlabel.TabIndex = 68;
            this.Idlabel.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 61;
            this.label3.Text = "Release Date :";
            // 
            // idtext
            // 
            this.idtext.Enabled = false;
            this.idtext.Location = new System.Drawing.Point(94, 217);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(321, 23);
            this.idtext.TabIndex = 67;
            this.idtext.MouseLeave += new System.EventHandler(this.idtext_MouseLeave);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.Location = new System.Drawing.Point(315, 263);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(173, 57);
            this.update.TabIndex = 66;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 65;
            this.label7.Text = "Revenue :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 64;
            this.label4.Text = "Price : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 63;
            this.label5.Text = "Player Rating :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 62;
            this.label6.Text = "Imdb Rating :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "Company :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "Name :";
            // 
            // prating
            // 
            this.prating.Location = new System.Drawing.Point(95, 188);
            this.prating.Name = "prating";
            this.prating.Size = new System.Drawing.Size(321, 23);
            this.prating.TabIndex = 58;
            this.prating.MouseLeave += new System.EventHandler(this.idtext_MouseLeave);
            this.prating.MouseHover += new System.EventHandler(this.prating_MouseHover);
            // 
            // imdbrating
            // 
            this.imdbrating.Location = new System.Drawing.Point(94, 159);
            this.imdbrating.Name = "imdbrating";
            this.imdbrating.Size = new System.Drawing.Size(321, 23);
            this.imdbrating.TabIndex = 57;
            this.imdbrating.MouseLeave += new System.EventHandler(this.idtext_MouseLeave);
            this.imdbrating.MouseHover += new System.EventHandler(this.imdbrating_MouseHover);
            // 
            // realeasedate
            // 
            this.realeasedate.Location = new System.Drawing.Point(94, 130);
            this.realeasedate.Name = "realeasedate";
            this.realeasedate.Size = new System.Drawing.Size(321, 23);
            this.realeasedate.TabIndex = 56;
            this.realeasedate.MouseLeave += new System.EventHandler(this.idtext_MouseLeave);
            this.realeasedate.MouseHover += new System.EventHandler(this.realeasedate_MouseHover);
            // 
            // revenue
            // 
            this.revenue.Location = new System.Drawing.Point(94, 72);
            this.revenue.Name = "revenue";
            this.revenue.Size = new System.Drawing.Size(321, 23);
            this.revenue.TabIndex = 55;
            this.revenue.MouseLeave += new System.EventHandler(this.idtext_MouseLeave);
            this.revenue.MouseHover += new System.EventHandler(this.revenue_MouseHover);
            // 
            // company
            // 
            this.company.Location = new System.Drawing.Point(94, 101);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(321, 23);
            this.company.TabIndex = 54;
            this.company.MouseLeave += new System.EventHandler(this.idtext_MouseLeave);
            this.company.MouseHover += new System.EventHandler(this.company_MouseHover);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(95, 43);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(321, 23);
            this.price.TabIndex = 53;
            this.price.MouseLeave += new System.EventHandler(this.idtext_MouseLeave);
            this.price.MouseHover += new System.EventHandler(this.price_MouseHover);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(95, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(320, 23);
            this.name.TabIndex = 52;
            this.name.MouseLeave += new System.EventHandler(this.idtext_MouseLeave);
            this.name.MouseHover += new System.EventHandler(this.name_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 331);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 51;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(600, 263);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(173, 57);
            this.delete.TabIndex = 70;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(30, 263);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(173, 57);
            this.Add.TabIndex = 71;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Idlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prating);
            this.Controls.Add(this.imdbrating);
            this.Controls.Add(this.realeasedate);
            this.Controls.Add(this.revenue);
            this.Controls.Add(this.company);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prating;
        private System.Windows.Forms.TextBox imdbrating;
        private System.Windows.Forms.TextBox realeasedate;
        private System.Windows.Forms.TextBox revenue;
        private System.Windows.Forms.TextBox company;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Add;
    }
}
