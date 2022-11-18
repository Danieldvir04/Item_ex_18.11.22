using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kuku
{
     class Drink:Item
    {
		private string _LiquidColor;

		public string LiquidColor
        {
			get { return _LiquidColor; }
		}

		//constructor
		public Drink(int ID,string nameLiquidColor):base(ID)
		{
			_LiquidColor = nameLiquidColor;
        }

        


	}
}
