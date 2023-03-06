namespace RoL.Dtos.TFTPDtos;

public class TftpServerCreateDto
{
    public string Address { get; set; } = "";
    public bool Enabled { get; set; }
    public string Port { get; set; } = "";
}