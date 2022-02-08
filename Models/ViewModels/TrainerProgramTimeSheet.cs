using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMangement.Models.ViewModels
{
    public class TrainerProgramTimeSheet
    {
        public int Id { get; set; }
        public DateTime CheckOutDateTime { get; set; }
        public int TrainerAssignedProgramId { get; set; }
        public int AttendanceStatus { get; set; }
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public DateTime ScheduleDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }


    }

}
