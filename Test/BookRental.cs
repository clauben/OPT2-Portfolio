namespace Test
{
    public class BookRental
    {
        public double CalculatePrice(int stayDays, Rentel rentel)
        {
            double totalPrice =  rentel.Price * stayDays;
            return totalPrice;
        }

        public string Booking(int month, int day, int year, int stayDays, int persons, Rentel rentel, Person person)
        {
            double price = CalculatePrice(stayDays, rentel);
            string reservation = $"Reservation: {rentel.Name} - {day}/{month}/{year} - {stayDays} day - {persons} people - €{price}.";
            person.Reservations.Add(reservation);
            return reservation;
        }
    }
}
