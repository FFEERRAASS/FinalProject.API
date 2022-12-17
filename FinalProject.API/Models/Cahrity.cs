using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProject.API.Models
{
    public partial class Cahrity
    {
        public Cahrity()
        {
            Documents = new HashSet<Document>();
        }

        public decimal Charityid { get; set; }
        public decimal? UseridFk { get; set; }
        public decimal? DocidFk { get; set; }
        public string Imagepath { get; set; }
        public decimal? Goal { get; set; }
        public string Email { get; set; }
        public decimal? Numdonation { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Isaccepted { get; set; }
        public decimal? CategoryidFk { get; set; }
        public decimal? State { get; set; }

        public virtual Category CategoryidFkNavigation { get; set; }
        public virtual User UseridFkNavigation { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}
