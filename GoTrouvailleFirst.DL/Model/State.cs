using System;
using System.Collections.Generic;

namespace GoTrouvailleFirst.DL.Model
{
    public partial class State
    {
        public State()
        {
            Users = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public Guid? CountryId { get; set; }
        public string? StateName { get; set; }

        public virtual Country IdNavigation { get; set; } = null!;
        public virtual ICollection<User> Users { get; set; }
    }
}
