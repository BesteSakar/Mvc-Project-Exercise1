using System.ComponentModel.DataAnnotations;

namespace Odev.Models
{
    public class Student
    {



        [Required(ErrorMessage = "Please enter a student name ..")]
        [StringLength(40, ErrorMessage = "Must be no more than 50 characters ")]

        public string StudentName { get; set; }

        public string StudentSurname { get; set; }

        [EmailAddress(ErrorMessage = "Please check your email structure..")]
        public string StudentEmail { get; set; }



    }
}
