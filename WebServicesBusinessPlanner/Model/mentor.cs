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
        public string mentor_field { get; set; }
        public string mentor_link { get; set; }
        public string mentor_experience { get; set; }
        public string mentor_education { get; set; }
        public string mentor_pic { get; set; }
        public string country { get; set; }

        public mentor(int ID, string Name, string Description, string Field, string Link, string Experince, string Education, String Pic, string Country)
        {
            mentor_Id = ID;
            mentor_name = Name;
            mentor_description = Description;
            mentor_field = Field;
            mentor_link = Link;
            mentor_experience = Experince;
            mentor_education = Education;
            mentor_pic = Pic;
            country = Country;

        }

        public mentor() { }

    }
}
