using System.ComponentModel.DataAnnotations;

namespace Asp.netCoreCRUD.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
    }
}
