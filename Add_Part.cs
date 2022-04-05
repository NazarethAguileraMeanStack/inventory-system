using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NazarethAguileraFinalProjectC968
{
    public partial class Add_Part : Form
    {

        

        public Add_Part()
        {
            InitializeComponent();
        }

        private void Add_Part_Load(object sender, EventArgs e)
        {
            int new_id = ++Form1.part_id_generator;
            txtbox_part_add_id.Text = new_id.ToString();
        }

        private void check_valid_input(object sender, EventArgs e) {
            FormValidator formValidator = new FormValidator();
            btn_part_add_save.Enabled = false;

            bool id = formValidator.check_int_validation(txtbox_part_add_id.Text);
            bool name = formValidator.check_string_validation(txtbox_part_add_name.Text);           
            bool in_stock = formValidator.check_int_validation(txtbox_part_add_inventory.Text);
            bool price = formValidator.check_double_validation(txtbox_part_add_price.Text);
            bool max = formValidator.check_int_validation(txtbox_part_add_max.Text);
            bool min = formValidator.check_int_validation(txtbox_part_add_min.Text);
            bool machine_or_outsourced;
            if (radio_btn_part_add_inhouse.Checked)
            {
                machine_or_outsourced = formValidator.check_int_validation(txtbox_add_part_machineID_or_companyName.Text);
            }
            else
            {
                machine_or_outsourced = formValidator.check_string_validation(txtbox_add_part_machineID_or_companyName.Text);
            }


            txtbox_part_add_id.BackColor = (id) ? Color.White : Color.Red;
            txtbox_part_add_name.BackColor = (name) ? Color.White : Color.Red;
            txtbox_part_add_inventory.BackColor = (in_stock) ? Color.White : Color.Red;
            txtbox_part_add_price.BackColor = (price) ? Color.White : Color.Red;
            txtbox_part_add_max.BackColor = (max) ? Color.White : Color.Red;
            txtbox_part_add_min.BackColor = (min) ? Color.White : Color.Red;
            txtbox_add_part_machineID_or_companyName.BackColor = (machine_or_outsourced) ? Color.White : Color.Red;



            if (id && name && in_stock && price && max && min && machine_or_outsourced) {
                int min_val = Convert.ToInt32(txtbox_part_add_min.Text);
                int max_val = Convert.ToInt32(txtbox_part_add_max.Text);
                int inventory_val = Convert.ToInt32(txtbox_part_add_inventory.Text);

                if (formValidator.check_min_max_values(min_val, max_val) && formValidator.check_valid_inventory(min_val, inventory_val, max_val))
                {
                    txtbox_part_add_max.BackColor = Color.White;
                    txtbox_part_add_min.BackColor = Color.White;
                    txtbox_part_add_inventory.BackColor = Color.White;
                    btn_part_add_save.Enabled = true;
                }
                else {
                    txtbox_part_add_max.BackColor = Color.Red;
                    txtbox_part_add_min.BackColor = Color.Red;
                    txtbox_part_add_inventory.BackColor = Color.Red;
                    btn_part_add_save.Enabled = false;
                }
                
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radio_btn_part_add_inhouse.Checked)
            {
                InHouse new_inhouse_part = build_inhouse_part();
                Form1.inventory.add_part(new_inhouse_part);
            }
            else {
                Outsourced new_outsourced_part = build_outsourced_part();
                Form1.inventory.add_part(new_outsourced_part);
            }

            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private InHouse build_inhouse_part() {
            InHouse part = new InHouse();

            part.ID = Convert.ToInt32(txtbox_part_add_id.Text);
            part.Name = txtbox_part_add_name.Text;
            part.In_Stock = Convert.ToInt32(txtbox_part_add_inventory.Text);
            part.Price = Convert.ToDouble(txtbox_part_add_price.Text);
            part.Max = Convert.ToInt32(txtbox_part_add_max.Text);
            part.Min = Convert.ToInt32(txtbox_part_add_min.Text);
            part.Machine_Id = Convert.ToInt32(txtbox_add_part_machineID_or_companyName.Text);

            return part;
        }

        private Outsourced build_outsourced_part() {
            Outsourced part = new Outsourced();

            part.ID = Convert.ToInt32(txtbox_part_add_id.Text);
            part.Name = txtbox_part_add_name.Text;
            part.In_Stock = Convert.ToInt32(txtbox_part_add_inventory.Text);
            part.Price = Convert.ToDouble(txtbox_part_add_price.Text);
            part.Max = Convert.ToInt32(txtbox_part_add_max.Text);
            part.Min = Convert.ToInt32(txtbox_part_add_min.Text);
            part.Company_Name = txtbox_add_part_machineID_or_companyName.Text;

            return part;
        }

        private void btn_part_add_cancel_Click(object sender, EventArgs e)
        {
            Form1.part_id_generator--;
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void radio_btn_part_add_inhouse_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_part_add_inhouse.Checked)
            {
                lbl_part_add_machineId_or_companyName.Text = "Machine I.D.";
            }
            else {
                lbl_part_add_machineId_or_companyName.Text = "Company Name";
            }
        }

        private void radio_btn_part_add_outsourced_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radio_btn_part_add_outsourced.Checked) {
                lbl_part_add_machineId_or_companyName.Text = "Company Name";
            }
            
        }
    }
}
