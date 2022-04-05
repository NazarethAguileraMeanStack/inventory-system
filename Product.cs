using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NazarethAguileraFinalProjectC968
{
    public class Product
    {
        private List<Part> _associated_parts = new List<Part>();
        private int _product_id = 0;
        private string _name = "";
        private double _price = 0.00;
        private int _in_stock = 0;
        private int _min = 0;
        private int _max = 100;

        public int ID {
            get {
                return _product_id;
            }
            set {
                _product_id = value;
            }
        }

        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        public double Price {
            get {
                return _price;
            }
            set {
                _price = value;
            }
        }

        public int In_stock {
            get {
                return _in_stock;
            }
            set {
                _in_stock = value;
            }
        }

        public int Min {
            get {
                return _min;
            }
            set {
                _min = value;
            }
        }

        public int Max {
            get {
                return _max;
            }
            set {
                _max = value;
            }
        }



        public void add_associated_part(Part new_part) {
            this._associated_parts.Add(new_part);
        }

        public List<Part> get_associated_parts() {
            return this._associated_parts;
        }

        public bool remove_associated_part(int id) {
            int currentSize = this.get_associated_parts().Count;

            for (int i = 0; i < this.get_associated_parts().Count; i++)
            {
                if (id == this.get_associated_parts()[i].ID)
                {
                    this._associated_parts.RemoveAt(i);
                }
            }

            if (currentSize == this.get_associated_parts().Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Part lookup_associated_part(int id) {
            return this._associated_parts[id];
        }
    }
}
