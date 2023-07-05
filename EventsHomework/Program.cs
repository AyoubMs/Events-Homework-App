using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel("Ayoub", "Chahir", 3);

            person.FullFriends += Person_FullFriends;

            person.AddFriend(new PersonModel("Salma", "Mitwalli")).PrintToConsole();
            person.AddFriend(new PersonModel("Salim", "Habadoki")).PrintToConsole();
            person.AddFriend(new PersonModel("Salim", "Habadok")).PrintToConsole();

            Console.ReadLine();
        }

        private static void Person_FullFriends(object sender, string e)
        {
            Console.WriteLine();
            Console.WriteLine(e);
            Console.WriteLine();
        }
    }
}
