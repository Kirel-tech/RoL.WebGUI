namespace RoL.Dtos;

public class ValidationErrorDto
{
    public List<ValidationErrorElement> Errors { get; set; }
    public string Message { get; set; }
}
public class ValidationErrorElement
{
    public string Error { get; set; }
    public string Field { get; set; }
    public string Sourse { get; set; }
}