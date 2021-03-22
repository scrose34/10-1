using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Account_Test
{
    class CDAccount : SavingsAccount
    {
        //Field
        private string _maturitryDate;

        //Construcctor
        public CDAccount ()
        {
            _maturitryDate = "";
        }
        //MaturityDate property
        public string maturityDate
        {
            get { return _maturitryDate; }
            set { _maturitryDate = value; }
        }
    }
}
