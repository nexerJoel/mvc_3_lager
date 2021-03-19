using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class NestModel
    {
        public Guid Id { get; set; }
        
        public NestType Type { get; set; }

        public bool FirstChoice { get; set; }
        public Guid Value { get; internal set; }
        public string Text { get; internal set; }
    }
}
