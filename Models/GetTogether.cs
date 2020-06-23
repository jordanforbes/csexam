using System.ComponentModel.DataAnnotations;

namespace exam.Models
{
    public class GetTogether
    {
        [Key]
        public int GetTogetherId {get;set;}
        public int UserId {get;set;}
        public int JawnId{get;set;}

        public User JawnGoer {get;set;}
        public Jawn ThisJawn {get;set;}
    }
}