using System.ComponentModel.DataAnnotations;

namespace EduZanga.Model;

public class Teacher : BaseProperties
{
    [Required(ErrorMessage = "Staff Name is required.")]
    [StringLength(50, ErrorMessage = "Staff Name can't exceed 50 characters.")]
    public string StaffName { get; set; } = null!;

    [Required(ErrorMessage = "Staff ID is required.")]
    [StringLength(10, ErrorMessage = "Staff ID can't exceed 10 characters.")]
    public string StaffId { get; set; } = null!;

    [Required(ErrorMessage = "Class is required.")]
    public string Class { get; set; } = null!;

    [Required(ErrorMessage = "Arm is required.")]
    public string Arm { get; set; } = null!;
}
