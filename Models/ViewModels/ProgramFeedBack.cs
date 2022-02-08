using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMangement.Models.ViewModels
{
    public class ProgramFeedBack
    {
        public int ProgramFeedBackId { get; set; }
        public int ProgramId { get; set; }
        public DateTime AddedDate { get; set; }
        public string ProgramName { get; set; }
        public int NoOfFeedbacks { get; set; }
        public string Q1 { get; set; }
        public string Q1_Value { get; set; }

        public string Q2 { get; set; }
        public string Q2_Value { get; set; }


        public string Q3 { get; set; }
        public string Q3_Value { get; set; }


        public string Q4 { get; set; }
        public string Q4_Value { get; set; }


        public string Q5 { get; set; }
        public string Q5_Value { get; set; }


        public string Q6 { get; set; }
        public string Q6_Value { get; set; }


        public string Q7 { get; set; }
        public string Q7_Value { get; set; }

        public string Q8 { get; set; }
        public string Q8_Value { get; set; }

        public string Q9 { get; set; }
        public string Q9_Value { get; set; }
    }
}
