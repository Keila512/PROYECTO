using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INVENTARIO
{
    internal class Product2 : Product
    {
		public int exit;

		public int Exit
		{
			get { return exit; }
			set { exit = value; }
		}
		public int stock;

		public int Stock
		{
			get { return stock; }
			set { stock = value; }
		}

		public Product2() 
		{
			exit = 0;
			stock = 0;
		}
		public Product2(int exit, int stock)
		{
			this.exit = exit;
			this.stock = stock;
		}
		public override string ToString() 
		{
			return base.ToString() + exit + stock;
		
		}


	}
}
