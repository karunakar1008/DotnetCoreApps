using System.ComponentModel.DataAnnotations;

namespace MvcCoreCrudDemo.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }

        [Required]
        public string Name
        {
            get;
            set;
        }
        [Required]
        public string Email
        {
            get;
            set;
        }
        public string Phone
        {
            get;
            set;
        }
        public int Age { get; set; }
    }
}
