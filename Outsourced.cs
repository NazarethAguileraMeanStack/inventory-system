using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NazarethAguileraFinalProjectC968
{
    public class Outsourced : Part
    {
        private string _company_name = "";

        public string Company_Name
        {
            get
            {
                return _company_name;
            }
            set
            {
                _company_name = value;
            }
        }

    }
}
