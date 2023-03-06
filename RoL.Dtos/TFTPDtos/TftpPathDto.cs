namespace RoL.Dtos.TFTPDtos;

public class TftpPathDto
{
    public string ActualPath { get; set; } = "";
    public DateTime CreatedAt { get; set; } = new();
    public string Id { get; set; } = "";
    public DateTime UpdatedAt { get; set; } = new();
    public string VirtualPath { get; set; } = "";
}