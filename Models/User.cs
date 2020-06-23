using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam.Models{
    public class User{
        [Key]

        public int UserId {get;set;}

        [Required]
        [MinLength (2)]
        public string Name {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [MinLength (8)]
        [DataType ("Password")]
        [StrongPW]

        public string Password {get;set;}

        [Required]
        [Compare("Password")]
        [DataType("Password")]
        [NotMapped]

        public string Confirm {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Jawn> MyJawns {get;set;}
    }
}