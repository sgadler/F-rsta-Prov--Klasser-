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
            rarity = generator.Next(1,4);
            int slump = generator.Next(1,151);

            int rättPris = actualValue * rarity;


        }

        public string GetCategory()
        {
            List<string> category = new List<string>() {"book1","book2","book3"};
            int slump = generator.Next(1,4);
            string nothing = "";

            if (slump == 1)
            {
                return category[0];
            }
            if (slump == 2)
            {
                return category[1];
            }
            if (slump == 3)
            {
                return category[2];
            }
            else 
            {
                return nothing;
            }
        }

        public string GetName()
        {
            List<string> namn = new List<string>() {"namn1","namn2","namn3"};
            int slump = generator.Next(1,4);
            string nothing = "";

            if (slump == 1)
            {
                return namn[0];
            }
            if (slump == 2)
            {
                return namn[1];
            }
            if (slump == 3)
            {
                return namn[2];
            }
            else 
            {
                return nothing;
            }
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
