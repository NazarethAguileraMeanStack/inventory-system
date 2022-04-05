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
    public partial class Add_Product : Form
    {
        private Product new_product = new Product();

        public Add_Product()
        {
            InitializeComponent();
        }

        private void btn_product_add_cancel_Click(object sender, EventArgs e)
        {
            Form1.product_id_generator--;
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            try
            {
                int new_id = ++Form1.product_id_generator;
                txtbox_product_add_id.Text = new_id.ToString();
                if (Form1.inventory.get_all_parts().Count != 0) {
                    dataGridView1.DataSource = Form1.inventory.get_all_parts();
                    btn_product_add_add.Enabled = true;
                }
                
            }
            catch (Exception error) {
                MessageBox.Show("Some error occured! " + error.Message + " - " + error.Source);
            }
            
            
            
        }

        private void btn_product_add_add_Click(object sender, EventArgs e)
        {
            try
            {
                Part selected_part = dataGridView1.SelectedRows[0].DataBoundItem as Part;
                this.new_product.add_associated_part(selected_part);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = this.new_product.get_associated_parts();
                btn_product_add_delete.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Some error occured! " + error.Message + " - " + error.Source);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

            }
            catch (Exception error) {
                MessageBox.Show("Some error occured! " + error.Message + " - " + error.Source);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_product_add_save_Click(object sender, EventArgs e)
        {

            this.new_product.ID = Convert.ToInt32(txtbox_product_add_id.Text);
            this.new_product.Name = txtbox_product_add_name.Text;
            this.new_product.In_stock = Convert.ToInt32(txtbox_product_add_inventory.Text);
            this.new_product.Price = Convert.ToDouble(txtbox_product_add_price.Text);
            this.new_product.Max = Convert.ToInt32(txtbox_product_add_max.Text);
            this.new_product.Min = Convert.ToInt32(txtbox_product_add_min.Text);
            Form1.inventory.add_product(this.new_product);

            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();

        }

        private void check_valid_input(object sender, EventArgs e)
        {
            FormValidator formValidator = new FormValidator();
            btn_product_add_save.Enabled = false;

            bool id = formValidator.check_int_validation(txtbox_product_add_id.Text);
            bool name = formValidator.check_string_validation(txtbox_product_add_name.Text);
            bool inventory = formValidator.check_int_validation(txtbox_product_add_inventory.Text);
            bool price = formValidator.check_double_validation(txtbox_product_add_price.Text);
            bool max = formValidator.check_int_validation(txtbox_product_add_max.Text);
            bool min = formValidator.check_int_validation(txtbox_product_add_min.Text);

            txtbox_product_add_id.BackColor = (id) ? Color.White : Color.Red;
            txtbox_product_add_name.BackColor = (name) ? Color.White : Color.Red;
            txtbox_product_add_inventory.BackColor = (inventory) ? Color.White : Color.Red;
            txtbox_product_add_price.BackColor = (price) ? Color.White : Color.Red;
            txtbox_product_add_max.BackColor = (max) ? Color.White : Color.Red;
            txtbox_product_add_min.BackColor = (min) ? Color.White : Color.Red;


            if (id && name && inventory && price && max && min)
            {
                int min_val = Convert.ToInt32(txtbox_product_add_min.Text);
                int max_val = Convert.ToInt32(txtbox_product_add_max.Text);
                int inventory_val = Convert.ToInt32(txtbox_product_add_inventory.Text);

                if (formValidator.check_min_max_values(min_val, max_val) && formValidator.check_valid_inventory(min_val, inventory_val, max_val))
                {
                    txtbox_product_add_max.BackColor = Color.White;
                    txtbox_product_add_min.BackColor = Color.White;
                    txtbox_product_add_inventory.BackColor = Color.White;
                    btn_product_add_save.Enabled = true;
                }
                else
                {
                    txtbox_product_add_max.BackColor = Color.Red;
                    txtbox_product_add_min.BackColor = Color.Red;
                    txtbox_product_add_inventory.BackColor = Color.Red;
                    btn_product_add_save.Enabled = false;
                }


            }


        }

        private void btn_product_add_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this Associated Part?", "Confirmation Needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    Part associated_selected_part = dataGridView2.SelectedRows[0].DataBoundItem as Part;
                    this.new_product.remove_associated_part(associated_selected_part.ID);
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = this.new_product.get_associated_parts();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Some error occured!" + error.Message + " - " + error.Source);
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception error)
            {
                MessageBox.Show("Some error occured! " + error.Message + " - " + error.Source);
            }
        }


        // SEARCH FUNCTION
        private void btn_product_add_search_Click(object sender, EventArgs e)
        {
            List<Part> search_results = Form1.inventory.get_all_parts();
            List<Part> filter_results = search_results.Where(s => s.Name.ToLower().Contains(txtbox_product_add_search.Text.ToLower())).ToList();
            dataGridView1.DataSource = filter_results;
        }

        private void update_parts_search_list(Object sender, EventArgs e)
        {
            if (txtbox_product_add_search.Text.Length == 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Form1.inventory.get_all_parts();
            }
        }
    }
}
