namespace Intro_Interface_Video
{
    internal interface ITransportation
    {
        // Setter liksom harde regler for hva som trengs i en klasse som bruker interface-en
        public string Brand { get; set; }
        public string RegistraionNumber { get; set; }
        public void Drive();
    }
}
