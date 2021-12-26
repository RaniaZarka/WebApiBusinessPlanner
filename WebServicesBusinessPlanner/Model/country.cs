using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesBusinessPlanner.Model
{
    public class country
    {
        public int country_Id { get; set; }
        public string country_name { get; set; }

        public country (int ID, string Name)
        {
            country_Id = ID;
            country_name = Name;
        }
        public country() { }
    }
}
