using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesTutorial
{
    class Student
    {

        //some class properties should be private because they should only be accessible to the class 
        //where it was created.
        public string name;
        public string lastName;
        public int age;
        private float gpa; 
    
        


        public Student(string _name, string _last, int _age, float _gpa)
        {
            name = _name;
            lastName = _last;
            age = _age;
            gpa = _gpa; 

        }

      
         // this is an object method because every instance of this class 
         // will have the ability to use its own version of this method.

        public bool hasHonors()
        {
            if (gpa >= 3.4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
