using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesBusinessPlanner.Model
{
    public class mentor
    {
        public int mentor_Id { get; set; }
        public string mentor_name { get; set; }
        public string mentor_description { get; set; }
       
     
        public string mentor_experience { get; set; }
        public string mentor_education { get; set; }
        public string mentor_pic { get; set; }
        
        public mentor(int ID, string Name, string Description,   string Experince, string Education, string Pic)
        {
            mentor_Id = ID;
            mentor_name = Name;
            mentor_description = Description;
           
            mentor_experience = Experince;
            mentor_education = Education;
            mentor_pic = Pic;
          

        }

        public mentor() { }

    }
}
