namespace Assignment03
{
    internal class Ticket
    {
        public string MovieName { get; set; }
        private decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
                else
                    throw new InvalidDataException("Invalid Number ");
            }
        }
        private static int Counter = 0;
        public int TicketId { get;}

        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            Counter++;
            TicketId = Counter;
        }
       public decimal PriceAfterTax => Price * 1.14m;

       public static int GetTotalTickets() => Counter;
        public override string ToString()
        {
            return $"Ticket#{TicketId}|{MovieName}|Price:{Price}|PriceAfterTax(14%):{PriceAfterTax}";
        }


    }
}
