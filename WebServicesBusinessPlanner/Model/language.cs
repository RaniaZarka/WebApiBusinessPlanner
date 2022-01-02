using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesBusinessPlanner.Model
{
    public class language
    {
        public int language_Id { get; set; }
        public string language_name { get; set; }

        public language(int ID, string Name)
        {
            language_Id = ID;
            language_name = Name;
        }
        public language() { }
    }
}

