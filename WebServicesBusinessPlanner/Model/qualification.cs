using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesBusinessPlanner.Model
{
    public class qualification
    {

        public int qualification_Id { get; set; }
        public string qualification_name { get; set; }

        public qualification(int ID, string Name)
        {
            qualification_Id = ID;
            qualification_name = Name;
        }
        public qualification() { }
    }
}

