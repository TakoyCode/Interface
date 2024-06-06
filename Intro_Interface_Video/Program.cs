namespace Intro_Interface_Video
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Å bruke interface gjør at man kan lage generell kode, som fungerer for alle de klassene som bruker interface-et fordi de ligner på hverandre
            // Slipper også å duplisere kode, du kan gjøre ting mer generell

            // Eksempler:
            List<ITransportation> vehicles = new List<ITransportation>();
            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
            }
        }
    }
}
