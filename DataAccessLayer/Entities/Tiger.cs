using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Tiger
    {
        [Key]
        public Guid Id { get; set; }

        public string Color { get; set; }

        public int Weight { get; set; }

        public string Age { get; set; }
    }
}
