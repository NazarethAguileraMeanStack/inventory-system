using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NazarethAguileraFinalProjectC968
{
    public class Inventory
    {
        private List<Product> products = new List<Product>();
        private List<Part> all_parts = new List<Part>();

        public List<Part> get_all_parts() {
            return this.all_parts;
        }

        public List<Product> get_all_products() {
            return this.products;
        }

        public void add_product(Product new_product) {
            this.products.Add(new_product);
        }

        public bool remove_product(int id) {
            int currentSize = this.products.Count;

            for (int i = 0; i < this.products.Count; i++) {
                if (id == this.get_all_products()[i].ID) {
                    this.products.RemoveAt(i);
                }
            }

            if (currentSize == this.products.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Product lookup_product(int id) {
            return this.products[id - 1];
        }

        public void update_product(int index, Product new_product) {
            this.products[index] = new_product;
        }

        public void add_part(Part new_part) {
            this.all_parts.Add(new_part);
        }

        public bool delete_part(Part selected_part_for_deletion) {
            int currentSize = this.all_parts.Count;

            for (int i = 0; i < this.all_parts.Count; i++) {
                if (selected_part_for_deletion.ID == this.get_all_parts()[i].ID) {
                    this.all_parts.RemoveAt(i);
                }
            }

            if (currentSize == this.all_parts.Count)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public Part lookup_part(int id) {
            return this.all_parts[id - 1];
        }

        public void update_part(int index, Part new_part) {
            this.all_parts[index] = new_part;
        }

    }
}
