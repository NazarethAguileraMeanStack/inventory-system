namespace NazarethAguileraFinalProjectC968
{
    partial class Add_Product
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
            this.lbl_product_add_title = new System.Windows.Forms.Label();
            this.lbl_product_add_id = new System.Windows.Forms.Label();
            this.lbl_product_add_name = new System.Windows.Forms.Label();
            this.lbl_product_add_inventory = new System.Windows.Forms.Label();
            this.lbl_product_add_price = new System.Windows.Forms.Label();
            this.lbl_product_add_max = new System.Windows.Forms.Label();
            this.lbl_product_add_min = new System.Windows.Forms.Label();
            this.txtbox_product_add_id = new System.Windows.Forms.TextBox();
            this.txtbox_product_add_name = new System.Windows.Forms.TextBox();
            this.txtbox_product_add_inventory = new System.Windows.Forms.TextBox();
            this.txtbox_product_add_price = new System.Windows.Forms.TextBox();
            this.txtbox_product_add_min = new System.Windows.Forms.TextBox();
            this.txtbox_product_add_max = new System.Windows.Forms.TextBox();
            this.btn_product_add_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_product_add_add = new System.Windows.Forms.Button();
            this.btn_product_add_delete = new System.Windows.Forms.Button();
            this.btn_product_add_save = new System.Windows.Forms.Button();
            this.btn_product_add_cancel = new System.Windows.Forms.Button();
            this.txtbox_product_add_search = new System.Windows.Forms.TextBox();
            this.lbl_product_add_candidates = new System.Windows.Forms.Label();
            this.lbl_product_add_parts_associated = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_product_add_title
            // 
            this.lbl_product_add_title.AutoSize = true;
            this.lbl_product_add_title.Location = new System.Drawing.Point(13, 13);
            this.lbl_product_add_title.Name = "lbl_product_add_title";
            this.lbl_product_add_title.Size = new System.Drawing.Size(86, 17);
            this.lbl_product_add_title.TabIndex = 0;
            this.lbl_product_add_title.Text = "Add Product";
            // 
            // lbl_product_add_id
            // 
            this.lbl_product_add_id.AutoSize = true;
            this.lbl_product_add_id.Location = new System.Drawing.Point(65, 175);
            this.lbl_product_add_id.Name = "lbl_product_add_id";
            this.lbl_product_add_id.Size = new System.Drawing.Size(29, 17);
            this.lbl_product_add_id.TabIndex = 1;
            this.lbl_product_add_id.Text = "I.D.";
            // 
            // lbl_product_add_name
            // 
            this.lbl_product_add_name.AutoSize = true;
            this.lbl_product_add_name.Location = new System.Drawing.Point(65, 219);
            this.lbl_product_add_name.Name = "lbl_product_add_name";
            this.lbl_product_add_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_product_add_name.TabIndex = 2;
            this.lbl_product_add_name.Text = "Name";
            // 
            // lbl_product_add_inventory
            // 
            this.lbl_product_add_inventory.AutoSize = true;
            this.lbl_product_add_inventory.Location = new System.Drawing.Point(64, 261);
            this.lbl_product_add_inventory.Name = "lbl_product_add_inventory";
            this.lbl_product_add_inventory.Size = new System.Drawing.Size(66, 17);
            this.lbl_product_add_inventory.TabIndex = 3;
            this.lbl_product_add_inventory.Text = "Inventory";
            // 
            // lbl_product_add_price
            // 
            this.lbl_product_add_price.AutoSize = true;
            this.lbl_product_add_price.Location = new System.Drawing.Point(65, 302);
            this.lbl_product_add_price.Name = "lbl_product_add_price";
            this.lbl_product_add_price.Size = new System.Drawing.Size(40, 17);
            this.lbl_product_add_price.TabIndex = 4;
            this.lbl_product_add_price.Text = "Price";
            // 
            // lbl_product_add_max
            // 
            this.lbl_product_add_max.AutoSize = true;
            this.lbl_product_add_max.Location = new System.Drawing.Point(65, 348);
            this.lbl_product_add_max.Name = "lbl_product_add_max";
            this.lbl_product_add_max.Size = new System.Drawing.Size(33, 17);
            this.lbl_product_add_max.TabIndex = 5;
            this.lbl_product_add_max.Text = "Max";
            // 
            // lbl_product_add_min
            // 
            this.lbl_product_add_min.AutoSize = true;
            this.lbl_product_add_min.Location = new System.Drawing.Point(212, 348);
            this.lbl_product_add_min.Name = "lbl_product_add_min";
            this.lbl_product_add_min.Size = new System.Drawing.Size(30, 17);
            this.lbl_product_add_min.TabIndex = 6;
            this.lbl_product_add_min.Text = "Min";
            // 
            // txtbox_product_add_id
            // 
            this.txtbox_product_add_id.BackColor = System.Drawing.Color.Red;
            this.txtbox_product_add_id.Enabled = false;
            this.txtbox_product_add_id.Location = new System.Drawing.Point(158, 175);
            this.txtbox_product_add_id.Name = "txtbox_product_add_id";
            this.txtbox_product_add_id.ReadOnly = true;
            this.txtbox_product_add_id.Size = new System.Drawing.Size(100, 22);
            this.txtbox_product_add_id.TabIndex = 7;
            this.txtbox_product_add_id.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_product_add_name
            // 
            this.txtbox_product_add_name.BackColor = System.Drawing.Color.Red;
            this.txtbox_product_add_name.Location = new System.Drawing.Point(158, 219);
            this.txtbox_product_add_name.Name = "txtbox_product_add_name";
            this.txtbox_product_add_name.Size = new System.Drawing.Size(100, 22);
            this.txtbox_product_add_name.TabIndex = 8;
            this.txtbox_product_add_name.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_product_add_inventory
            // 
            this.txtbox_product_add_inventory.BackColor = System.Drawing.Color.Red;
            this.txtbox_product_add_inventory.Location = new System.Drawing.Point(158, 258);
            this.txtbox_product_add_inventory.Name = "txtbox_product_add_inventory";
            this.txtbox_product_add_inventory.Size = new System.Drawing.Size(100, 22);
            this.txtbox_product_add_inventory.TabIndex = 9;
            this.txtbox_product_add_inventory.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_product_add_price
            // 
            this.txtbox_product_add_price.BackColor = System.Drawing.Color.Red;
            this.txtbox_product_add_price.Location = new System.Drawing.Point(158, 302);
            this.txtbox_product_add_price.Name = "txtbox_product_add_price";
            this.txtbox_product_add_price.Size = new System.Drawing.Size(100, 22);
            this.txtbox_product_add_price.TabIndex = 10;
            this.txtbox_product_add_price.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_product_add_min
            // 
            this.txtbox_product_add_min.BackColor = System.Drawing.Color.Red;
            this.txtbox_product_add_min.Location = new System.Drawing.Point(264, 348);
            this.txtbox_product_add_min.Name = "txtbox_product_add_min";
            this.txtbox_product_add_min.Size = new System.Drawing.Size(52, 22);
            this.txtbox_product_add_min.TabIndex = 11;
            this.txtbox_product_add_min.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_product_add_max
            // 
            this.txtbox_product_add_max.BackColor = System.Drawing.Color.Red;
            this.txtbox_product_add_max.Location = new System.Drawing.Point(117, 348);
            this.txtbox_product_add_max.Name = "txtbox_product_add_max";
            this.txtbox_product_add_max.Size = new System.Drawing.Size(52, 22);
            this.txtbox_product_add_max.TabIndex = 12;
            this.txtbox_product_add_max.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // btn_product_add_search
            // 
            this.btn_product_add_search.Location = new System.Drawing.Point(855, 18);
            this.btn_product_add_search.Name = "btn_product_add_search";
            this.btn_product_add_search.Size = new System.Drawing.Size(75, 23);
            this.btn_product_add_search.TabIndex = 13;
            this.btn_product_add_search.Text = "Search";
            this.btn_product_add_search.UseVisualStyleBackColor = true;
            this.btn_product_add_search.Click += new System.EventHandler(this.btn_product_add_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(521, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(521, 248);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(680, 150);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn_product_add_add
            // 
            this.btn_product_add_add.Enabled = false;
            this.btn_product_add_add.Location = new System.Drawing.Point(1126, 203);
            this.btn_product_add_add.Name = "btn_product_add_add";
            this.btn_product_add_add.Size = new System.Drawing.Size(75, 23);
            this.btn_product_add_add.TabIndex = 16;
            this.btn_product_add_add.Text = "Add";
            this.btn_product_add_add.UseVisualStyleBackColor = true;
            this.btn_product_add_add.Click += new System.EventHandler(this.btn_product_add_add_Click);
            // 
            // btn_product_add_delete
            // 
            this.btn_product_add_delete.Enabled = false;
            this.btn_product_add_delete.Location = new System.Drawing.Point(1126, 404);
            this.btn_product_add_delete.Name = "btn_product_add_delete";
            this.btn_product_add_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_product_add_delete.TabIndex = 17;
            this.btn_product_add_delete.Text = "Delete";
            this.btn_product_add_delete.UseVisualStyleBackColor = true;
            this.btn_product_add_delete.Click += new System.EventHandler(this.btn_product_add_delete_Click);
            // 
            // btn_product_add_save
            // 
            this.btn_product_add_save.Enabled = false;
            this.btn_product_add_save.Location = new System.Drawing.Point(1045, 470);
            this.btn_product_add_save.Name = "btn_product_add_save";
            this.btn_product_add_save.Size = new System.Drawing.Size(75, 23);
            this.btn_product_add_save.TabIndex = 18;
            this.btn_product_add_save.Text = "Save";
            this.btn_product_add_save.UseVisualStyleBackColor = true;
            this.btn_product_add_save.Click += new System.EventHandler(this.btn_product_add_save_Click);
            // 
            // btn_product_add_cancel
            // 
            this.btn_product_add_cancel.Location = new System.Drawing.Point(1126, 470);
            this.btn_product_add_cancel.Name = "btn_product_add_cancel";
            this.btn_product_add_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_product_add_cancel.TabIndex = 19;
            this.btn_product_add_cancel.Text = "Cancel";
            this.btn_product_add_cancel.UseVisualStyleBackColor = true;
            this.btn_product_add_cancel.Click += new System.EventHandler(this.btn_product_add_cancel_Click);
            // 
            // txtbox_product_add_search
            // 
            this.txtbox_product_add_search.Location = new System.Drawing.Point(936, 19);
            this.txtbox_product_add_search.Name = "txtbox_product_add_search";
            this.txtbox_product_add_search.Size = new System.Drawing.Size(265, 22);
            this.txtbox_product_add_search.TabIndex = 20;
            this.txtbox_product_add_search.TextChanged += new System.EventHandler(this.update_parts_search_list);
            // 
            // lbl_product_add_candidates
            // 
            this.lbl_product_add_candidates.AutoSize = true;
            this.lbl_product_add_candidates.Location = new System.Drawing.Point(521, 24);
            this.lbl_product_add_candidates.Name = "lbl_product_add_candidates";
            this.lbl_product_add_candidates.Size = new System.Drawing.Size(128, 17);
            this.lbl_product_add_candidates.TabIndex = 21;
            this.lbl_product_add_candidates.Text = "All Candidate Parts";
            // 
            // lbl_product_add_parts_associated
            // 
            this.lbl_product_add_parts_associated.AutoSize = true;
            this.lbl_product_add_parts_associated.Location = new System.Drawing.Point(521, 225);
            this.lbl_product_add_parts_associated.Name = "lbl_product_add_parts_associated";
            this.lbl_product_add_parts_associated.Size = new System.Drawing.Size(221, 17);
            this.lbl_product_add_parts_associated.TabIndex = 22;
            this.lbl_product_add_parts_associated.Text = "Parts Associated with this Product";
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 523);
            this.Controls.Add(this.lbl_product_add_parts_associated);
            this.Controls.Add(this.lbl_product_add_candidates);
            this.Controls.Add(this.txtbox_product_add_search);
            this.Controls.Add(this.btn_product_add_cancel);
            this.Controls.Add(this.btn_product_add_save);
            this.Controls.Add(this.btn_product_add_delete);
            this.Controls.Add(this.btn_product_add_add);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_product_add_search);
            this.Controls.Add(this.txtbox_product_add_max);
            this.Controls.Add(this.txtbox_product_add_min);
            this.Controls.Add(this.txtbox_product_add_price);
            this.Controls.Add(this.txtbox_product_add_inventory);
            this.Controls.Add(this.txtbox_product_add_name);
            this.Controls.Add(this.txtbox_product_add_id);
            this.Controls.Add(this.lbl_product_add_min);
            this.Controls.Add(this.lbl_product_add_max);
            this.Controls.Add(this.lbl_product_add_price);
            this.Controls.Add(this.lbl_product_add_inventory);
            this.Controls.Add(this.lbl_product_add_name);
            this.Controls.Add(this.lbl_product_add_id);
            this.Controls.Add(this.lbl_product_add_title);
            this.Name = "Add_Product";
            this.Text = "Add_Product";
            this.Load += new System.EventHandler(this.Add_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_product_add_title;
        private System.Windows.Forms.Label lbl_product_add_id;
        private System.Windows.Forms.Label lbl_product_add_name;
        private System.Windows.Forms.Label lbl_product_add_inventory;
        private System.Windows.Forms.Label lbl_product_add_price;
        private System.Windows.Forms.Label lbl_product_add_max;
        private System.Windows.Forms.Label lbl_product_add_min;
        private System.Windows.Forms.TextBox txtbox_product_add_id;
        private System.Windows.Forms.TextBox txtbox_product_add_name;
        private System.Windows.Forms.TextBox txtbox_product_add_inventory;
        private System.Windows.Forms.TextBox txtbox_product_add_price;
        private System.Windows.Forms.TextBox txtbox_product_add_min;
        private System.Windows.Forms.TextBox txtbox_product_add_max;
        private System.Windows.Forms.Button btn_product_add_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_product_add_add;
        private System.Windows.Forms.Button btn_product_add_delete;
        private System.Windows.Forms.Button btn_product_add_save;
        private System.Windows.Forms.Button btn_product_add_cancel;
        private System.Windows.Forms.TextBox txtbox_product_add_search;
        private System.Windows.Forms.Label lbl_product_add_candidates;
        private System.Windows.Forms.Label lbl_product_add_parts_associated;
    }
}