using System;
using System.Collections.Generic;

namespace Template.Net.Datas.Entities
{
    public partial class User
    {
        public User()
        {
            Penjuals = new HashSet<Penjual>();
        }

        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Tipe { get; set; }

        public virtual ICollection<Penjual> Penjuals { get; set; }
    }
}
