using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "kursbir";
            string kurs2 = "kursiki";
            string kurs3 = "kursuc";
            //array - dizi

            string[] kurslar = new string[] { "kursbir", "kursiki", "kursuc","kursdort" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }
           
    

    
    }




        
}
