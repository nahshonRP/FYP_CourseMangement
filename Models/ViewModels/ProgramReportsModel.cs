using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMangement.Models.ViewModels
{
    public class ProgramReportsModel
    {
        public string ProgramName { get; set; }
        public string ChartName { get; set; }
        public string ProgramStartDate { get; set; }
        public string ProgramEndDate { get; set; }
        public int ProgramID { get; set; }
        public string Question { get; set; }
        public string Q8_Answer { get; set; }
        public string Q9_Answer { get; set; }
        public int[] AnswersScore { get; set; }
        public decimal[] AnswersScoreD { get; set; }
        public string[] AnswersText { get; set; }
    }
}
