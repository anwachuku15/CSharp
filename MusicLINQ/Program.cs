using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;


            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            Artist mtVernon = Artists.FirstOrDefault(a => a.Hometown == "Mount Vernon");
            Console.WriteLine("1. Name & age of artist from Mount Vernon:");
            Console.WriteLine(mtVernon.ArtistName + ", " + mtVernon.Age);
            Console.WriteLine("---------");

            //Who is the youngest artist in our collection of artists?
            int young = Artists.Min(a => a.Age);
            Artist youngest = Artists.FirstOrDefault(y => y.Age == young);
            Console.WriteLine("2. Who is the youngest artist in our collection?");
            Console.WriteLine(youngest.ArtistName);
            Console.WriteLine("---------");


            //Display all artists with 'William' somewhere in their real name
            string william = "William";
            IEnumerable<Artist> williams = Artists.Where(w => w.RealName.Contains(william));
            Console.WriteLine("3. Display all artists with William somewhere in their real name:");
            foreach(var w in williams)
            {
                Console.WriteLine(w.ArtistName);
            }
            Console.WriteLine("---------");

            //Display all groups with names less than 8 characters length.
            IEnumerable<Group> eight = Groups.Where(g => g.GroupName.Length < 8);
            Console.WriteLine("4. Display all groups with names less than 8 characters in length:");
            foreach(var g in eight)
            {
                Console.WriteLine(g.GroupName);
            }
            Console.WriteLine("---------");

            //Display the 3 oldest artist from Atlanta
            List<string> oldATL = new List<string>{};
            IEnumerable<Artist> ATL = Artists.Where(a => a.Hometown == "Atlanta").OrderByDescending(b => b.Age).Take(3);
            Console.WriteLine("5. Display the 3 oldest artists from Atlanta");
            foreach(var a in ATL)
            {
                Console.WriteLine(a.ArtistName);
            }
            Console.WriteLine("---------");
           

            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            IEnumerable<Artist> GroupMembers = Artists.Where(a => a.GroupId > 0 && a.Hometown != "New York City");
            List<string> nonNYGroups = new List<string>{};

            foreach(var g in GroupMembers)
            {
                if(!nonNYGroups.Contains(g.Group.GroupName))
                {
                    nonNYGroups.Add(g.Group.GroupName);
                }
            }

            Console.WriteLine("BONUS - 6. Display the groups that have at least one member not from NYC:");

            foreach(var i in nonNYGroups)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------");

            
            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            IEnumerable<string> WuTangMembers = Groups[0].Members.Select(m => m.ArtistName);
            Console.WriteLine("BONUS - 7. Display all the members of the Wu-Tang Clan:");
            foreach(var w in WuTangMembers)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine("---------");
        }
    }
}
