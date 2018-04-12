using LabEF.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEF.ConsoleApp.Data
{
    class FatturarioContext : DbContext
    {


        public DbSet<Fattura> MyProperty { get; set; }

        public DbSet<VoceFattura> VociFatture { get; set; }

        public FatturarioContext():base("FatturarioDbConnection")
        {
        }

    }
}
