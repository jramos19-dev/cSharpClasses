using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesTutorial
   {
    //italian cheff is a type of cheff 
    //therefore we can inherit from cheff 
    class ItalianChef :Cheff
    {
        public void makePasta()
        {
            Console.WriteLine("cheff makes pasta");
        }


        public override void MakeSpecialDish()
        {
            Console.WriteLine("cheff maskes chiken chimichanga");

        }
    }
}
