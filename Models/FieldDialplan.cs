using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filezilla_integrate.Models
{
    internal class FieldDialplan
    {
        public string? Dialplan { get; set; }
        public int? DestInboundCampaign { get; set; }
        public string? NameMailingField { get; set; }
        public string? Announcer { get; set; }
        public string? Persona { get; set; }
        public char? GenderAnnouncer { get; set; }
        public bool? Enable8Personas { get; set; }
    }
}
