using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesBusinessPlanner.Model
{
    public class index_mentor_subqualification
    {
        public int index_ms_Id { get; set; }
        public int mentor_Id { get; set; }
        public int sub_qualification_Id { get; set; }

        public index_mentor_subqualification(int indexId,int  mentorId, int subQualification)
        {
            index_ms_Id = indexId;
            mentor_Id = mentorId;
            sub_qualification_Id = subQualification;
        }
    }
}
