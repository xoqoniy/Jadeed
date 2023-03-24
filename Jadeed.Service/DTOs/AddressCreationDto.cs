using System;

namespace Jadeed.Service.DTOs;

public class AddressCreationDto
{
    public long Id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string Street { get; set; }
    public string ZipCode { get; set; }
    public string Home { get; set; }


}
