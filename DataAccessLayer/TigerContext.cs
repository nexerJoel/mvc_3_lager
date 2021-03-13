using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //Här finns DbCOntext
using DataAccessLayer.Entities; //En mapp med våra entitetsmodeller

namespace DataAccessLayer
{
    public class TigerContext : DbContext
    {
        public TigerContext()
        {

        }
        // Entities        
        public DbSet<Tiger> Tigers { get; set; }
    }
}
