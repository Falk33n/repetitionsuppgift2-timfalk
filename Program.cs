namespace Repetitionsuppgift2 
{
    class Program 
    {
        static void Main() 
        {
            /* Variabler och Datatyper:
            1.	Skapa en C#-applikation där du deklarerar en variabel av typen int och tilldelar den värdet 42. Skriv ut variabelns värde till konsolen.

                int siffra = 42;

                Console.WriteLine(siffra); */

            /*  Strängar:
            2.	Skapa en C#-applikation där du skapar två strängvariabler, sammanslår dem och skriver ut resultatet till konsolen.

                string one = "Hej på ";
                string two = "dig!";

                Console.WriteLine(one + two); */

            /*  If-satser:
            3.	Skapa en C#-applikation där du tar emot ett tal från användaren och använder en if-sats för att kontrollera om talet är positivt, negativt eller noll. Skriv ut lämpliga meddelanden till konsolen baserat på resultatet.

                Console.WriteLine("Ange ett tal");

                string input = Console.Readline();

                int siffra = Convert.ToInt32(input);
                if (siffra > 0) 
                {
                    Console.Writeline("Talet är positivt.");
                } 
                else if (siffra < 0) 
                {
                    Console.Writeline("Talet är negativt.");
                } 
                else 
                {
                    Console.Writeline("Talet är lika med noll.");
                } */

            /* Loopar:
            4.	Skapa en C#-applikation där du använder en loop (t.ex. for eller while) för att skriva ut de jämna talen mellan 1 och 20 till konsolen.

                for (int i = 1; i <= 20; i++) 
                {
                    if (i % 2 == 0) 
                    {
                        Console.WriteLine(i);
                    }
                } */

            /* Arrayer:
            5.	Skapa en C#-applikation där du skapar en array med 5 heltal. Fyll arrayen med värden och skriv sedan ut varje element till konsolen.

                int[] heltal = new int[5];

                heltal [0] = 5;
                heltal [1] = 10;
                heltal [2] = 15;
                heltal [3] = 20;
                heltal [4] = 25;

                for (int i = 0; i < heltal.Length; i++) 
                {
                    Console.WriteLine($"{i + 1}. {heltal[i]}.");
                } */

            /* Variabler och Datatyper:
            6.	Skapa en C#-applikation där du deklarerar och tilldelar värden till variabler av olika datatyper (t.ex. int, double, char) och skriver ut dem till konsolen.

                int tal1 = 10;
                double tal2 = 41513513513;
                char bokstav = 'X';
                string ord = "hello";

                Console.WriteLine($"{tal1} {tal2} {bokstav} {ord}"); */

            /* Strängar:
            7.	Skapa en C#-applikation där du tar emot en sträng från användaren och skriver ut den baklänges till konsolen.

                Console.WriteLine("Ge mig en text:");

                string orginal = Console.ReadLine();

                char[] array = orginal.ToCharArray();
                Array.Reverse(array);
                string bakvänt = new string(array);

                Console.WriteLine(bakvänt); */

            /* If-satser:
            8.	Skapa en C#-applikation där du tar emot två tal från användaren och använder en if-sats för att kontrollera om det första talet är större än det andra. Skriv ut lämpliga meddelanden till konsolen baserat på resultatet.
                
                Console.WriteLine("Mata in ett tal:");

                int tal1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Mata in ytterligare ett tal:");

                int tal2 = int.Parse(Console.ReadLine());

                if (tal1 > tal2> 
                {
                    Console.WriteLine("Det första talet är större än det andra talet.");
                } 
                else If (tal1 < tal2> 
                {
                    Console.WriteLine("Det första talet är mindre än det andra talet.");
                } 
                else 
                {
                    Console.WriteLine("Felaktig inmatning (Icke heltal eller båda talen har samma värde).");
                } */

            /* Loopar:
            9.	Skapa en C#-applikation där du använder en loop (t.ex. for eller while) för att skriva ut multiplikationstabellen för ett givet tal upp till 10 till konsolen.

                Console.WriteLine("Mata in ett valfritt heltal:");

                int input = int.Parse(Console.ReadLine());

                Console.WriteLine("Multiplikationstabellen för talet är följande");

                for (int i = 0; i < 11; i++) 
                {
                    Console.WriteLine($"{i}. {i} * {input} = {i * input}");
                } */

            /* Arrayer:
            10.	Skapa en C#-applikation där du skapar en array med namn på olika frukter. Använd en loop för att skriva ut varje frukt till konsolen.

                string[] frukter = new string[5];

                frukter[0] = ”Banan”;
                frukter[1] = ”Äpple”;
                frukter[2] = ”Kiwi”;
                frukter[3] = ”Jordgubbe”;
                frukter[4] = ”Ananas”;
                
                for (int i = 0; i < frukter.Length; i++) 
                {
                    Console.WriteLine($"{i + 1}. {frukter[i]}");
                } */

            /* Random:
            11.	Skriv en C#-applikation där du använder Random-klassen för att generera ett slumpmässigt heltal mellan 1 och 100. Skriv sedan ut detta slumpmässiga heltal till konsolen. Efter det, generera ett slumpmässigt decimaltal mellan 0 och 1 och skriv också ut detta till konsolen.

                Random random = new Random();

                int helTal = random.Next(1, 101);

                Console.WriteLine($"Den slumpmässigt valda heltal siffran blev: {helTal}.");
                
                float decimalTal = (float)(random.NextDouble() * (1.0 – 0.0) + 0.0);

                Console.WriteLine($"Den slumpmässigt valda decimal siffran blev: {decimalTal}."); */
/* --------------------------------------------------------------------------------------------------------------------------------------------- */
            /* Uppgift: 
            12. Hantering av betyg

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            bool fortsättProgrammet = true; // bool för att avgöra om programmet ska fortsättas

            do 
            {
                Console.WriteLine("Ange elevens poäng (Ett heltal mellan \"0\" - \"100\")");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out int poäng)) 
                {
                    Console.Clear();

                    if (poäng >= 90 && poäng <= 100) 
                    {
                        Console.WriteLine("Eleven får betyget: A");
                    } 
                    else if (poäng >= 80 && poäng <= 89) 
                    {
                        Console.WriteLine("Eleven får betyget: B");
                    } 
                    else if (poäng >= 70 && poäng <= 79) 
                    {
                        Console.WriteLine("Eleven får betyget: C");
                    } 
                    else if (poäng >= 60 && poäng <= 69) 
                    {
                        Console.WriteLine("Eleven får betyget: D");
                    } 
                    else if (poäng >= 50 && poäng <= 59) 
                    {
                        Console.WriteLine("Eleven får betyget: E");
                    } 
                    else if (poäng >= 0 && poäng <= 49) 
                    {
                        Console.WriteLine("Eleven får betyget: F");
                    } 
                    else 
                    {
                        Console.WriteLine("Felaktig inmatning, vänligen ange ett heltal mellan \"0\" - \"100\""); // Felaktig inmatning vid siffor
                        Console.WriteLine();

                        continue;
                    }
                } 
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Felaktig inmatning, vänligen ange ett heltal mellan \"0\" - \"100\""); // Felaktig inmatning vid bokstäver
                    Console.WriteLine();

                    continue;
                }

                bool förändratProgrammet = false; // bool för att avgöra om användaren gjort ett val ja / nej

                do 
                {
                    Console.WriteLine();
                    Console.WriteLine("Vill du ange en ny elevs poäng? (\"Ja\" / \"Nej\")");
                    Console.WriteLine();

                    string programHanterare = Console.ReadLine().ToLower();

                    if (programHanterare == "ja") 
                    {
                        Console.Clear();
                        förändratProgrammet = true;
                    } 
                    else if (programHanterare == "nej") 
                    {
                        Console.Clear();
                        Console.Write("Avslutar programmet");
                        Thread.Sleep(333);

                        for (int i = 0; i < 4; i++) {
                            Console.Write("  .");
                            Thread.Sleep(600);
                        }

                        förändratProgrammet = true;
                        fortsättProgrammet = false;
                    } 
                    else 
                    {
                        Console.Clear();
                        Console.WriteLine("Felaktig inmatning, vänligen ange: \"Ja\" / \"Nej\"");
                    }
                } 
                while (!förändratProgrammet); // loopa tills förändratProgrammet = true
            } 
            while (fortsättProgrammet); // loopa tills fortsättProgrammet = false */
        }
    }
}