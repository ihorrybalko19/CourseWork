using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDictionary.Models
{
    public class Plant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Author {  get; set; }
        public string Maturation_Time { get; set; }
        public string Weight { get; set; }
        public string Hybridity { get; set; }
        public string Frost_Resistance { get; set; }
        public string Expiration_Date { get; set; } 
        public string Potential_Harvest { get; set; }
        public string Type_of_Pollution { get; set; }
        public string Is_Cuboid { get; set; }
        public string Is_Indeterminate { get; set; }
        public string Shape_of_Head {  get; set; }
        public string Starch_Content { get; set; }
        public string Description { get; set; }

    }
}
