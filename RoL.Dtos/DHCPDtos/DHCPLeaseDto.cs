namespace RoL.Dtos.DHCPDtos;

public class DHCPLeaseDto
{
    public DateTime CreatedAt { get; set; } = new();
    public DateTime Expires { get; set; } = new();
    public string Id { get; set; } = "";
    public string Ip { get; set; } = "";
    public string Mac { get; set; } = "";
    public DateTime UpdatedAt { get; set; } = new();
}