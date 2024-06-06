namespace Interface
{
 
    /*
        Et Interface (grensesnitt) er som en "kontrakt" som sier hva en klasse skal kunne gjøre eller inneholde. 
        Den fungerer som en liste med regler som klassen må følge, og er en måte sørge for at klassene inneholder det den trenger / skal,
        samt hjelper med å holde koden organisert på en mer fleksibel måte.

        Eksempel:
    */
    public interface ILog
    {
        void Message(string message);
        void Error(string error);
    };
    /*
        Bokstaven "I" (stor i) foran interfacenavnet (i dette tilfellet ILog) brukes tradisjonelt for å indikere at det er et interface.
        Når du har definert et interface, må det implementeres i en klasse, for eksempel:
     */
    public class ConsoleMessage : ILog
    {
        public void Message(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        public void Error(string error)
        {
            Console.WriteLine($"Error: {error}");
        }
    }
    /*
        Merk at kolonet (:) bak klassenavnet kobler klassen til interfacet og deginerer reglene den må følge.

        Nå kan du opprette objekter av klassen ConsoleMessage, og bruke dem som om de er typen ILog,
        noe om tillater enkel utskifting av forskjellige logger uten å endre resten av koden:
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            ILog message = new ConsoleMessage();
            message.Message("Dette er en melding");
            message.Error("Dette er en melding");
        }
    }

}

