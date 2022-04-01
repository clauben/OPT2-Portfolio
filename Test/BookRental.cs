namespace Test
{
    public class BookRental : IBookRental
    {
        public string Booking(string datum, int stayDays, int persons, Rentel rentel, Person person)
        {
            string reservation = $"Reservation: {rentel.Name} - {datum} - {stayDays} day - {persons} people";
            return reservation;
        }
    }
}
