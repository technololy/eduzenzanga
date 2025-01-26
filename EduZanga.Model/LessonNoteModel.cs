namespace EduZanga.Model;

public class LessonNoteModel
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Class { get; set; }
    public string Week { get; set; }
    public string Title { get; set; }
    public string Term { get; set; }
    public string Session { get; set; }
    public bool IsPublished { get; set; }
}