using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DojoActivity.Models
{
    public class User
    {
        //Main fields for DB
        [Key]
       public int UserId {get;set;}

       [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "No numbers allowed in Name Fields")]
       [MinLength(2, ErrorMessage="First Name must be 2 or more characters")]
       public string First_Name {get;set;}

       [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "No numbers allowed in Name Fields")]
       [MinLength(2, ErrorMessage="Last Name must be 2 or more characters")]
       public string Last_Name {get;set;}

       [Required]
       [EmailAddress]
       public string Email {get;set;}

       [Required]
       [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
       [DataType(DataType.Password)]
       public string Password {get;set;}

       [NotMapped]
       [Required]
       [DataType(DataType.Password)]
       [Compare("Password", ErrorMessage="Passwords Must Match")]
       public string Confirm_Password {get;set;}

        //Needed Fields
       public DateTime Created_at {get;set;} = DateTime.Now;
       public DateTime Updated_at {get;set;} = DateTime.Now;

        //Keys to and from 1:many and many:many

        public List<Roster> Events {get;set;}

        public List<Activity> CreatedActivities {get;set;}
    }
}