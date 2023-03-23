using System.ComponentModel.DataAnnotations;

namespace DataService.Model
{
    public class Project
    {
        [Key]
        public int Project_ID { get; set; }
        public string Project_Name { get; set; }
        public Employee Employee { get; set; }
    }
}
