using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campsite_Manager.Models
{
    public class HousingUnit
    {
        public int Id { get; set; }
        public string UnitName { get; set; }
        public string UnitType { get; set; }
        public int MaxCapacity { get; set; }
    }
}
