using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesBusinessPlanner.Model
{
    public class field
    {
        public int field_Id { get; set; }
        public string field_name { get; set; }

        public field(int ID, string Name)
        {
            field_Id = ID;
            field_name = Name;
        }

        public field() { }
    }
}
