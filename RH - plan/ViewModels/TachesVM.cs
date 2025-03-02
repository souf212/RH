using System.ComponentModel.DataAnnotations;
using HR_Management_System.Models;  
namespace HR_Management_System.ViewModels
{
    public class TachesVM
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty; // Titre de la t�che

        public string? Description { get; set; } // Description de la t�che

        [Required]
        [StringLength(50)]
        public string AssignedTo { get; set; } = string.Empty; // Employ� assign�

        [Required]
        public string Status { get; set; } = "Active"; // Statut
    }
}

