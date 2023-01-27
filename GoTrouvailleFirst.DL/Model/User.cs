using System;
using System.Collections.Generic;

namespace GoTrouvailleFirst.DL.Model
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CountryCode { get; set; }
        public string? ContactNumber { get; set; }
        public string? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Email { get; set; }
        public string? Profession { get; set; }
        public string? Location { get; set; }
        public string? Status { get; set; }
        public string? AadharNumber { get; set; }
        public DateTime? Date { get; set; }
        public bool? IsPassport { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? StateId { get; set; }
        public Guid? CountryId { get; set; }

        public virtual Country? Country { get; set; }
        public virtual State? State { get; set; }
    }
}
