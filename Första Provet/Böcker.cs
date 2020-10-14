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
            // Här har vi hur jag gjort för att få fram "rätt pris" genom att bara slumpa fram rarity därför jag inte har något system för det.
            int rättPris = actualValue * rarity;


        }

        public string GetCategory()
        {
            List<string> category = new List<string>() {"book1","book2","book3"};
            int slump = generator.Next(1,4);
            // har bara "nothing" eftersom metoden behövde skicka tillbaka värde hela tiden o det var det snabbaste jag kom på.
            string nothing = "";
            // har gjort så här på både "GetName" och "GetCategory" då jag först gjort en lista.
            // Sen har jag gjort en slump generator som ska välja vilken typ av kategori boken man plockat upp har genom att plocka ett motsvarande värde -1 i listan.
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
            // Se över.
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

            // Tror inte det här kommer fungera som jag vill.
            // Har gjort en slump generator som bestämmer ett tal mellan 1-10 som ska motsvara 10%;
            // där dem första 80 är dem som skulle vara "rätt svar" och dem andra 20 "fel svar",
            // tänkte att jag kunde skicka tillbaka cursed som både eftersom den inte vet hur den kommer in.
            // då kan jag sedan i main bestämma motsatta. 
            // men jag har inte listat ut hur riktigt äm :P
            
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
