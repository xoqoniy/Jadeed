using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadeed.Service.DTOs
{
    public class OrganizationCreationDto
    {
        public string Title { get; set; }
        public long AddressId { get; set; }
        public string Document { get; set; }
        public string Description { get; set; }
        //public OrganizationType Type { get; set; }
    }
}
