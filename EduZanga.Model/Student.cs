using System.ComponentModel.DataAnnotations;

namespace EduZanga.Model;

public class Student : BaseProperties
{
    [Required]
    public string StudentId { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Full Name cannot exceed 50 characters.")]
    public string FullName { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    public string Class { get; set; }
}