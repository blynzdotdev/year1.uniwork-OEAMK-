static void kviz()
        {
            //1eskerdes*******************************************************************************************//
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("************** Kezdjük a Kvízt  **************\n");
            Console.WriteLine("************************************************");
            Console.WriteLine("**           ZH 2. | 2020.dec 11.             **");
            Console.WriteLine("**               Készítette                  ***");
            Console.WriteLine("**              Sallai Martin                 **");
            Console.WriteLine("**          Mérnök. Informatka FOSZK          **");
            Console.WriteLine("************************************************");
            Thread.Sleep(3000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            double a;
            Console.WriteLine("Mi a hét 5. napja? \n1 = Hétfő \n3 = kedd\n2 = szerda\n5=csütörtök\n4=Péntek ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Eltaláltad az első kérdést.");
                
            }


            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem nyert");
            }
               



            //2es kérdés*******************************************************************************************//
            Console.ForegroundColor = ConsoleColor.White;
            double b;
            Console.WriteLine("Ki írta az Egri csillagokat? \n1 -- Nemere István\n2 -- Gárdonyi Géza\n3 -- Móra Ferenc\n4 -- Fekete István");
            b = Convert.ToDouble(Console.ReadLine());
            if (b == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Eltaláltad az 2. kérdést");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem nyert, Gárdonyi Géza volt a helyes :(");
            }


            //3.kérdés************************************************************************************************//

            Console.ForegroundColor = ConsoleColor.White;
            double c;
            Console.WriteLine("Melyik megyének, megyeszékhelye Eger?\n1 -- Borsod\n2 -- Heves\n3 -- Fejér\n4 -- Zala");
            c = Convert.ToDouble(Console.ReadLine());
            if (c == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Eltaláltad az 3. kérdést");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem nyert, Heves volt a helyes.");
            }

            //4.feladat***************************************************************************************************//

            Console.ForegroundColor = ConsoleColor.White;
            double d;
            Console.WriteLine("Mikor keletkezett a Szózat? \n1 -- 1836\n2 -- 1846\n3 -- 1856\n4 -- 1866");
            d = Convert.ToDouble(Console.ReadLine());
            if (d == 1)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Eltaláltad az 4. kérdést");


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem nyert, 1836 volt a helyes."); 
               
            }
            //5ös kérdés**************************************************************************************************//
            Console.ForegroundColor = ConsoleColor.White;
            double e;
            Console.WriteLine("Melyik éghajlati övben enyhe a tél?\n1 -- Száraz Kontinentális\n2 -- Nedves Kontinentális\n3 -- Mediterrám\n4 -- Óceáni");
            e = Convert.ToDouble(Console.ReadLine());
            if (e == 4)
            {
                
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem nyert, az óceáni volt a helyes.");
            }
            //6os kérdés**********************************************************************************************//
            Console.ForegroundColor = ConsoleColor.White;
            double f;
            Console.WriteLine("Milyen a folyók vízjárása a tajga éghajlati övezetben?\n1 -- Egyenletes\n2 -- Ingadozó\n3 -- Időszakos");
            f = Convert.ToDouble(Console.ReadLine());
            if (f == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Eltaláltad az 6. kérdést");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem nyert, az időszakos volt a helyes.");

            }
            //7es kérdés*******************************************************************************************//
            Console.ForegroundColor = ConsoleColor.White;
            double g;
            Console.WriteLine("Mi látható az 500 fortintos hátlapján?\n1 -- A gyulai vár\n2 -- A Magyar Nemzeti Múzeum\n3 -- Herkules-Kút\n4 -- A Sároospataki Vár");
            g = Convert.ToDouble(Console.ReadLine());
            if (g == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Eltaláltad az 7. kérdést");


            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem nyert, a Sárospataki Vár volt a helyes.");
            }
            //8as feladat************************************************************************************************************//
            Console.ForegroundColor = ConsoleColor.White;
            double h;
            Console.WriteLine("Milyen új ruhaviselet terjedt el, az aranyláz idején?\n1 -- Zakó\n2 -- Jackie\n3 -- Farmer\n4 -- Ballonkabát");
            h = Convert.ToDouble(Console.ReadLine());
            if (h == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Eltaláltad az 8. kérdést");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem nyert, a Farmer volt a helyes.");
            }
            //9esfeladat************************************************************************************************************//
            Console.ForegroundColor = ConsoleColor.White;
            double i;
            Console.WriteLine("Melyik személyiség típust fedezete fel Jung?\n1 -- Kolerikus\n2 -- Melankólikus\n3 -- Introvertált\n4 -- Szangvinikus");
            i = Convert.ToDouble(Console.ReadLine());
            if (i == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Eltaláltad az 9. kérdést");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem nyert, a hármas volt a helyes.");

            }

            //10es feladat*********************************************************************************************************//
            Console.ForegroundColor = ConsoleColor.White;
            double j;
            Console.WriteLine("Melyik a elghosszabb moszat a világon?\n1 -- Vörös Moszat\n2 -- Barna Moszat\n3 -- Zöld Moszat");
            j = Convert.ToDouble(Console.ReadLine());
            if (j == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Eltaláltad az 10. kérdést");


                Console.Write("\n JÁTÉK VÉGET ÉRT ! \n***********************\n** G A M E _ O V E R **\n***********************");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem nyert, a Barna Moszat volt a helyes.");

                Console.Write("\n JÁTÉK VÉGET ÉRT ! \n***********************\n** G A M E _ O V E R **\n***********************");
            }
        }

             
    }
}