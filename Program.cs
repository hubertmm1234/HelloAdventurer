class Program
{
    //PROJEKT NA SEMESTR HELLO ADVENTURER
    // NAZWA TYMCZASOWA : "HIDDEN PATH"
<<<<<<< HEAD
    
    //---STATYSTKI GRACZA---//
        
    static int zycieBohatera = 20; // Zycie z jakim Gracz startuje na poczatku gry
    static int maxZycieBohatera = 20;// maksymalne zycie startowe (poprzez doswiadczenie mozna je zmienic)
        
   static int silaBohatera = 1; // Sila z jaka Gracz startuje na poczatku gry
        
    static int zlotoBohatera = 0; // Za zloto bedzie mozna kupowac rozne rzeczy jak leczenie hp
        
   static int doswiadczenieBohatera = 0;  // MAKSYMALNE DOSWIADCZENIE 100, potem Mozemy zwiekszyc sile o 1 lub zdrowie o 1 
   static int maxDoswiadczenieBohatera = 100;
    
    static void Main(string[] args)
    {
      
        Console.CursorVisible = false;
        
        string nazwaGry = "HIDDEN PATH";
        Console.Title = nazwaGry;  
        
       
        //----------------------//
        
        // ----------------Strona Startowa GRY----------------/
        bool MenuBool = true;
        bool StartGry = false;
=======
   
    
    static void Main(string[] args)
    {
        string nazwaGry = "HIDDEN PATH";
        Console.Title = nazwaGry;  
        
        //---STATYSTKI GRACZA---//
        
        int zycieBohatera = 20; // Zycie z jakim Gracz startuje na poczatku gry
        int maxZycieBohatera = 20;// maksymalne zycie startowe (poprzez doswiadczenie mozna je zmienic)
        
        int silaBohatera = 1; // Sila z jaka Gracz startuje na poczatku gry
        
        int zlotoBohatera = 0; // Za zloto bedzie mozna kupowac rozne rzeczy jak leczenie hp
        
        int doswiadczenieBohatera = 0;  // MAKSYMALNE DOSWIADCZENIE 100, potem Mozemy zwiekszyc sile o 1 lub zdrowie o 1 
        int maxDoswiadczenieBohatera = 100;
        //----------------------//
        
        // ----------------Strona Startowa GRY----------------//
>>>>>>> 7b28d2548375a3b05c7a9d6fdb51e0adcd344a1d
        
        Console.WriteLine("+=-=-=-=-=-=-=-=-=-=-=-=+");
        Console.WriteLine("|\t"+ nazwaGry+ "\t|");
        Console.WriteLine("+=-=-=-=-=-=-=-=-=-=-=-=+");
        Console.WriteLine("|\t WITAJ W GRZE\t|");
        Console.WriteLine("|\t \t \t|");
        Console.WriteLine("+=-=-=-=-=-=-=-=-=-=-=-=+");
        
        //----------------------------------------------------//
<<<<<<< HEAD
        while (MenuBool)
        {
           
            Console.WriteLine("| 1. Nowa Gra \t");
            Console.WriteLine("| 2. Wczytaj Gre (IN PROGRESS)");
            Console.WriteLine("| 3. WYJDZ");
            Console.WriteLine("");
           
            Console.WriteLine("podaj numer opcji: ");
            int menuWybor = int.Parse(Console.ReadLine());
            switch (menuWybor)
            {
                case 1:
                    Console.Clear();
                    MenuBool = false;
                    StartGry = true;
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("BAJO JAJO JESZCZE NIE ZROBIONE :)");
                    Console.WriteLine("Kliknij cokolwiek");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    MenuBool = false;
                    break;
                default:
                    Console.WriteLine("Blad! nie ten klawisz!");
                    Console.Clear();
                    break;
            }
                        

            
        }// Petla Menu Startowego Gry

        if (StartGry == true) // Gdy Gracz wybierze opcje Nowej Gry
        {
            Console.Write("|Podaj imie bohatera : ");
            string imieBohatera = Console.ReadLine();
        
            Console.Clear();
            Console.WriteLine("+=-=-=-=-=-=-=-=-=-=-=-=+");
            Console.WriteLine("|\t Witaj "+ imieBohatera+ "\t|");
            Console.WriteLine("+=-=-=-=-=-=-=-=-=-=-=-=+");
        
            Console.Write("Klilknij Cokolwiek by zaczac gre");
            Console.ReadKey();
            Console.Clear();
        
            //----POCZATEK GRY WPROWADZENIE----//
            EkwipunekGraczaMini();



        }

      

    }
    // ------------ FUNKCJE ----------- //
    
    
    // EKWIPUNEK GRACZA -- > WERSJA MINI - WYSWIETLA SIE CALY CZAS PODCZAS GRY
    // -- >  POKAZUJE STATYSTYKI JAK HP SILA I PIENIADZE
    // -- > 
    static void EkwipunekGraczaMini()
    {
        Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                  ---=== STATYSTYKI ===---               ║");
        Console.Write("║  ZYCIE:"+zycieBohatera);
        Console.Write("║  SILA:"+silaBohatera);
        Console.Write("║  Doswiadczenie "+doswiadczenieBohatera);
        Console.WriteLine("║  Monety:"+zycieBohatera+"\t  ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════╝");
    }
    
    
    // --------------------------------------------------------------------------------------------------//
    // MAPA GRY --> gracz ma mozliwosc otworzenia mapy gdzie widzi swoje polozenie 
    static void MapaGracza()
    {
        
        
    }



=======
        
        Console.Write("|Podaj imie bohatera : ");
        string imieBohatera = Console.ReadLine();
        
        Console.Clear();
        Console.WriteLine("+=-=-=-=-=-=-=-=-=-=-=-=+");
        Console.WriteLine("|\t Witaj "+ imieBohatera+ "\t|");
        Console.WriteLine("+=-=-=-=-=-=-=-=-=-=-=-=+");
        
        Console.Write("Klilknij Cokolwiek by zaczac gre");
        Console.ReadKey();
        Console.Clear();
        
        //----POCZATEK GRY WPROWADZENIE----//




    }
>>>>>>> 7b28d2548375a3b05c7a9d6fdb51e0adcd344a1d
}