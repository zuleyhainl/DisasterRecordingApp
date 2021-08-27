using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class DisasterContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//hangi veri tabanıyla ilişkili belirtilir
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database = DisasterRecording;Integrated Security=true;");
           
        }
        //hangi nesnem hangi tabloya karşılık
        
        public DbSet<Disaster> Disasters { get; set; }
        //public DbSet<DisasterImg> DisasterImgs { get; set; }
        public DbSet<DisasterType> DisasterTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        
    }
}
