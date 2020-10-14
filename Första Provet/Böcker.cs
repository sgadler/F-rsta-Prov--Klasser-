using System;
using System.Collections.Generic;
namespace Första Provet
{
    public class Böcker
    {
        public int price;
        
        string name;

        int rarity;

        string category;

        int actualValue;

        bool cursed;

        Random generator = new Random(); 

        public book()
        {

        }

        public void PrintInfo()
        {

        }

        public int Evaluate()
        {
        
        }

        public string GetCategory()
        {
            string[]
        }

        public string GetName()
        {
            List<string> namn = new List<string>() {"namn1","namn2","namn3"};
            int slump = generator.Next(1,4);
            string name;

            if (slump == 1)
            {
                name = namn[0];
                Console.WriteLine(name);
            }
            if (slump == 2)
            {
                name = namn[1];
                Console.WriteLine(name);
            }
            if (slump == 3)
            {
                name = namn[2];
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

        public bool IsCursed()
        {
            int slump = generator.Next(1,11);

            if (slump <= 8)
            {
                return cursed; 
            }
            else
            {
                return cursed = true||false;
            }
        }
    }
}
