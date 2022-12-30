namespace RoL.Dtos.DHCPDtos;

public class DHCPServerUpdateDto
{
    public string DNS { get; set; }
    public bool Enabled { get; set; }
    public int LeaseTime { get; set; }
    public string NTP { get; set; }
    public int Port { get; set; }
}