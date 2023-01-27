using System;
using System.Collections.Generic;

namespace GoTrouvailleFirst.DL.Model
{
    public partial class Country
    {
        public Country()
        {
            Users = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public string? CountryName { get; set; }

        public virtual State? State { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
