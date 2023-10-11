using System;
using System.CodeDom.Compiler;

namespace probaprobaproba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Feladat

            Adott egy string, pl.: "HELLOW ORLD!"

            1. Számoljuk meg a két szóban lévő karakterek számát (pl. HELLOW (6), ORLD!(5))
            2. Fordítsuk meg ezt a két számot (6, 5 -> 5, 6)
            3. Írjuk vissza az eredeti stringet a megfordított számoknak megfelelően: HELLOW ORLD -> HELLO WORLD!
            
            */
            // Eredeti string
            string message = "HELLOW ORLD!";

            // Eredeti string hossza
            int allCharacters = message.Length; // 12

            // Hol a szóköz? (+ milyen hosszú, hátha kell)
            int space = message.IndexOf(' '); // 6 -> 6. indexen van (7. karakter)
            string spacestring = space.ToString();
            int spaceLength = spacestring.Length;

            // Szétbontjuk a stringet
            string part1 = message.Substring(0, space); // "HELLOW"
            string part2 = message.Substring(space + 1); // "ORLD!"

            // A szétbontott stringek hossza
            int part1length = part1.Length; // 6 (HELLOW)
            int part2length = part2.Length; // 5 (ORLD!)

            // Megcseréljük a szétbontott stringek hosszát -> part1 = 5, part2 = 6
            int temp = 0;
            temp = part1length; // 6
            part1length = part2length; // 5
            part2length = temp; // 6 

            // Elkészítjük az új part 1-et -> cél: HELLOW -> HELLO
            char[] newPart1 = new char[part1length];

            for (int i = 0; i < part1length; i++)
            {
                newPart1[i] = part1[i]; // HELLO -> ez eddig jó
            }

            // Elkészítjük az új part 2-t -> cél: ORLD! -> WORLD!

            // Ötlet: eredeti stringből kivenni a szóközt, készíteni egy új stringet, hátha segít a második szóban
            string trimmedMessage = message.Replace(" ", ""); // HELLOW ORLD! -> HELLOWORLD!
            int trimmedMessageLength = trimmedMessage.Length; // Ez így 11 (az eredeti, szóközzel 12)
            
            char[] newPart2 = new char[part2length];

            for(int i = part1length+1; i < trimmedMessageLength+1; i++)
            {
                newPart2[i] = trimmedMessage[i]; // IndexOutOfRangeException
            }
            
        }
    }
}
