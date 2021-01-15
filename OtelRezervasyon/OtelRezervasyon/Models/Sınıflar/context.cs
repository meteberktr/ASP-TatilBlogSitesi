using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OtelRezervasyon.Models.Sınıflar
{
    public class context: DbContext
{
        public DbSet<Admin>Admins { get; set; }
        public DbSet<AdresYer> AdresYers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }

    }
}