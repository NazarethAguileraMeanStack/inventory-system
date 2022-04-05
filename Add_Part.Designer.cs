namespace NazarethAguileraFinalProjectC968
{
    partial class Add_Part
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
            this.radio_btn_part_add_inhouse = new System.Windows.Forms.RadioButton();
            this.radio_btn_part_add_outsourced = new System.Windows.Forms.RadioButton();
            this.lbl_part_add_id = new System.Windows.Forms.Label();
            this.lbl_part_add_name = new System.Windows.Forms.Label();
            this.lbl_part_add_inventory = new System.Windows.Forms.Label();
            this.lbl_part_add_price = new System.Windows.Forms.Label();
            this.lbl_part_add_max = new System.Windows.Forms.Label();
            this.lbl_part_add_machineId_or_companyName = new System.Windows.Forms.Label();
            this.txtbox_part_add_id = new System.Windows.Forms.TextBox();
            this.txtbox_part_add_name = new System.Windows.Forms.TextBox();
            this.txtbox_part_add_inventory = new System.Windows.Forms.TextBox();
            this.txtbox_part_add_price = new System.Windows.Forms.TextBox();
            this.txtbox_part_add_max = new System.Windows.Forms.TextBox();
            this.txtbox_add_part_machineID_or_companyName = new System.Windows.Forms.TextBox();
            this.txtbox_part_add_min = new System.Windows.Forms.TextBox();
            this.lbl_part_add_min = new System.Windows.Forms.Label();
            this.btn_part_add_save = new System.Windows.Forms.Button();
            this.btn_part_add_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(13, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(63, 17);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add Part";
            // 
            // radio_btn_part_add_inhouse
            // 
            this.radio_btn_part_add_inhouse.AutoSize = true;
            this.radio_btn_part_add_inhouse.Location = new System.Drawing.Point(239, 13);
            this.radio_btn_part_add_inhouse.Name = "radio_btn_part_add_inhouse";
            this.radio_btn_part_add_inhouse.Size = new System.Drawing.Size(86, 21);
            this.radio_btn_part_add_inhouse.TabIndex = 1;
            this.radio_btn_part_add_inhouse.TabStop = true;
            this.radio_btn_part_add_inhouse.Text = "In-House";
            this.radio_btn_part_add_inhouse.UseVisualStyleBackColor = true;
            this.radio_btn_part_add_inhouse.CheckedChanged += new System.EventHandler(this.radio_btn_part_add_inhouse_CheckedChanged);
            this.radio_btn_part_add_inhouse.Click += new System.EventHandler(this.check_valid_input);
            // 
            // radio_btn_part_add_outsourced
            // 
            this.radio_btn_part_add_outsourced.AutoSize = true;
            this.radio_btn_part_add_outsourced.Location = new System.Drawing.Point(429, 12);
            this.radio_btn_part_add_outsourced.Name = "radio_btn_part_add_outsourced";
            this.radio_btn_part_add_outsourced.Size = new System.Drawing.Size(103, 21);
            this.radio_btn_part_add_outsourced.TabIndex = 2;
            this.radio_btn_part_add_outsourced.TabStop = true;
            this.radio_btn_part_add_outsourced.Text = "Outsourced";
            this.radio_btn_part_add_outsourced.UseVisualStyleBackColor = true;
            this.radio_btn_part_add_outsourced.CheckedChanged += new System.EventHandler(this.radio_btn_part_add_outsourced_CheckedChanged);
            this.radio_btn_part_add_outsourced.Click += new System.EventHandler(this.check_valid_input);
            // 
            // lbl_part_add_id
            // 
            this.lbl_part_add_id.AutoSize = true;
            this.lbl_part_add_id.Location = new System.Drawing.Point(239, 90);
            this.lbl_part_add_id.Name = "lbl_part_add_id";
            this.lbl_part_add_id.Size = new System.Drawing.Size(29, 17);
            this.lbl_part_add_id.TabIndex = 3;
            this.lbl_part_add_id.Text = "I.D.";
            // 
            // lbl_part_add_name
            // 
            this.lbl_part_add_name.AutoSize = true;
            this.lbl_part_add_name.Location = new System.Drawing.Point(239, 150);
            this.lbl_part_add_name.Name = "lbl_part_add_name";
            this.lbl_part_add_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_part_add_name.TabIndex = 4;
            this.lbl_part_add_name.Text = "Name";
            // 
            // lbl_part_add_inventory
            // 
            this.lbl_part_add_inventory.AutoSize = true;
            this.lbl_part_add_inventory.Location = new System.Drawing.Point(239, 203);
            this.lbl_part_add_inventory.Name = "lbl_part_add_inventory";
            this.lbl_part_add_inventory.Size = new System.Drawing.Size(66, 17);
            this.lbl_part_add_inventory.TabIndex = 5;
            this.lbl_part_add_inventory.Text = "Inventory";
            // 
            // lbl_part_add_price
            // 
            this.lbl_part_add_price.AutoSize = true;
            this.lbl_part_add_price.Location = new System.Drawing.Point(239, 249);
            this.lbl_part_add_price.Name = "lbl_part_add_price";
            this.lbl_part_add_price.Size = new System.Drawing.Size(80, 17);
            this.lbl_part_add_price.TabIndex = 6;
            this.lbl_part_add_price.Text = "Price / Cost";
            // 
            // lbl_part_add_max
            // 
            this.lbl_part_add_max.AutoSize = true;
            this.lbl_part_add_max.Location = new System.Drawing.Point(239, 299);
            this.lbl_part_add_max.Name = "lbl_part_add_max";
            this.lbl_part_add_max.Size = new System.Drawing.Size(33, 17);
            this.lbl_part_add_max.TabIndex = 7;
            this.lbl_part_add_max.Text = "Max";
            // 
            // lbl_part_add_machineId_or_companyName
            // 
            this.lbl_part_add_machineId_or_companyName.AutoSize = true;
            this.lbl_part_add_machineId_or_companyName.Location = new System.Drawing.Point(239, 349);
            this.lbl_part_add_machineId_or_companyName.Name = "lbl_part_add_machineId_or_companyName";
            this.lbl_part_add_machineId_or_companyName.Size = new System.Drawing.Size(86, 17);
            this.lbl_part_add_machineId_or_companyName.TabIndex = 8;
            this.lbl_part_add_machineId_or_companyName.Text = "Machine I.D.";
            // 
            // txtbox_part_add_id
            // 
            this.txtbox_part_add_id.BackColor = System.Drawing.Color.Red;
            this.txtbox_part_add_id.Enabled = false;
            this.txtbox_part_add_id.Location = new System.Drawing.Point(376, 90);
            this.txtbox_part_add_id.Name = "txtbox_part_add_id";
            this.txtbox_part_add_id.ReadOnly = true;
            this.txtbox_part_add_id.Size = new System.Drawing.Size(100, 22);
            this.txtbox_part_add_id.TabIndex = 9;
            this.txtbox_part_add_id.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_part_add_name
            // 
            this.txtbox_part_add_name.BackColor = System.Drawing.Color.Red;
            this.txtbox_part_add_name.Location = new System.Drawing.Point(376, 147);
            this.txtbox_part_add_name.Name = "txtbox_part_add_name";
            this.txtbox_part_add_name.Size = new System.Drawing.Size(100, 22);
            this.txtbox_part_add_name.TabIndex = 10;
            this.txtbox_part_add_name.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_part_add_inventory
            // 
            this.txtbox_part_add_inventory.BackColor = System.Drawing.Color.Red;
            this.txtbox_part_add_inventory.Location = new System.Drawing.Point(376, 200);
            this.txtbox_part_add_inventory.Name = "txtbox_part_add_inventory";
            this.txtbox_part_add_inventory.Size = new System.Drawing.Size(100, 22);
            this.txtbox_part_add_inventory.TabIndex = 11;
            this.txtbox_part_add_inventory.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_part_add_price
            // 
            this.txtbox_part_add_price.BackColor = System.Drawing.Color.Red;
            this.txtbox_part_add_price.Location = new System.Drawing.Point(376, 249);
            this.txtbox_part_add_price.Name = "txtbox_part_add_price";
            this.txtbox_part_add_price.Size = new System.Drawing.Size(100, 22);
            this.txtbox_part_add_price.TabIndex = 12;
            this.txtbox_part_add_price.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_part_add_max
            // 
            this.txtbox_part_add_max.BackColor = System.Drawing.Color.Red;
            this.txtbox_part_add_max.Location = new System.Drawing.Point(376, 296);
            this.txtbox_part_add_max.Name = "txtbox_part_add_max";
            this.txtbox_part_add_max.Size = new System.Drawing.Size(51, 22);
            this.txtbox_part_add_max.TabIndex = 13;
            this.txtbox_part_add_max.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_add_part_machineID_or_companyName
            // 
            this.txtbox_add_part_machineID_or_companyName.Location = new System.Drawing.Point(376, 344);
            this.txtbox_add_part_machineID_or_companyName.Name = "txtbox_add_part_machineID_or_companyName";
            this.txtbox_add_part_machineID_or_companyName.Size = new System.Drawing.Size(100, 22);
            this.txtbox_add_part_machineID_or_companyName.TabIndex = 14;
            this.txtbox_add_part_machineID_or_companyName.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_part_add_min
            // 
            this.txtbox_part_add_min.BackColor = System.Drawing.Color.Red;
            this.txtbox_part_add_min.Location = new System.Drawing.Point(519, 296);
            this.txtbox_part_add_min.Name = "txtbox_part_add_min";
            this.txtbox_part_add_min.Size = new System.Drawing.Size(51, 22);
            this.txtbox_part_add_min.TabIndex = 15;
            this.txtbox_part_add_min.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // lbl_part_add_min
            // 
            this.lbl_part_add_min.AutoSize = true;
            this.lbl_part_add_min.Location = new System.Drawing.Point(483, 299);
            this.lbl_part_add_min.Name = "lbl_part_add_min";
            this.lbl_part_add_min.Size = new System.Drawing.Size(30, 17);
            this.lbl_part_add_min.TabIndex = 16;
            this.lbl_part_add_min.Text = "Min";
            // 
            // btn_part_add_save
            // 
            this.btn_part_add_save.Enabled = false;
            this.btn_part_add_save.Location = new System.Drawing.Point(543, 393);
            this.btn_part_add_save.Name = "btn_part_add_save";
            this.btn_part_add_save.Size = new System.Drawing.Size(75, 23);
            this.btn_part_add_save.TabIndex = 17;
            this.btn_part_add_save.Text = "Save";
            this.btn_part_add_save.UseVisualStyleBackColor = true;
            this.btn_part_add_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_part_add_cancel
            // 
            this.btn_part_add_cancel.Location = new System.Drawing.Point(641, 393);
            this.btn_part_add_cancel.Name = "btn_part_add_cancel";
            this.btn_part_add_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_part_add_cancel.TabIndex = 18;
            this.btn_part_add_cancel.Text = "Cancel";
            this.btn_part_add_cancel.UseVisualStyleBackColor = true;
            this.btn_part_add_cancel.Click += new System.EventHandler(this.btn_part_add_cancel_Click);
            // 
            // Add_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_part_add_cancel);
            this.Controls.Add(this.btn_part_add_save);
            this.Controls.Add(this.lbl_part_add_min);
            this.Controls.Add(this.txtbox_part_add_min);
            this.Controls.Add(this.txtbox_add_part_machineID_or_companyName);
            this.Controls.Add(this.txtbox_part_add_max);
            this.Controls.Add(this.txtbox_part_add_price);
            this.Controls.Add(this.txtbox_part_add_inventory);
            this.Controls.Add(this.txtbox_part_add_name);
            this.Controls.Add(this.txtbox_part_add_id);
            this.Controls.Add(this.lbl_part_add_machineId_or_companyName);
            this.Controls.Add(this.lbl_part_add_max);
            this.Controls.Add(this.lbl_part_add_price);
            this.Controls.Add(this.lbl_part_add_inventory);
            this.Controls.Add(this.lbl_part_add_name);
            this.Controls.Add(this.lbl_part_add_id);
            this.Controls.Add(this.radio_btn_part_add_outsourced);
            this.Controls.Add(this.radio_btn_part_add_inhouse);
            this.Controls.Add(this.lbl_title);
            this.Name = "Add_Part";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.Add_Part_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.RadioButton radio_btn_part_add_inhouse;
        private System.Windows.Forms.RadioButton radio_btn_part_add_outsourced;
        private System.Windows.Forms.Label lbl_part_add_id;
        private System.Windows.Forms.Label lbl_part_add_name;
        private System.Windows.Forms.Label lbl_part_add_inventory;
        private System.Windows.Forms.Label lbl_part_add_price;
        private System.Windows.Forms.Label lbl_part_add_max;
        private System.Windows.Forms.Label lbl_part_add_machineId_or_companyName;
        private System.Windows.Forms.TextBox txtbox_part_add_id;
        private System.Windows.Forms.TextBox txtbox_part_add_name;
        private System.Windows.Forms.TextBox txtbox_part_add_inventory;
        private System.Windows.Forms.TextBox txtbox_part_add_price;
        private System.Windows.Forms.TextBox txtbox_part_add_max;
        private System.Windows.Forms.TextBox txtbox_add_part_machineID_or_companyName;
        private System.Windows.Forms.TextBox txtbox_part_add_min;
        private System.Windows.Forms.Label lbl_part_add_min;
        private System.Windows.Forms.Button btn_part_add_save;
        private System.Windows.Forms.Button btn_part_add_cancel;
    }
}