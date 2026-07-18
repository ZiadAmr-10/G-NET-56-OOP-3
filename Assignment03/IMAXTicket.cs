namespace Assignment03
{
    internal class IMAXTicket : Ticket
    {
        public bool  Is3D { get; set; }
        public IMAXTicket(string movieName, decimal price,bool is3d) :base( movieName, price) 
        {
            Is3D = is3d;
        }
        private decimal GetPrice3D()
        {
            if (Is3D)
            {
                Price += 30;
            }
            return Price;
        } 

        public override string ToString()
        {
            return $"{base.ToString()},IMAX : {(Is3D ? $"Yes + (30) Price :{GetPrice3D()}" :"No" )}";
        }
    }
}
