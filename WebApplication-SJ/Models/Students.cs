using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_SJ.Models
{
    public class Students
    {
        [Required(ErrorMessage ="StudentName is required")]
        [StringLength(15,ErrorMessage ="Name can not be more than 15 characters")]
        public string StudentName { get; set; }

        [Range(10,40,ErrorMessage ="Age should be in between 10 to 40")]
        public string Age { get; set; }
    }
}