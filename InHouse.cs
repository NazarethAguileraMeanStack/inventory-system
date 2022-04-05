using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NazarethAguileraFinalProjectC968
{
    public class InHouse : Part
    {
        private int _machine_id = -1;

        public int Machine_Id
        {
            get
            {
                return _machine_id;
            }
            set
            {
                _machine_id = value;
            }
        }

    }

    
}
