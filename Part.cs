using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NazarethAguileraFinalProjectC968
{
    public abstract class Part
    {
        private int _part_id = 0;
        private string _name = "";
        private double _price = 0.00;
        private int _in_stock = 0;
        private int _min = 0;
        private int _max = 100;

        public int ID {
            get {
                return _part_id;
            }
            set {
                _part_id = value;
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

        public int In_Stock {
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


    }
}
