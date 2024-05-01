using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSQLite.Models
{
    public class Supplier
    {
        public int Id { get; set; } // PK pro databázovou tabulku

        public string Name { get; set; }
        public string Address { get; set; }

        public string City { get; set; }
        public string PSC { get; set; }

        public string ICO { get; set; }

        public string DIC { get; set; }

        public override string ToString()
        {
            return $"{Name} {Address} {City} {PSC} {ICO} {DIC}";
        }
    }
}
