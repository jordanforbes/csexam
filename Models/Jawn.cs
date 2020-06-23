using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace exam.Models
{
    public class Jawn
    {
        [Key]
        public int JawnId {get;set;}
        
        [Required(ErrorMessage="Title is necessary")]
        [MinLength(2,ErrorMessage="Title must be at least 2 characters long")]
        public string Title {get;set;}

        public DateTime StartTime {get;set;}
        public DateTime Date {get;set;}
        public int Duration {get;set;}
        // public string DurationUnits {get;set;}
        public string Description {get;set;}

        public int UserId {get;set;}

        public List<GetTogether> Attendees {get;set;}
        public User Organizer {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}