using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesTutorial
{
    class Cheff
    {
        public void MakeChicken()
        {
            Console.WriteLine("cheff makes chicken");
        }

        public void makeSalad()
        {
            Console.WriteLine("cheff makes salad");

        }
        //inheritence 


        // virtual means subclasses can overwrite the functionality. 
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("the cheff makes bbq ribs");
        }

    }
}
