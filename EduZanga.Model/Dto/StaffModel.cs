using System.ComponentModel.DataAnnotations;

namespace EduZanga.Model.Dto;

public class StaffModel : BaseProperties
{
    [Required]
    public string StaffId { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Full Name cannot exceed 50 characters.")]
    public string FullName { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    public string Type { get; set; }

    public bool IsSelected { get; set; }
}