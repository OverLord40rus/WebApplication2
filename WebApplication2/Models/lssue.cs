using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public IssueType InssueType { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Complated { get; set; }

        public string number { get; set; }

    }

    public enum Priority
    {
        Low, Medium, High
    }
    public enum IssueType 
    {
        Feature, Bug, Documentation
    }
}
