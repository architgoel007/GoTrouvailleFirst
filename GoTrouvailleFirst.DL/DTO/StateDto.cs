using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTrouvailleFirst.DL.DTO
{
    public class StateDto
    {
        public Guid Id { get; set; }
        public Guid? CountryId { get; set; }
        public string? CountryName { get; set; }
        public string? StateName { get; set; }
    }
}
