using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JDMarketplace.Domain.Entity.User
{
    public class ApplicationRole
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string NormalizedName { get; set; }
    }
}
