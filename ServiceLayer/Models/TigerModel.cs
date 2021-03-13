using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class TigerModel
    {
        public string Color { get; set; }

        public int Weight { get; set; }
        public Guid Id { get; internal set; }
    }
}
