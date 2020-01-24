using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRING PRACTICE

            //var dinosaurs = new List<string>();
            //dinosaurs.Add("T-Rex");
            //dinosaurs.Add("Velociraptor");
            //dinosaurs.Add("Tricerotops");

            //for (int i = 0; i < dinosaurs.Count; i++)
            //{
            //    Console.WriteLine(dinosaurs[i]);
            //}

            //foreach(string item in dinosaurs)
            //{
            //    Console.WriteLine(item);
            //}



            //ARRAY PRACTICE
            //var dogs = new string[4];
            //dogs[0] = "Scooby-Doo";
            //dogs[1] = "Pluto";
            //dogs[2] = "Marmaduke";
            //dogs[3] = "Beethoven";
            //for (int i = 0; i<dogs.Length; i++)
            //{
            //    Console.WriteLine(dogs[i]);
            //}

            //more string practice
            var fibNumbers = new List<int> { 1, 1 };
            while (fibNumbers.Count < 20)
            {
                //for (int i = 2; i < 20; i++)
                //{
                var previous = fibNumbers[fibNumbers.Count - 1];
                var previous2 = fibNumbers[fibNumbers.Count - 2];
                fibNumbers.Add(previous + previous2);
                
            }
           

            foreach (var item in fibNumbers)
            {
                Console.WriteLine(item);
            }

        }

       
    }

}
