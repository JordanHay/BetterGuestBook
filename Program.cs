using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

//capture info about each guest
// info to capture firstname lastname message to host
//done capturing, loop through each guest and print info

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GuestModel> guests = new List<GuestModel>();
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();
                Console.Write("what is your first name?");
                guest.FirstName = Console.ReadLine();

                Console.Write("what is your last name?");
                guest.LastName = Console.ReadLine();

                Console.Write("What message would you like to send your host?");
                guest.MessageToHost = Console.ReadLine();

                Console.Write("are more guests coming? (yes/no): ");
                moreGuestsComing = Console.ReadLine();

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestsComing.ToLower() == "yes");

            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }

            Console.ReadLine();
        }
    }
}
