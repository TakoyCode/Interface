namespace Enkel_introduksjon_til_interface_Video
{
    internal class DummyQuestion : IQuestion
    {
        public bool Run()
        {
            Console.WriteLine("Dummy question");
            return true;
        }
    }
}
