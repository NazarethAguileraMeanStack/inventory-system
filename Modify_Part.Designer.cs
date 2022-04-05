namespace NazarethAguileraFinalProjectC968
{
    partial class Modify_Part
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
            this.btn_part_modify_cancel = new System.Windows.Forms.Button();
            this.btn_part_modify_save = new System.Windows.Forms.Button();
            this.lbl_part_modify_min = new System.Windows.Forms.Label();
            this.txtbox_part_modify_min = new System.Windows.Forms.TextBox();
            this.txtbox_part_modify_machineID_or_companyName = new System.Windows.Forms.TextBox();
            this.txtbox_part_modify_max = new System.Windows.Forms.TextBox();
            this.txtbox_part_modify_price = new System.Windows.Forms.TextBox();
            this.txtbox_part_modify_inventory = new System.Windows.Forms.TextBox();
            this.txtbox_part_modify_name = new System.Windows.Forms.TextBox();
            this.txtbox_part_modify_id = new System.Windows.Forms.TextBox();
            this.lbl_part_modify_machineId_or_companyName = new System.Windows.Forms.Label();
            this.lbl_part_modify_max = new System.Windows.Forms.Label();
            this.lbl_part_modify_price = new System.Windows.Forms.Label();
            this.lbl_part_modify_inventory = new System.Windows.Forms.Label();
            this.lbl_part_modify_name = new System.Windows.Forms.Label();
            this.lbl_part_modify_id = new System.Windows.Forms.Label();
            this.radio_btn_part_modify_outsourced = new System.Windows.Forms.RadioButton();
            this.radio_btn_part_modify_inhouse = new System.Windows.Forms.RadioButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_part_modify_cancel
            // 
            this.btn_part_modify_cancel.Location = new System.Drawing.Point(677, 404);
            this.btn_part_modify_cancel.Name = "btn_part_modify_cancel";
            this.btn_part_modify_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_part_modify_cancel.TabIndex = 37;
            this.btn_part_modify_cancel.Text = "Cancel";
            this.btn_part_modify_cancel.UseVisualStyleBackColor = true;
            this.btn_part_modify_cancel.Click += new System.EventHandler(this.btn_part_modify_cancel_Click);
            // 
            // btn_part_modify_save
            // 
            this.btn_part_modify_save.Location = new System.Drawing.Point(579, 404);
            this.btn_part_modify_save.Name = "btn_part_modify_save";
            this.btn_part_modify_save.Size = new System.Drawing.Size(75, 23);
            this.btn_part_modify_save.TabIndex = 36;
            this.btn_part_modify_save.Text = "Save";
            this.btn_part_modify_save.UseVisualStyleBackColor = true;
            this.btn_part_modify_save.Click += new System.EventHandler(this.btn_part_modify_save_Click);
            // 
            // lbl_part_modify_min
            // 
            this.lbl_part_modify_min.AutoSize = true;
            this.lbl_part_modify_min.Location = new System.Drawing.Point(469, 312);
            this.lbl_part_modify_min.Name = "lbl_part_modify_min";
            this.lbl_part_modify_min.Size = new System.Drawing.Size(30, 17);
            this.lbl_part_modify_min.TabIndex = 35;
            this.lbl_part_modify_min.Text = "Min";
            // 
            // txtbox_part_modify_min
            // 
            this.txtbox_part_modify_min.Location = new System.Drawing.Point(505, 309);
            this.txtbox_part_modify_min.Name = "txtbox_part_modify_min";
            this.txtbox_part_modify_min.Size = new System.Drawing.Size(51, 22);
            this.txtbox_part_modify_min.TabIndex = 34;
            this.txtbox_part_modify_min.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_part_modify_machineID_or_companyName
            // 
            this.txtbox_part_modify_machineID_or_companyName.Location = new System.Drawing.Point(358, 356);
            this.txtbox_part_modify_machineID_or_companyName.Name = "txtbox_part_modify_machineID_or_companyName";
            this.txtbox_part_modify_machineID_or_companyName.Size = new System.Drawing.Size(100, 22);
            this.txtbox_part_modify_machineID_or_companyName.TabIndex = 33;
            this.txtbox_part_modify_machineID_or_companyName.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_part_modify_max
            // 
            this.txtbox_part_modify_max.Location = new System.Drawing.Point(358, 309);
            this.txtbox_part_modify_max.Name = "txtbox_part_modify_max";
            this.txtbox_part_modify_max.Size = new System.Drawing.Size(51, 22);
            this.txtbox_part_modify_max.TabIndex = 32;
            this.txtbox_part_modify_max.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_part_modify_price
            // 
            this.txtbox_part_modify_price.Location = new System.Drawing.Point(358, 257);
            this.txtbox_part_modify_price.Name = "txtbox_part_modify_price";
            this.txtbox_part_modify_price.Size = new System.Drawing.Size(100, 22);
            this.txtbox_part_modify_price.TabIndex = 31;
            this.txtbox_part_modify_price.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_part_modify_inventory
            // 
            this.txtbox_part_modify_inventory.Location = new System.Drawing.Point(358, 211);
            this.txtbox_part_modify_inventory.Name = "txtbox_part_modify_inventory";
            this.txtbox_part_modify_inventory.Size = new System.Drawing.Size(100, 22);
            this.txtbox_part_modify_inventory.TabIndex = 30;
            this.txtbox_part_modify_inventory.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_part_modify_name
            // 
            this.txtbox_part_modify_name.Location = new System.Drawing.Point(358, 156);
            this.txtbox_part_modify_name.Name = "txtbox_part_modify_name";
            this.txtbox_part_modify_name.Size = new System.Drawing.Size(100, 22);
            this.txtbox_part_modify_name.TabIndex = 29;
            this.txtbox_part_modify_name.TextChanged += new System.EventHandler(this.check_valid_input);
            // 
            // txtbox_part_modify_id
            // 
            this.txtbox_part_modify_id.Enabled = false;
            this.txtbox_part_modify_id.Location = new System.Drawing.Point(358, 101);
            this.txtbox_part_modify_id.Name = "txtbox_part_modify_id";
            this.txtbox_part_modify_id.ReadOnly = true;
            this.txtbox_part_modify_id.Size = new System.Drawing.Size(100, 22);
            this.txtbox_part_modify_id.TabIndex = 28;
            // 
            // lbl_part_modify_machineId_or_companyName
            // 
            this.lbl_part_modify_machineId_or_companyName.AutoSize = true;
            this.lbl_part_modify_machineId_or_companyName.Location = new System.Drawing.Point(242, 359);
            this.lbl_part_modify_machineId_or_companyName.Name = "lbl_part_modify_machineId_or_companyName";
            this.lbl_part_modify_machineId_or_companyName.Size = new System.Drawing.Size(86, 17);
            this.lbl_part_modify_machineId_or_companyName.TabIndex = 27;
            this.lbl_part_modify_machineId_or_companyName.Text = "Machine I.D.";
            // 
            // lbl_part_modify_max
            // 
            this.lbl_part_modify_max.AutoSize = true;
            this.lbl_part_modify_max.Location = new System.Drawing.Point(242, 312);
            this.lbl_part_modify_max.Name = "lbl_part_modify_max";
            this.lbl_part_modify_max.Size = new System.Drawing.Size(33, 17);
            this.lbl_part_modify_max.TabIndex = 26;
            this.lbl_part_modify_max.Text = "Max";
            // 
            // lbl_part_modify_price
            // 
            this.lbl_part_modify_price.AutoSize = true;
            this.lbl_part_modify_price.Location = new System.Drawing.Point(242, 260);
            this.lbl_part_modify_price.Name = "lbl_part_modify_price";
            this.lbl_part_modify_price.Size = new System.Drawing.Size(80, 17);
            this.lbl_part_modify_price.TabIndex = 25;
            this.lbl_part_modify_price.Text = "Price / Cost";
            // 
            // lbl_part_modify_inventory
            // 
            this.lbl_part_modify_inventory.AutoSize = true;
            this.lbl_part_modify_inventory.Location = new System.Drawing.Point(242, 214);
            this.lbl_part_modify_inventory.Name = "lbl_part_modify_inventory";
            this.lbl_part_modify_inventory.Size = new System.Drawing.Size(66, 17);
            this.lbl_part_modify_inventory.TabIndex = 24;
            this.lbl_part_modify_inventory.Text = "Inventory";
            // 
            // lbl_part_modify_name
            // 
            this.lbl_part_modify_name.AutoSize = true;
            this.lbl_part_modify_name.Location = new System.Drawing.Point(242, 161);
            this.lbl_part_modify_name.Name = "lbl_part_modify_name";
            this.lbl_part_modify_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_part_modify_name.TabIndex = 23;
            this.lbl_part_modify_name.Text = "Name";
            // 
            // lbl_part_modify_id
            // 
            this.lbl_part_modify_id.AutoSize = true;
            this.lbl_part_modify_id.Location = new System.Drawing.Point(242, 101);
            this.lbl_part_modify_id.Name = "lbl_part_modify_id";
            this.lbl_part_modify_id.Size = new System.Drawing.Size(29, 17);
            this.lbl_part_modify_id.TabIndex = 22;
            this.lbl_part_modify_id.Text = "I.D.";
            // 
            // radio_btn_part_modify_outsourced
            // 
            this.radio_btn_part_modify_outsourced.AutoSize = true;
            this.radio_btn_part_modify_outsourced.Location = new System.Drawing.Point(431, 9);
            this.radio_btn_part_modify_outsourced.Name = "radio_btn_part_modify_outsourced";
            this.radio_btn_part_modify_outsourced.Size = new System.Drawing.Size(103, 21);
            this.radio_btn_part_modify_outsourced.TabIndex = 21;
            this.radio_btn_part_modify_outsourced.TabStop = true;
            this.radio_btn_part_modify_outsourced.Text = "Outsourced";
            this.radio_btn_part_modify_outsourced.UseVisualStyleBackColor = true;
            this.radio_btn_part_modify_outsourced.CheckedChanged += new System.EventHandler(this.radio_btn_part_modify_outsourced_CheckedChanged);
            this.radio_btn_part_modify_outsourced.Click += new System.EventHandler(this.check_valid_input);
            // 
            // radio_btn_part_modify_inhouse
            // 
            this.radio_btn_part_modify_inhouse.AutoSize = true;
            this.radio_btn_part_modify_inhouse.Location = new System.Drawing.Point(245, 7);
            this.radio_btn_part_modify_inhouse.Name = "radio_btn_part_modify_inhouse";
            this.radio_btn_part_modify_inhouse.Size = new System.Drawing.Size(86, 21);
            this.radio_btn_part_modify_inhouse.TabIndex = 20;
            this.radio_btn_part_modify_inhouse.TabStop = true;
            this.radio_btn_part_modify_inhouse.Text = "In-House";
            this.radio_btn_part_modify_inhouse.UseVisualStyleBackColor = true;
            this.radio_btn_part_modify_inhouse.CheckedChanged += new System.EventHandler(this.radio_btn_part_modify_inhouse_CheckedChanged);
            this.radio_btn_part_modify_inhouse.Click += new System.EventHandler(this.check_valid_input);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(79, 17);
            this.lbl_title.TabIndex = 19;
            this.lbl_title.Text = "Modify Part";
            // 
            // Modify_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_part_modify_cancel);
            this.Controls.Add(this.btn_part_modify_save);
            this.Controls.Add(this.lbl_part_modify_min);
            this.Controls.Add(this.txtbox_part_modify_min);
            this.Controls.Add(this.txtbox_part_modify_machineID_or_companyName);
            this.Controls.Add(this.txtbox_part_modify_max);
            this.Controls.Add(this.txtbox_part_modify_price);
            this.Controls.Add(this.txtbox_part_modify_inventory);
            this.Controls.Add(this.txtbox_part_modify_name);
            this.Controls.Add(this.txtbox_part_modify_id);
            this.Controls.Add(this.lbl_part_modify_machineId_or_companyName);
            this.Controls.Add(this.lbl_part_modify_max);
            this.Controls.Add(this.lbl_part_modify_price);
            this.Controls.Add(this.lbl_part_modify_inventory);
            this.Controls.Add(this.lbl_part_modify_name);
            this.Controls.Add(this.lbl_part_modify_id);
            this.Controls.Add(this.radio_btn_part_modify_outsourced);
            this.Controls.Add(this.radio_btn_part_modify_inhouse);
            this.Controls.Add(this.lbl_title);
            this.Name = "Modify_Part";
            this.Text = "Modify_Part";
            this.Load += new System.EventHandler(this.Modify_Part_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_part_modify_cancel;
        private System.Windows.Forms.Button btn_part_modify_save;
        private System.Windows.Forms.Label lbl_part_modify_min;
        private System.Windows.Forms.TextBox txtbox_part_modify_min;
        private System.Windows.Forms.TextBox txtbox_part_modify_machineID_or_companyName;
        private System.Windows.Forms.TextBox txtbox_part_modify_max;
        private System.Windows.Forms.TextBox txtbox_part_modify_price;
        private System.Windows.Forms.TextBox txtbox_part_modify_inventory;
        private System.Windows.Forms.TextBox txtbox_part_modify_name;
        private System.Windows.Forms.TextBox txtbox_part_modify_id;
        private System.Windows.Forms.Label lbl_part_modify_machineId_or_companyName;
        private System.Windows.Forms.Label lbl_part_modify_max;
        private System.Windows.Forms.Label lbl_part_modify_price;
        private System.Windows.Forms.Label lbl_part_modify_inventory;
        private System.Windows.Forms.Label lbl_part_modify_name;
        private System.Windows.Forms.Label lbl_part_modify_id;
        private System.Windows.Forms.RadioButton radio_btn_part_modify_outsourced;
        private System.Windows.Forms.RadioButton radio_btn_part_modify_inhouse;
        private System.Windows.Forms.Label lbl_title;
    }
}