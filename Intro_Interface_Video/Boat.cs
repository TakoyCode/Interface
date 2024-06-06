namespace Intro_Interface_Video
{
    internal class Boat : ITransportation
    {
        // Må inneholde det samme, som det som er i interface-et
        public string Brand { get; set; }
        public string RegistraionNumber { get; set; }

        public void Drive()
        {
            // Dra i spak
        }
    }
}
