using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseMangement.Models.ViewModels
{
    public class Timesheet
    {   
        public int id { get; set; }
        public int TrainerId { get; set; }

       
        public int ProgramId { get; set; }

        // TODO: L11 Task 1b - Create a boolean property named RememberMe
        public DateTime ScheduleDateTime { get; set; }


    }
}