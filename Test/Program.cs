using Test;

class Program
{
    static void Main(string[] args)
    {
        Rentel house = new Apartment("Mariot" ,"Rotterdam", 2.0, 2, 2, 159, true);
        Rentel house2 = new Bungalow("Terrin", "Zweden", 3.0, 3, 1, 219, 10);
        Address address = new Address("Rotterdam", "Holland", "3086XA");
        Person Claudio = new Person("Claudio", "Benjamin", address);

        IBookRental booking = new BookRental();

        Console.WriteLine("Welkom, Boek uw accomodatie");
        Console.WriteLine("Kies 1 voor een apartement of 2 voor een bungalow");
        int keuze = int.Parse(Console.ReadLine());
        if (keuze == 1)
        {
            Console.WriteLine("U heeft gekozen voor een apartement.");
            Console.WriteLine("Locatie: " + house.Location + ", Naam: " + house.Name + ", Prijs per nacht: " + house.Price);
            Console.WriteLine("Hoeveel dagen wilt u blijven?");
            int dagen = int.Parse(Console.ReadLine());
            Console.WriteLine("De prijs: " + house.CalculatePrice(dagen, house));
            Console.WriteLine("Wilt u boeken? typ 1 om door te gaan");
            int doorgaan = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (doorgaan == 1)
            {
                Console.Write("Aanvang Datum: ");
                string datum = Console.ReadLine();
                Console.Write("Aantal personen: ");
                int personen = int.Parse(Console.ReadLine());
                Console.WriteLine(booking.Booking(datum, dagen, personen, house, Claudio));
                Console.WriteLine("De prijs: " + house.CalculatePrice(dagen, house));
                Console.WriteLine("Bedankt voor uw reservering");
            }
            else
            {
                Console.WriteLine("Tot Ziens");
            }
        }
        if (keuze == 2)
        {
            Console.WriteLine("U heeft gekozen voor een apartement.");
            Console.WriteLine("Locatie: " + house2.Location + ", Naam: " + house2.Name + ", Prijs per nacht: " + house2.Price);
            Console.WriteLine("Hoeveel dagen wilt u blijven?");
            int dagen = int.Parse(Console.ReadLine());
            Console.WriteLine("De prijs: " + house2.CalculatePrice(dagen, house2));
            Console.WriteLine("Wilt u boeken? typ 1 om door te gaan");
            int doorgaan = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (doorgaan == 1)
            {
                Console.Write("Aanvang Datum: ");
                string datum = Console.ReadLine();
                Console.Write("Aantal personen: ");
                int personen = int.Parse(Console.ReadLine());
                Console.WriteLine(booking.Booking(datum, dagen, personen, house2, Claudio));
                Console.WriteLine("De prijs: " + house2.CalculatePrice(dagen, house2));
                Console.WriteLine("Bedankt voor uw reservering");
            }
            else
            {
                Console.WriteLine("Tot Ziens");
            }
        }
    }
}