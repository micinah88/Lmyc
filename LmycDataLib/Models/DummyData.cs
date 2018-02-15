using LmycDataLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LmycWebSite
{
    public class DummyData
    {
        public static List<Boat> GetBoats(ApplicationDbContext db)
        {
            List<Boat> boats = new List<Boat>()
            {
                new Boat
                {
                    BoatName = "MaryJane",
                    Picture = "https://static.pexels.com/photos/163236/luxury-yacht-boat-speed-water-163236.jpeg",
                    LengthInFeet = 54,
                    Make = "BoatLovers Ltd.",
                    Year = 1998,
                    RecordCreationDate = DateTime.Today,
                    CreatedBy = db.Users.FirstOrDefault(u => u.UserName == "a").Id
                },
                new Boat
                {
                    BoatName = "Mary Jane No.1",
                    Picture = "https://static.pexels.com/photos/163236/luxury-yacht-boat-speed-water-163236.jpeg",
                    LengthInFeet = 54,
                    Make = "BoatLovers Ltd.",
                    Year = 1998,
                    RecordCreationDate = DateTime.Today,
                    CreatedBy = db.Users.FirstOrDefault(u => u.UserName == "a").Id
                },
                new Boat
                {
                    BoatName = "Mary Jane No.2",
                    Picture = "https://static.pexels.com/photos/163236/luxury-yacht-boat-speed-water-163236.jpeg",
                    LengthInFeet = 58,
                    Make = "BoatLovers Ltd.",
                    Year = 2003,
                    RecordCreationDate = DateTime.Today,
                    CreatedBy = db.Users.FirstOrDefault(u => u.UserName == "a").Id
                },
                new Boat
                {
                    BoatName = "Mary Jane No.3",
                    Picture = "https://static.pexels.com/photos/163236/luxury-yacht-boat-speed-water-163236.jpeg",
                    LengthInFeet = 59,
                    Make = "BoatLovers Ltd.",
                    Year = 2004,
                    RecordCreationDate = DateTime.Today,
                    CreatedBy = db.Users.FirstOrDefault(u => u.UserName == "a").Id
                },
                new Boat
                {
                    BoatName = "Shooting Star",
                    Picture = "http://gasequipment.com.au/wp-content/uploads/2016/03/Boat-for-Blogpost.jpg",
                    LengthInFeet = 120,
                    Make = "Einstein Ltd.",
                    Year = 2008,
                    RecordCreationDate = DateTime.Today,
                    CreatedBy = db.Users.FirstOrDefault(u => u.UserName == "a").Id
                },

            };
            return boats;
        }
    }
}