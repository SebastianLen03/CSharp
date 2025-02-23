namespace Lekcja1
{
    internal class Program
    {
        /// <summary>
        /// komenrzarz dokumentacyjny
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Podstawy

            //Console.WriteLine("Podaj swoje imię: ");
            //string name;
            //name = Console.ReadLine();
            //Console.WriteLine($"Twoje imię to: {name}");

            // komentarz

            /* komentarz
             * wieloliniowy
             */

            //Zmienne

            //string zmienna = "Hello World";
            //string a, b = "!", c;
            //a = "!";
            //Console.WriteLine(zmienna + a + b);

            //Stałe

            //const string LANGUAGE = "C#";
            ////language = "Java";
            //Console.WriteLine(LANGUAGE);
            //Console.WriteLine(Math.PI);

            //Typy danych [liczby całkowite]

            byte varByte = 3; // 0 - 255
            Console.WriteLine(varByte);
            Console.WriteLine($"Byte min: {byte.MinValue}, Byte max: {byte.MaxValue}");

            short varShort = 30000; // -32 768 - 32 767
            Console.WriteLine(varShort);
            Console.WriteLine($"Byte min: {short.MinValue}, Byte max: {short.MaxValue}");

            int varInt = 2000000000; // -2 147 483 648 - 2 147 483 647
            Console.WriteLine(varInt);
            Console.WriteLine($"Byte min: {int.MinValue}, Byte max: {int.MaxValue}");

            long varLong = 2000000000000000000; // -9 223 372 036 854 775 808 - 9 223 372 036 854 775 807
            Console.WriteLine(varLong);
            Console.WriteLine($"Byte min: {long.MinValue}, Byte max: {long.MaxValue}");
        }
    }
}
