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
    public partial class Form1 : Form
    {
        public static Inventory inventory = new Inventory();
        public static int current_selected_part_index;
        public static int part_id_generator = 0;
        public static Product current_selected_product;
        public static int product_id_generator = 0;

        public Form1()
        {
            if (inventory.get_all_parts().Count != 0) {
                current_selected_part_index = 0;
            }

            if (inventory.get_all_products().Count != 0) {
                current_selected_product = inventory.get_all_products()[0];
            }
            InitializeComponent();
        }

        public void increment_part_id() {
            part_id_generator++;
        }

        public void decrement_part_id() {
            part_id_generator--;
        }

        public void increment_product_id() {
            product_id_generator++;
        }

        public void decrement_product_id() {
            product_id_generator--;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              if (inventory.get_all_parts().Count != 0) {
                dataGridView3.DataSource = inventory.get_all_parts();
                btn_parts_search.Enabled = true;
                btn_parts_modify.Enabled = true;
                btn_parts_delete.Enabled = true;
            }
            if (inventory.get_all_products().Count != 0) {
                dataGridView2.DataSource = inventory.get_all_products();
                btn_products_search.Enabled = true;
                btn_products_modify.Enabled = true;
                btn_products_delete.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_parts_add_Click(object sender, EventArgs e)
        {
            Add_Part add_part = new Add_Part();
            this.Hide();
            add_part.Show(); 
            
        }

        private void btn_parts_modify_Click(object sender, EventArgs e)
        {
            Modify_Part modify_part = new Modify_Part();
            this.Hide();
            modify_part.Show();
        }

        private void btn_products_add_Click(object sender, EventArgs e)
        {
            Add_Product add_product = new Add_Product();
            this.Hide();
            add_product.Show();
        }

        private void btn_products_modify_Click(object sender, EventArgs e)
        {
            Modify_Product modify_product = new Modify_Product();
            this.Hide();
            modify_product.Show();
        }

        // DATAGRIDVIEW EVENTS
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try {
                current_selected_part_index = dataGridView3.SelectedRows[0].Index;
            }
            catch (Exception error) {
                MessageBox.Show("Some error occured!" + error.Message + " - " + error.Source);
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                current_selected_product = dataGridView2.SelectedRows[0].DataBoundItem as Product;
            }
            catch (Exception error) {
                MessageBox.Show("Some error occured!" + error.Message + " - " + error.Source);
            }
        }

        // DELETE FUNCTIONS

        private void btn_parts_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this Part?", "Confirmation Needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (dialogResult == DialogResult.Yes) {
                    Part part_to_be_deleted = dataGridView3.SelectedRows[0].DataBoundItem as Part;
                    inventory.delete_part(part_to_be_deleted);
                    dataGridView3.DataSource = null;
                    dataGridView3.DataSource = inventory.get_all_parts();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Some error occured!" + error.Message + " - " + error.Source);
            }
        }

        private void btn_products_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this Product?","Confirmation Needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (dialogResult == DialogResult.Yes) {
                    current_selected_product = dataGridView2.SelectedRows[0].DataBoundItem as Product;
                    if (current_selected_product.get_associated_parts().Count != 0) {
                        MessageBox.Show("Cannot delete a Product with an Associated Part", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        inventory.remove_product(current_selected_product.ID);
                        dataGridView2.DataSource = null;
                        dataGridView2.DataSource = inventory.get_all_products();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Some error occured!" + error.Message + " - " + error.Source);
            }
        }

        private void txtbox_products_search_TextChanged(object sender, EventArgs e)
        {

        }


        // SEARCHING FUNCTIONS

        public void btn_parts_search_Click(object sender, EventArgs e)
        {
            List<Part> search_results = inventory.get_all_parts();
            List<Part> filter_results = search_results.Where(s => s.Name.ToLower().Contains(txtbox_parts_search.Text.ToLower())).ToList();
            dataGridView3.DataSource = filter_results;
        }

        private void update_parts_search_list(Object sender, EventArgs e) {
            if (txtbox_parts_search.Text.Length == 0) {
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = inventory.get_all_parts();
            }
        }

        private void update_products_search_list(Object sender, EventArgs e)
        {  
            if (txtbox_products_search.Text.Length == 0)
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = inventory.get_all_products();
            }
        }

        private void btn_products_search_Click(object sender, EventArgs e)
        {
            List<Product> search_results = inventory.get_all_products();
            List<Product> filter_results = search_results.Where(s => s.Name.ToLower().Contains(txtbox_products_search.Text.ToLower())).ToList();
            dataGridView2.DataSource = filter_results;
        }
    }
}
