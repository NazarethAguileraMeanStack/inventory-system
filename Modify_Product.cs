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
    public partial class Modify_Product : Form
    {
        private Product current_product = new Product();

        public Modify_Product()
        {
            InitializeComponent();
        }

        private void btn_product_modify_cancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Modify_Product_Load(object sender, EventArgs e)
        {
            if (Form1.inventory.get_all_parts().Count != 0) {
                dataGridView1.DataSource = Form1.inventory.get_all_parts();
                btn_product_modify_add.Enabled = true;
            }

            current_product = Form1.current_selected_product;
            txtbox_product_modify_id.Text = current_product.ID.ToString();
            txtbox_product_modify_name.Text = current_product.Name;
            txtbox_product_modify_price.Text = current_product.Price.ToString();
            txtbox_product_modify_inventory.Text = current_product.In_stock.ToString();
            txtbox_product_modify_max.Text = current_product.Max.ToString();
            txtbox_product_modify_min.Text = current_product.Min.ToString();

            if (current_product.get_associated_parts().Count != 0) {
                dataGridView2.DataSource = current_product.get_associated_parts();
                btn_product_modify_delete.Enabled = true;
            }
        }

        private void check_valid_input(object sender, EventArgs e)
        {
            FormValidator formValidator = new FormValidator();
            btn_product_modify_save.Enabled = false;

            bool id = formValidator.check_int_validation(txtbox_product_modify_id.Text);
            bool name = formValidator.check_string_validation(txtbox_product_modify_name.Text);
            bool inventory = formValidator.check_int_validation(txtbox_product_modify_inventory.Text);
            bool price = formValidator.check_double_validation(txtbox_product_modify_price.Text);
            bool max = formValidator.check_int_validation(txtbox_product_modify_max.Text);
            bool min = formValidator.check_int_validation(txtbox_product_modify_min.Text);

            txtbox_product_modify_id.BackColor = (id) ? Color.White : Color.Red;
            txtbox_product_modify_name.BackColor = (name) ? Color.White : Color.Red;
            txtbox_product_modify_inventory.BackColor = (inventory) ? Color.White : Color.Red;
            txtbox_product_modify_price.BackColor = (price) ? Color.White : Color.Red;
            txtbox_product_modify_max.BackColor = (max) ? Color.White : Color.Red;
            txtbox_product_modify_min.BackColor = (min) ? Color.White : Color.Red;


            if (id && name && inventory && price && max && min)
            {
                int min_val = Convert.ToInt32(txtbox_product_modify_min.Text);
                int max_val = Convert.ToInt32(txtbox_product_modify_max.Text);
                int inventory_val = Convert.ToInt32(txtbox_product_modify_inventory.Text);

                if (formValidator.check_min_max_values(min_val, max_val) && formValidator.check_valid_inventory(min_val, inventory_val, max_val))
                {
                    txtbox_product_modify_max.BackColor = Color.White;
                    txtbox_product_modify_min.BackColor = Color.White;
                    txtbox_product_modify_inventory.BackColor = Color.White;
                    btn_product_modify_save.Enabled = true;
                }
                else
                {
                    txtbox_product_modify_max.BackColor = Color.Red;
                    txtbox_product_modify_min.BackColor = Color.Red;
                    txtbox_product_modify_inventory.BackColor = Color.Red;
                    btn_product_modify_save.Enabled = false;
                }


            }


        }

        private void btn_product_modify_add_Click(object sender, EventArgs e)
        {
            Part current_selected_part = dataGridView1.SelectedRows[0].DataBoundItem as Part;
            current_product.add_associated_part(current_selected_part);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = current_product.get_associated_parts();
            btn_product_modify_delete.Enabled = true;
        }

        private void btn_product_modify_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this Associated Part?", "Confirmation Needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    Part current_selected_associated_part = dataGridView2.SelectedRows[0].DataBoundItem as Part;
                    current_product.remove_associated_part(current_selected_associated_part.ID);
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = current_product.get_associated_parts();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Some error occured!" + error.Message + " - " + error.Source);
            }
        }

        private void btn_product_modify_save_Click(object sender, EventArgs e)
        {
            current_product.ID = Convert.ToInt32(txtbox_product_modify_id.Text);
            current_product.Name = txtbox_product_modify_name.Text;
            current_product.Price = Convert.ToDouble(txtbox_product_modify_price.Text);
            current_product.In_stock = Convert.ToInt32(txtbox_product_modify_inventory.Text);
            current_product.Max = Convert.ToInt32(txtbox_product_modify_max.Text);
            current_product.Min = Convert.ToInt32(txtbox_product_modify_min.Text);

            int current_id = Convert.ToInt32(txtbox_product_modify_id.Text);
            for (int i = 0; i < Form1.inventory.get_all_products().Count; i++)
            {
                if (Form1.inventory.get_all_products()[i].ID == current_id)
                {
                    Form1.inventory.update_product(i, current_product);
                    break;
                }
            }


            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
