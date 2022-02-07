using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_C
{
    class Program
    {
        static void Main(string[] args)
        {
            // harjutus 1

            //        string pileti_tuup;
            //        double hind = 10;
            //        Console.WriteLine("Mis on sinu nimi?");
            //        string eesnimi = Console.ReadLine();
            //        Console.Write("Tere tulemast! {0}",eesnimi);

            //        if (eesnimi.ToLower()=="juku")
            //        {
            //            Console.WriteLine(" tule külla, lähme kinno?");
            //            string vastus = Console.ReadLine();
            //            if (vastus.ToUpper()=="JAH" || vastus.ToUpper()=="YES" || vastus.ToUpper()=="ДА")
            //            {
            //                Console.WriteLine("Kui ´vana sa oled?");
            //                int vanus = int.Parse(Console.ReadLine());
            //                if (vanus < 0 || vanus > 108)
            //                {
            //                    Console.WriteLine("Viga!");
            //                }
            //                else if (vanus<6 || vanus>=65)
            //                {
            //                    hind -= hind * 1;
            //                    pileti_tuup = "Tasuta";
            //                    if (vanus>=65)
            //                    {
            //                        pileti_tuup = "Sooduspilet";
            //                    }
            //                }
            //                else if(vanus>=6 && vanus<12)
            //                {
            //                    hind -= hind * 0.3;
            //                    pileti_tuup = "Lastepilet";
            //                }
            //                else if (vanus>=12 && vanus<18)
            //                {
            //                    hind-= hind * 0.1;
            //                    pileti_tuup = "Täispilet";
            //                }
            //                else
            //                {
            //                    hind = 10;
            //                }
            //                Console.WriteLine("{0}, sul vaja maksta {1}", eesnimi, hind);
            //                char[] tahed = eesnimi.ToCharArray();
            //                int i = 0;
            //                eesnimi = "";
            //                foreach (var t in tahed)
            //                {
            //                    if (i==0)
            //                    {
            //                        eesnimi += t.ToString().ToUpper();
            //                    }
            //                    else
            //                    {
            //                        eesnimi += t.ToString().ToLower();
            //                    }
            //                    i += 1;
            //                }
            //            }
            //            else
            //            {

            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine(" mind täna kodus pole! :(");
            //        }
            //        Console.ReadKey();

            // Harjutus 2

            //Console.WriteLine("kirjuta inimesed palun");
            //string nimi_1 = Console.ReadLine();
            //string nimi_2 = Console.ReadLine();
            //if (nimi_1.ToLower()=="kevin" && nimi_2.ToLower()=="german" || nimi_1.ToLower() == "german" && nimi_2.ToLower() == "kevin")
            //{
            //    Console.WriteLine("Jah!");
            //}
            //else if (nimi_1.ToLower() == "angelina" && nimi_2.ToLower() == "ilja" || nimi_1.ToLower() == "ilja" && nimi_2.ToLower() == "angelina")
            //{
            //    Console.WriteLine("Jah!");
            //}
            //else if (nimi_1.ToLower() == "ilja" && nimi_2.ToLower() == "anton" || nimi_1.ToLower() == "anton" && nimi_2.ToLower() == "ilja")
            //{
            //    Console.WriteLine("Jah!");
            //}
            //else if (nimi_1.ToLower() == "artjom" && nimi_2.ToLower() == "timofei" || nimi_1.ToLower() == "timofei" && nimi_2.ToLower() == "artjom")
            //{
            //    Console.WriteLine("Jah!");
            //}
            //else if (nimi_1.ToLower() == "artjom" && nimi_2.ToLower() == "denis" || nimi_1.ToLower() == "denis" && nimi_2.ToLower() == "artjom")
            //{
            //    Console.WriteLine("Jah!");
            //}
            //else
            //{
            //    Console.WriteLine("Ei!");
            //}
            //Console.ReadKey();

            // harjutus 3

            Console.WriteLine("Tere. Rääkite palun põranda pikkus.");
            int pikkus = Console.ReadLine();
            int laius = Console.ReadLine();
            Console.WriteLine("tahate remonti teha?");
        }
    }
}
