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

            var lion = new SeenAnimals
            {
                Species = "Lion",
                CountOfTimesSeen = 4,
                LocationOfLastSeen = "Desert",
            };
            db.Animal.Add(lion);

            var tiger = new SeenAnimals
            {
                Species = "Tiger",
                CountOfTimesSeen = 2,
                LocationOfLastSeen = "Jungle"
            };
            db.Animal.Add(tiger);

            var bear = new SeenAnimals
            {
                Species = "Bear",
                CountOfTimesSeen = 1,
                LocationOfLastSeen = "Jungle"
            };
            db.Animal.Add(bear);


            db.SaveChanges();
        }

        static void ReadData()
        {
            var db = new SafariContext();
            var countAnimoo = db.Animal.Where(animoo => animoo.Species == "Lion" || animoo.Species == "Tiger" || animoo.Species == "Bear").Sum(animoo => animoo.CountOfTimesSeen);
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
            Console.WriteLine("Hello World!");
        }
    }
}
