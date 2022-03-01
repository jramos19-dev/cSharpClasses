using System;
using classesTutorial;

namespace GAME2
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("jorge", "ramos", 30, 3.9f);
            Student student2 = new Student("Collin", "Breedlove", 30, 3.0f);


            Console.WriteLine("jorge has honors" +student1.hasHonors());
            Console.WriteLine(student2.name + "has honors"+ student2.hasHonors());
            // G, PG, PG-13, R, NR


            Movie movie1 = new Movie("the avengers", "jorge camello", "PG");
            Movie movie2 = new Movie("the avengers 2", "jorge camello", "PG");

            Song song1 = new Song("kashmir", "led zeppelin", 3.0f, 300);
            Song song2 = new Song("walk", "pantera", 4.0f, 300);



            UsefulTools useless = new UsefulTools;
            //using a static method 

            UsefulTools.sayHI("mike");

            Console.WriteLine("what you doing");

            Console.ReadLine();

        }
    }
}
