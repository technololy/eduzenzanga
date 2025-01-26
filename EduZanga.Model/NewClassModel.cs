using System.ComponentModel.DataAnnotations;

namespace EduZanga.Model;

public class NewClassModel
{
    [Required(ErrorMessage = "Class Name is required.")]
    [StringLength(50, ErrorMessage = "Class Name cannot exceed 50 characters.")]
    public string ClassName { get; set; }

    [Required(ErrorMessage = "Subject is required.")]
    [StringLength(50, ErrorMessage = "Subject cannot exceed 50 characters.")]
    public string Subject { get; set; }

    [Required(ErrorMessage = "Class Code is required.")]
    [RegularExpression(@"^[a-zA-Z0-9]{10,15}$", ErrorMessage = "Class Code must be alphanumeric and between 10-15 characters.")]
    public string ClassCode { get; set; }

    [Required(ErrorMessage = "Session is required.")]
    [StringLength(20, ErrorMessage = "Session cannot exceed 20 characters.")]
    public string Session { get; set; }

    [Required(ErrorMessage = "Date is required.")]
    public DateTime? Date { get; set; }
}