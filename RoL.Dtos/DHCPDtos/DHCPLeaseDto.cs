﻿namespace RoL.Dtos.DHCPDtos;

public class DHCPLeaseDto
{
    public DateTime CreatedAt { get; set; }
    public DateTime Expires { get; set; }
    public string Id { get; set; }
    public string Ip { get; set; }
    public string Mac { get; set; }
    public DateTime UpdatedAt { get; set; }
}