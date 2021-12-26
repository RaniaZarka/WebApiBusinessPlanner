using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesBusinessPlanner.Model
{
    public class sub_qualification
    {

        public int qualification_Id { get; set; }
        public int sub_qualification_Id { get; set; }
        public string sub_qualification_name { get; set; }

        public sub_qualification(int ID, int SID, string Name)
        {
            qualification_Id = ID;
            sub_qualification_name = Name;
            sub_qualification_Id = SID;
            
        }
        public sub_qualification() { }
    }
}
