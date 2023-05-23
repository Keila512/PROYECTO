using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INVENTARIO
{
    public class Operations : Product
    {
        public int amount;

        public int Amount
        {
            get { return amount; }
            set { amount= value; }
        }

        public Operations() : base()
        {
            amount= 0;
        }
        public Operations(int amount) : base()
        {
            this.amount = amount;          
        }
        public override string ToString()
        {
            return base.ToString() + amount;
        }


    }
}
