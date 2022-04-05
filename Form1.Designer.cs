namespace NazarethAguileraFinalProjectC968
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_parts = new System.Windows.Forms.Label();
            this.lbl_products = new System.Windows.Forms.Label();
            this.txtbox_parts_search = new System.Windows.Forms.TextBox();
            this.txtbox_products_search = new System.Windows.Forms.TextBox();
            this.btn_parts_search = new System.Windows.Forms.Button();
            this.btn_products_search = new System.Windows.Forms.Button();
            this.btn_parts_add = new System.Windows.Forms.Button();
            this.btn_parts_modify = new System.Windows.Forms.Button();
            this.btn_parts_delete = new System.Windows.Forms.Button();
            this.btn_products_add = new System.Windows.Forms.Button();
            this.btn_products_modify = new System.Windows.Forms.Button();
            this.btn_products_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(39, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(202, 17);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Inventory Management System";
            this.lbl_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 87);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(2, 0);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(750, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(675, 230);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // lbl_parts
            // 
            this.lbl_parts.AutoSize = true;
            this.lbl_parts.Location = new System.Drawing.Point(39, 64);
            this.lbl_parts.Name = "lbl_parts";
            this.lbl_parts.Size = new System.Drawing.Size(41, 17);
            this.lbl_parts.TabIndex = 3;
            this.lbl_parts.Text = "Parts";
            // 
            // lbl_products
            // 
            this.lbl_products.AutoSize = true;
            this.lbl_products.Location = new System.Drawing.Point(747, 65);
            this.lbl_products.Name = "lbl_products";
            this.lbl_products.Size = new System.Drawing.Size(64, 17);
            this.lbl_products.TabIndex = 4;
            this.lbl_products.Text = "Products";
            // 
            // txtbox_parts_search
            // 
            this.txtbox_parts_search.Location = new System.Drawing.Point(541, 62);
            this.txtbox_parts_search.Name = "txtbox_parts_search";
            this.txtbox_parts_search.Size = new System.Drawing.Size(176, 22);
            this.txtbox_parts_search.TabIndex = 5;
            this.txtbox_parts_search.TextChanged += new System.EventHandler(this.update_parts_search_list);
            // 
            // txtbox_products_search
            // 
            this.txtbox_products_search.Location = new System.Drawing.Point(1249, 62);
            this.txtbox_products_search.Name = "txtbox_products_search";
            this.txtbox_products_search.Size = new System.Drawing.Size(176, 22);
            this.txtbox_products_search.TabIndex = 6;
            this.txtbox_products_search.TextChanged += new System.EventHandler(this.update_products_search_list);
            // 
            // btn_parts_search
            // 
            this.btn_parts_search.Enabled = false;
            this.btn_parts_search.Location = new System.Drawing.Point(460, 62);
            this.btn_parts_search.Name = "btn_parts_search";
            this.btn_parts_search.Size = new System.Drawing.Size(75, 23);
            this.btn_parts_search.TabIndex = 7;
            this.btn_parts_search.Text = "Search";
            this.btn_parts_search.UseVisualStyleBackColor = true;
            this.btn_parts_search.Click += new System.EventHandler(this.btn_parts_search_Click);
            // 
            // btn_products_search
            // 
            this.btn_products_search.Enabled = false;
            this.btn_products_search.Location = new System.Drawing.Point(1168, 61);
            this.btn_products_search.Name = "btn_products_search";
            this.btn_products_search.Size = new System.Drawing.Size(75, 23);
            this.btn_products_search.TabIndex = 8;
            this.btn_products_search.Text = "Search";
            this.btn_products_search.UseVisualStyleBackColor = true;
            this.btn_products_search.Click += new System.EventHandler(this.btn_products_search_Click);
            // 
            // btn_parts_add
            // 
            this.btn_parts_add.Location = new System.Drawing.Point(480, 326);
            this.btn_parts_add.Name = "btn_parts_add";
            this.btn_parts_add.Size = new System.Drawing.Size(75, 23);
            this.btn_parts_add.TabIndex = 9;
            this.btn_parts_add.Text = "Add";
            this.btn_parts_add.UseVisualStyleBackColor = true;
            this.btn_parts_add.Click += new System.EventHandler(this.btn_parts_add_Click);
            // 
            // btn_parts_modify
            // 
            this.btn_parts_modify.Enabled = false;
            this.btn_parts_modify.Location = new System.Drawing.Point(561, 326);
            this.btn_parts_modify.Name = "btn_parts_modify";
            this.btn_parts_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_parts_modify.TabIndex = 10;
            this.btn_parts_modify.Text = "Modify";
            this.btn_parts_modify.UseVisualStyleBackColor = true;
            this.btn_parts_modify.Click += new System.EventHandler(this.btn_parts_modify_Click);
            // 
            // btn_parts_delete
            // 
            this.btn_parts_delete.Enabled = false;
            this.btn_parts_delete.Location = new System.Drawing.Point(642, 326);
            this.btn_parts_delete.Name = "btn_parts_delete";
            this.btn_parts_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_parts_delete.TabIndex = 11;
            this.btn_parts_delete.Text = "Delete";
            this.btn_parts_delete.UseVisualStyleBackColor = true;
            this.btn_parts_delete.Click += new System.EventHandler(this.btn_parts_delete_Click);
            // 
            // btn_products_add
            // 
            this.btn_products_add.Location = new System.Drawing.Point(1188, 326);
            this.btn_products_add.Name = "btn_products_add";
            this.btn_products_add.Size = new System.Drawing.Size(75, 23);
            this.btn_products_add.TabIndex = 12;
            this.btn_products_add.Text = "Add";
            this.btn_products_add.UseVisualStyleBackColor = true;
            this.btn_products_add.Click += new System.EventHandler(this.btn_products_add_Click);
            // 
            // btn_products_modify
            // 
            this.btn_products_modify.Enabled = false;
            this.btn_products_modify.Location = new System.Drawing.Point(1269, 326);
            this.btn_products_modify.Name = "btn_products_modify";
            this.btn_products_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_products_modify.TabIndex = 13;
            this.btn_products_modify.Text = "Modify";
            this.btn_products_modify.UseVisualStyleBackColor = true;
            this.btn_products_modify.Click += new System.EventHandler(this.btn_products_modify_Click);
            // 
            // btn_products_delete
            // 
            this.btn_products_delete.Enabled = false;
            this.btn_products_delete.Location = new System.Drawing.Point(1350, 326);
            this.btn_products_delete.Name = "btn_products_delete";
            this.btn_products_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_products_delete.TabIndex = 14;
            this.btn_products_delete.Text = "Delete";
            this.btn_products_delete.UseVisualStyleBackColor = true;
            this.btn_products_delete.Click += new System.EventHandler(this.btn_products_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1350, 430);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(42, 90);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(675, 230);
            this.dataGridView3.TabIndex = 16;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 514);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_products_delete);
            this.Controls.Add(this.btn_products_modify);
            this.Controls.Add(this.btn_products_add);
            this.Controls.Add(this.btn_parts_delete);
            this.Controls.Add(this.btn_parts_modify);
            this.Controls.Add(this.btn_parts_add);
            this.Controls.Add(this.btn_products_search);
            this.Controls.Add(this.btn_parts_search);
            this.Controls.Add(this.txtbox_products_search);
            this.Controls.Add(this.txtbox_parts_search);
            this.Controls.Add(this.lbl_products);
            this.Controls.Add(this.lbl_parts);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_parts;
        private System.Windows.Forms.Label lbl_products;
        private System.Windows.Forms.TextBox txtbox_parts_search;
        private System.Windows.Forms.TextBox txtbox_products_search;
        private System.Windows.Forms.Button btn_parts_search;
        private System.Windows.Forms.Button btn_products_search;
        private System.Windows.Forms.Button btn_parts_add;
        private System.Windows.Forms.Button btn_parts_modify;
        private System.Windows.Forms.Button btn_parts_delete;
        private System.Windows.Forms.Button btn_products_add;
        private System.Windows.Forms.Button btn_products_modify;
        private System.Windows.Forms.Button btn_products_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

