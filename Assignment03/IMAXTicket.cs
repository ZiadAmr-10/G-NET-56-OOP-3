namespace Assignment03
{
    internal class IMAXTicket : Ticket
    {
        public bool  Is3D { get; set; }
        public IMAXTicket(string movieName, decimal price,bool is3d) :base( movieName, price) 
        {
            Is3D = is3d;
        }
        public decimal PriceAfter3D => Is3D ? Price + 30 : Price;

        public override string ToString()
        {
            return $"{base.ToString()},IMAX : {(Is3D ? $"Yes + (30) Price :{PriceAfter3D}" :"No" )}";
        }
    }
}
