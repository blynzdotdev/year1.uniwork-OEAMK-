class Program
{
	static void Main(string[] args)
	{
		Random rand = new Random();
		int[] tomb = new int[16];
		for (int i=0; i <tomb.Lengrh; i++)
		{
				tomb[i] = rand.Next(1, 6);
				Console.Write(" " + tomb[i]);
		}
		atlag(tomb);
		Console.Readkey();
		
		
		//* idk ez hova valo de ide rakom mert ebbe van .tomb *// // file-ba iras feladat //
		
		StreamWriter file = new StreamWriter("jegyek.txt");
		for (int i = 0; i < tomb.length; i++)
		{
			file.Write(tomb[i] + ";");
		}
		file.Flush();
		file.Close();
		Console.Readkey();
		
		// idk rész vége //
		
		
		
	}
	static void atlag(int[] szamok)
	{
		int szam = 0;
		for (int i = 0; i <szamok.length; i++)
		{
			szam += szamok[i]
			
		}
		double osszeg = szam / 16.0;
		Console.WriteLine();
		Console.WriteLine(osszeg);
				
	}
	static void egyes(int[] darab)
	{
		int db = 0;
		for (int i=0; i < darab.length; i++)
		{
			if (darab[i] == 1)
			{
				db++;
			}
		}
		Console.WriteLine("{0} darab egyese volt a tanuónak", db);
				
	}
	static void rendezes(int[] sor)
	{
		int seged = 0;
		bool nagy = false;
		do
		{
			nagy = false;
			for (int i = 1; i < sor.length; i++)
			{
				if (sor[i] < sor[i - 1])
				{
					seged = sor[i];
					sor[i] = sor[i - 1];
					sor[i - 1] = seged;
					nagy = true;
					
				
				}
			}
			
		} while (nagy != false);
		for (int i = 0; i < sor.length; i++)
		{
			Console.Write(sor[i] + " ");
		}	
		
	}
	
	// * utolso " Heti Munka " feladat  ha neked nem ez van akkor rip bozo
	// * Main-be ez kell rakni: 
	//Console.WriteLine("Kérem a dolgozó nevét");
    //        string nev = Console.ReadLine();
    //        int a;
    //        a = HetiMunka(matrix,nev);
    //        if (a == -1)
    //        {
    //            Console.WriteLine("Nincs ilyen nevű dolgozó");
    //        }
    //        else
    //        {
    //            Console.WriteLine(nev+" ennyi órát dolgozott a héten: "+a);
    //        }
	
	static int HetiMunka(int[,] matrix, string nev)
    {
        int h = -1;
        switch (nev)
            {
                case "Vas Tibor":
                        h = 0;
                    break;
                case "Kész Ákos":
                    h = 1;
                    break;
                case "Tóth Andi":
                    h = 2;
                    break;
                case "Szabó Ottó":
                    h = 3;
                    break;
                case "Kiss Pál":
                    h = 4;
                    break;
                case "Szép Ernő":
                    h = 5;
                    break;
                case "Papp Tünde":
                    h = 6;
                    break;
                default:
                    h = -1;
                    break;

            }
            if (h >= 0)
            {
                int ossz = 0;
                for (int i = 0; i < 4; i++)
                {
                    ossz += matrix[h, i];
                }
                return ossz;
            }
            else
            {
                return -1;
            }
    }
	
	static void Tulora(int[,] matrix)
        {   // itt valoszinuleg el vannak tabulátorozva dolgok, javitasra szorul //
            int db = 0;
            for (int i = 0; i < 7; i++)
            {
                if (matrix[i,2] >8)
                {
                    db++;
                }
            }
            if (db == 0)
            {
                Console.WriteLine("Nem volt túlóra");
            }
            else
            {
                Console.WriteLine(db+"-an túlóráztak");
            }
			
			
	string[] napok = new string[4] {"Hétfő","Kedd","Szerda","Péntek" };
            int[] orak = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int ossz = 0;
                for (int j = 0; j < 7; j++)
                {
                    ossz += matrix[j, i];
                }
                orak[i] = ossz;
            }
            StreamWriter sw = new StreamWriter("munkaorak.txt");
                for (int i = 0; i < 4; i++)
            {
                sw.WriteLine(napok[i]+": {0} óra",orak[i]);
            }
            sw.Close();
	
	
}