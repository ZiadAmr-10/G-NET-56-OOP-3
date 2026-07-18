namespace Assignment03
{
    internal class StandardTicket:Ticket
    {
        public string  SeatNumber { get; set; }
        public StandardTicket(string movieName, decimal price,string Seatnumber) : base(movieName, price)
        {
            SeatNumber = Seatnumber;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, SeatNumber:{SeatNumber}";
        }


    }
}
