using System;
using System.Linq;

namespace safari_vacation
{
    class Program
    {

        static void CreateData()
        {
            //Equivalent to INSERT INTO...
            var db = new SafariContext();

            var hippo = new SeenAnimals
            {
                Species = "Hippo",
                CountOfTimesSeen = 2,
                LocationOfLastSeen = "Jungle",
            };
            db.Animal.Add(hippo);

            var camel = new SeenAnimals
            {
                Species = "Camel",
                CountOfTimesSeen = 3,
                LocationOfLastSeen = "Desert"
            };
            db.Animal.Add(camel);


            db.SaveChanges();
        }

        static void ReadData()
        {
            var db = new SafariContext();
            var countAnimoo = db.Animal.Sum(animoo => animoo.CountOfTimesSeen);
            Console.WriteLine(countAnimoo);

        }

        static void UpdateData()
        {
            var db = new SafariContext();

            db.SaveChanges();

        }

        static void DeleteData()
        {
            var db = new SafariContext();
            var deleteAnimoo = db.Animal.FirstOrDefault(animoo => animoo.LocationOfLastSeen == "Desert");
            db.Animal.Remove(deleteAnimoo);

            db.SaveChanges();

        }

        static void Main(string[] args)
        {
            ReadData();
            Console.WriteLine("Hello World!");
        }
    }
}
