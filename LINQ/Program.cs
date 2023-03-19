using System.Runtime.Versioning;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>()
            {
                "DK 64",
                "Ratchet and Clank",
                "Call of Duty",
                "Madden",
                "NBA 2k",
                "NBA Street",
                "NFL Street",
                "Assassins Creed",
                "MarioKart",
                "Tropico 6",
                "Railway Empire",
                "Sonic the Hedgehog",
                "James Bond: Golden Eye",
                "NCAA Football",
                "PGA Tour 2k22",
                "SIMS",

            };
            videoGames.Add("Fornite");

            var orderedGames = videoGames.OrderBy(name => name.Length);

            foreach (var order in orderedGames)
            {
                Console.WriteLine(order);
            }
        }
    }
}
