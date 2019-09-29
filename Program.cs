using System;

namespace Gissa_talet
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Du ska gissa ett nummer mellan 1 och 100");
  
		Random random = new Random();
		int rättNummer = random.Next(1, 100);
		int gissning = 0;
        int antalFörsök = 0;
        //System.Console.WriteLine(rättNummer);
        //Testat med att ta fram randomsiffra. Flyttat ner antalförsök++ till efter try&catch. Annars plussar den även
        //på felinmatat format(text). 

        //Medans man gissar fel...			
		while (gissning != rättNummer)
		{
                System.Console.Write("Gissa tal: ");
                
                //try and catch är med i whileloop och körs varje gång användaren inte matar in ett heltal(ToInt32).
                try
                {
				string svar = Console.ReadLine();
				gissning = Convert.ToInt32(svar);
                }
                catch
				{	
				System.Console.WriteLine("**Du måste skriva en siffra**");
				continue;
				}
                antalFörsök++;

                //Villkor inte lika med gissning annars om lika med gissning.
                //Gissar man fel, jämför gissning mot rättnummer/random. Mindre eller större.
                

				if (gissning != rättNummer)
				{
                      if(gissning > rättNummer)
                      {
                         System.Console.WriteLine("Fel. Talet är mindre.");
                      }
                      else if (gissning < rättNummer)
                      {
                        System.Console.WriteLine("Fel. Talet är större.");      
                }
                //Gissar man rätt, grattis. Antal försök skrivs.
				}
                else if(gissning == rättNummer)
                {
                System.Console.WriteLine("**Grattis! Du gissade rätt!**");
                System.Console.WriteLine("Det tog dig {0} försök för att gissa rätt nummer!", antalFörsök);
                
                }
		}
        
        }
    }
}
