namespace Assignment03
{
    internal class Cinema
    {
        public string CinemaName { get; set; }
        public Projector Projector { get; }

        Ticket[] tickets = new Ticket[20];

        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
            Projector = new Projector();
        }
        public void Add(Ticket ticket)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = ticket;
                    return;
                }
            }
            Console.WriteLine("Cinema is Hold");
        }
        public void PrintAllTickets()
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null)
                {
                    Console.WriteLine(tickets[i]);
                }
                else
                   return;
                
            }
        }
        public void OpenCinema()
        {
            Console.WriteLine("==========Cinema Opened=========");
            Projector.Start();
        }
        public void CloseCinema()
        {
            Console.WriteLine("========Cinema Closed==========");
            Projector.Stop();
        }

    }
}


