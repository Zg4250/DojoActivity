using System;
using System.ComponentModel.DataAnnotations;

namespace DojoActivity.Models
{
    public class LoginUser
    {
        [Required]
       public string Login_Email {get;set;}

        [Required]
        [DataType(DataType.Password)]
       public string Login_Password {get;set;}
    }
}