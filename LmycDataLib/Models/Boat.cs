using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmycDataLib.Models
{
    public class Boat
    {
        public int BoatId { get; set; }
        public string BoatName { get; set; }
        public string Picture { get; set; }
        public int LengthInFeet { get; set; }
        public int Make { get; set; }
        public int Year { get; set; }
        public DateTime RecordCreationDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
