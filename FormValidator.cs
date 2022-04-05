using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NazarethAguileraFinalProjectC968
{
    class FormValidator
    {
        public bool check_int_validation(string text) {
            try
            {   if (text.Length == 0) return false;
                int result = Convert.ToInt32(text);
            }
            catch (OverflowException)
            {
                return false;
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }

        public bool check_double_validation(string text) {
            try
            {
                if (text.Length == 0) return false;
                double result = Convert.ToDouble(text);
            }
            catch (OverflowException)
            {
                return false;
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }

        public bool check_string_validation(string text) {

            if (text.Length > 0 && text.Length < 20)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool check_min_max_values(int min, int max) {
            if (min < max) {
                return true;
            } else
            {
                return false;
            }
        }

        public bool check_valid_inventory(int min, int inventory, int max) {
            if (inventory > min && inventory < max) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
