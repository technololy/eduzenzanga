using System.ComponentModel.DataAnnotations;

namespace EduZanga.Model;

public class CreateLessonNoteModel
{
    [Required(ErrorMessage = "Subject is required.")]
    public string Subject { get; set; }

    [Required(ErrorMessage = "Class is required.")]
    public string Class { get; set; }

    [Required(ErrorMessage = "Week is required.")]
    public string Week { get; set; }

    [Required(ErrorMessage = "Title is required.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Term is required.")]
    public string Term { get; set; }

    [Required(ErrorMessage = "Session is required.")]
    public string Session { get; set; }
}