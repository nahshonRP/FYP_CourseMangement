using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMangement.Models.ViewModels
{
    public class Course
    {
        [Key]
        public int ProgramId { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TrainerName { get; set; }
        public string ProgramName { get; set; }
        
        public string ProgramCategory { get; set; }
        public int ProgramCategoryId { get; set; }

        public DateTime ProgramStartDate { get; set; }
        public DateTime ProgramEndDate { get; set; }

    }
}
