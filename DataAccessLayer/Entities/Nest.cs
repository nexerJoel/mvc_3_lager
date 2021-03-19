using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Nest
    {
        [Key]
        public Guid Id { get; set; }

        public NestType Type { get; set; }

        public bool FirstChoice { get; set; }

        public virtual Tiger Tiger { get; set; }
    }
}
