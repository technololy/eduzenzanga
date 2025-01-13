using System.ComponentModel.DataAnnotations;

namespace EduZanga.Model;

public class SessionModel : BaseProperties
{
    [Required(ErrorMessage = "Term is required.")]
    public string? Term { get; set; }

    [Required(ErrorMessage = "Session is required.")]
    public string? Session { get; set; }

    public bool IsActive { get; set; }
    public bool IsSelected { get; set; }
    public bool IsResultPublished { get; set; }
    public DateTime? LastUpdated { get; set; }
}