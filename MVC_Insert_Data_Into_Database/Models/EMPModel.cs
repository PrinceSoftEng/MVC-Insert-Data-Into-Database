using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Insert_Data_Into_Database.Models
{
    public class EMPModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "FirstName is Required")]
        public string FName { get; set; }

        [Display(Name = "Middle Name")]
        [Required(ErrorMessage = "MiddleName is Required")]
        public string MName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string LName { get; set; }

        [Display(Name = "Email Id")]
        [Required(ErrorMessage = "Email Id is Required")]
        public string EmailId { get; set; }
    }
}