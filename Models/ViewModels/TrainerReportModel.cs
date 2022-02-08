using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMangement.Models.ViewModels
{
    public class TrainerReportModel
    {
        public int TainerAssigendProgramId { get; set; }
        public int FkTrainerId { get; set; }
        public int FkProgramId { get; set; }
        public int AttendanceStatus { get; set; }
        public string TrainerEmail { get; set; }
        public List<Trainer> Trainers { get; set; }
        public DateTime ScheduleDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }
        public int Id { get; set; }
        public DateTime CheckOutDateTime { get; set; }
        public int Month { get; set; }
        public string MonthName { get; set; }
        public int Year { get; set; }
        public string YearName { get; set; }

        public DateTime ProgramScheduleDate { get; set; }
        public string TrainerName { get; set; }
        public int ProgramId { get; set; }
        public int TrainerRate { get; set; }
        public string ProgramName { get; set; }
        public string WorkingTime { get; set; }
        public string EarnedAmount { get; set; }

        public string ProgramCategory { get; set; }
        public int ProgramCategoryId { get; set; }

        public DateTime ProgramStartDate { get; set; }
        public DateTime ProgramEndDate { get; set; }
    }
}
