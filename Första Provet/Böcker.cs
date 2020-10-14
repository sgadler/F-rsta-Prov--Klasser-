using System;

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

        }

        public string GetName()
        {
            string[] Namn = {"namn1","namn2","namn3"};

            if (book)
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
                
            }
        }
    }
}
