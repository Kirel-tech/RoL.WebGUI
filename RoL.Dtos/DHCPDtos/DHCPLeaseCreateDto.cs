namespace RoL.Dtos.DHCPDtos;

public class DHCPLeaseCreateDto
{
    public DateTime Expires { get; set; } 
    public string Ip { get; set; } = "";
    public string Mac { get; set; } = "";
}