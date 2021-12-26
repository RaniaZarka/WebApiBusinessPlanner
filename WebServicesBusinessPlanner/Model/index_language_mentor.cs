using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesBusinessPlanner.Model
{
    public class index_language_mentor
    {

        public int index_Id { get; set; }
        public int mentor_Id { get; set; }
        public int language_Id { get; set; }

        public index_language_mentor(int indexId, int mentorId, int languageId)
        {
            index_Id = indexId;
            mentor_Id = mentorId;
            language_Id = languageId;
        }
    }
}
