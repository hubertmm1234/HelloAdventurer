class Program
{
    //PROJEKT NA SEMESTR HELLO ADVENTURER
    // NAZWA TYMCZASOWA : "HIDDEN PATH"
   
    
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
        
        Console.WriteLine("+=-=-=-=-=-=-=-=-=-=-=-=+");
        Console.WriteLine("|\t"+ nazwaGry+ "\t|");
        Console.WriteLine("+=-=-=-=-=-=-=-=-=-=-=-=+");
        Console.WriteLine("|\t WITAJ W GRZE\t|");
        Console.WriteLine("|\t \t \t|");
        Console.WriteLine("+=-=-=-=-=-=-=-=-=-=-=-=+");
        
        //----------------------------------------------------//
        
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
}