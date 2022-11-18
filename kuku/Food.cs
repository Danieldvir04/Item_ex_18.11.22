using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuku
{
    internal class Food : Item
    {
        public int Weight { get; set; }

        //constractor
      public Food(int ID, int newWeight) : base(ID)
        {
            Weight = newWeight;
        }



    }
  
}
