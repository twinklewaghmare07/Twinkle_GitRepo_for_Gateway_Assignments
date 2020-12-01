using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Data_Validation_Assignment1.Models
{
    public class StudentRegistration
    {
        //name of student
        [DisplayName("Enter Your  Name ")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }


        //Roll no. of student
        [DisplayName("Roll No ")]
        [Range(111111, 999999, ErrorMessage = "Age must be 6 digits.")]
        [Required(ErrorMessage = "Roll No. is Required")]
        public string Rno { get; set; }

        //age of student
        [Required(ErrorMessage = "Age is Required")]
        [Range(1, 120, ErrorMessage = "Age must be between 1-120 in years.")]
        public int Age { get; set; }

        //dob of student
        [Display(Name = "DOB")]
        [Required(ErrorMessage = "DOB is Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        //gender of student
        [Required(ErrorMessage = "Please Select Gender")]
        public string Gender { get; set; }

        //course of student
        [DisplayName("Course ")]
        [Required(ErrorMessage = "Please Select Course")]
        public Course StudentCourse { get; set; }

        //email of student
        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }
        //confirm email of student
        [Required(ErrorMessage = "Confirm Email is Required")]
        [DataType(DataType.EmailAddress)]
        [System.ComponentModel.DataAnnotations.Compare("Email", ErrorMessage = "Email Not Matched")]
        
        public string ConfirmEmail { get; set; }

        //Phn. No. of student
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone No. is Required")]
        [RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{4})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid Phone number (must be 12 digits)")]
        public string PhoneNumber { get; set; }



        //12th marks of student
        [DisplayName("SSC Marks ")]
        [Required(ErrorMessage = "SSC Marks is Required")]
        [Range(1, 100, ErrorMessage = "Marks must be between 1-100 ")]
        public int Ssc { get; set; }

        //10th marks of student
        [DisplayName("HSC Marks ")]
        [Required(ErrorMessage = "HSC Marks is Required")]
        [Range(1, 100, ErrorMessage = "Marks must be between 1-100 ")]
        public int Hsc { get; set; }

        

    }



    
    public enum Course
    {
        BTech,
        BE,
        BCA,
        BSC,
        BPharma,
        BCom,
        MCA
    }
}