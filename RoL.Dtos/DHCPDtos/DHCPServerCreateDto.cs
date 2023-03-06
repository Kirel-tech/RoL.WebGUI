namespace RoL.Dtos.DHCPDtos;

public class DHCPServerCreateDto
{
    public string DNS { get; set; } = "";
    public bool Enabled { get; set; }
    public string Gateway { get; set; } = "";
    public string Interface { get; set; } = "";
    public int LeaseTime { get; set; }
    public string Mask { get; set; } = "";
    public string NTP { get; set; } = "";
    public int Port { get; set; }
    public string Range { get; set; } = "";
    public string ServerId { get; set; } = "";
}