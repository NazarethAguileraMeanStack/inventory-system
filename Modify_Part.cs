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
    public partial class Modify_Part : Form
    {
        public Modify_Part()
        {
            InitializeComponent();
        }

        private void btn_part_modify_cancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void radio_btn_part_modify_inhouse_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_part_modify_inhouse.Checked) {
                lbl_part_modify_machineId_or_companyName.Text = "Machine I.D.";
            }
        }

        private void radio_btn_part_modify_outsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_part_modify_outsourced.Checked) {
                lbl_part_modify_machineId_or_companyName.Text = "Company Name";
            } 
        }

        private void Modify_Part_Load(object sender, EventArgs e)
        {
            var current_part = Form1.inventory.get_all_parts()[Form1.current_selected_part_index];

            txtbox_part_modify_id.Text = current_part.ID.ToString();
            txtbox_part_modify_name.Text = current_part.Name;
            txtbox_part_modify_inventory.Text = current_part.In_Stock.ToString();
            txtbox_part_modify_price.Text = current_part.Price.ToString();
            txtbox_part_modify_max.Text = current_part.Max.ToString();
            txtbox_part_modify_min.Text = current_part.Min.ToString();
            if (current_part is InHouse) {
                InHouse _part = (InHouse)current_part;
                txtbox_part_modify_machineID_or_companyName.Text = _part.Machine_Id.ToString();
                radio_btn_part_modify_inhouse.Checked = true;
            }
            else {
                Outsourced _part = (Outsourced)current_part;
                txtbox_part_modify_machineID_or_companyName.Text = _part.Company_Name;
                radio_btn_part_modify_outsourced.Checked = true;
            }
        }

        private void btn_part_modify_save_Click(object sender, EventArgs e)
        {
            
            if (radio_btn_part_modify_inhouse.Checked)
            {
                InHouse updated_part = build_inhouse_part();
                int current_id = Convert.ToInt32(txtbox_part_modify_id.Text);
                for (int i = 0; i < Form1.inventory.get_all_parts().Count; i++)
                {
                    if (Form1.inventory.get_all_parts()[i].ID == current_id)
                    {
                        Form1.inventory.update_part(i, updated_part);
                        break;
                    }
                }
            }
            else
            {
                Outsourced updated_part = build_outsourced_part();
                int current_id = Convert.ToInt32(txtbox_part_modify_id.Text);
                for (int i = 0; i < Form1.inventory.get_all_parts().Count; i++)
                {
                    if (Form1.inventory.get_all_parts()[i].ID == current_id)
                    {
                        Form1.inventory.update_part(i, updated_part);
                        break;
                    }
                }
            }


            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private InHouse build_inhouse_part()
        {
            InHouse part = new InHouse();

            part.ID = Convert.ToInt32(txtbox_part_modify_id.Text);
            part.Name = txtbox_part_modify_name.Text;
            part.In_Stock = Convert.ToInt32(txtbox_part_modify_inventory.Text);
            part.Price = Convert.ToDouble(txtbox_part_modify_price.Text);
            part.Max = Convert.ToInt32(txtbox_part_modify_max.Text);
            part.Min = Convert.ToInt32(txtbox_part_modify_min.Text);
            part.Machine_Id = Convert.ToInt32(txtbox_part_modify_machineID_or_companyName.Text);

            return part;
        }

        private Outsourced build_outsourced_part()
        {
            Outsourced part = new Outsourced();

            part.ID = Convert.ToInt32(txtbox_part_modify_id.Text);
            part.Name = txtbox_part_modify_name.Text;
            part.In_Stock = Convert.ToInt32(txtbox_part_modify_inventory.Text);
            part.Price = Convert.ToDouble(txtbox_part_modify_price.Text);
            part.Max = Convert.ToInt32(txtbox_part_modify_max.Text);
            part.Min = Convert.ToInt32(txtbox_part_modify_min.Text);
            part.Company_Name = txtbox_part_modify_machineID_or_companyName.Text;

            return part;
        }

        private void check_valid_input(object sender, EventArgs e)
        {
            FormValidator formValidator = new FormValidator();
            btn_part_modify_save.Enabled = false;

            bool id = formValidator.check_int_validation(txtbox_part_modify_id.Text);
            bool name = formValidator.check_string_validation(txtbox_part_modify_name.Text);
            bool in_stock = formValidator.check_int_validation(txtbox_part_modify_inventory.Text);
            bool price = formValidator.check_double_validation(txtbox_part_modify_price.Text);
            bool max = formValidator.check_int_validation(txtbox_part_modify_max.Text);
            bool min = formValidator.check_int_validation(txtbox_part_modify_min.Text);
            bool machine_or_outsourced;
            if (radio_btn_part_modify_inhouse.Checked)
            {
                machine_or_outsourced = formValidator.check_int_validation(txtbox_part_modify_machineID_or_companyName.Text);
            }
            else {
                machine_or_outsourced = formValidator.check_string_validation(txtbox_part_modify_machineID_or_companyName.Text);
            }
           



            txtbox_part_modify_id.BackColor = (id) ? Color.White : Color.Red;
            txtbox_part_modify_name.BackColor = (name) ? Color.White : Color.Red;
            txtbox_part_modify_inventory.BackColor = (in_stock) ? Color.White : Color.Red;
            txtbox_part_modify_price.BackColor = (price) ? Color.White : Color.Red;
            txtbox_part_modify_max.BackColor = (max) ? Color.White : Color.Red;
            txtbox_part_modify_min.BackColor = (min) ? Color.White : Color.Red;
            txtbox_part_modify_machineID_or_companyName.BackColor = (machine_or_outsourced) ? Color.White : Color.Red;




            if (id && name && in_stock && price && max && min && machine_or_outsourced)
            {
                int min_val = Convert.ToInt32(txtbox_part_modify_min.Text);
                int max_val = Convert.ToInt32(txtbox_part_modify_max.Text);
                int inventory_val = Convert.ToInt32(txtbox_part_modify_inventory.Text);

                if (formValidator.check_min_max_values(min_val, max_val) && formValidator.check_valid_inventory(min_val, inventory_val, max_val))
                {
                    txtbox_part_modify_max.BackColor = Color.White;
                    txtbox_part_modify_min.BackColor = Color.White;
                    txtbox_part_modify_inventory.BackColor = Color.White;
                    btn_part_modify_save.Enabled = true;
                }
                else
                {
                    txtbox_part_modify_max.BackColor = Color.Red;
                    txtbox_part_modify_min.BackColor = Color.Red;
                    txtbox_part_modify_inventory.BackColor = Color.Red;
                    btn_part_modify_save.Enabled = false;
                }

            }

        }
    }
}
