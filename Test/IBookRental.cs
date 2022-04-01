namespace Test
{
    public interface IBookRental
    {
        string Booking(string datum, int stayDays, int persons, Rentel rentel, Person person);
    }
}