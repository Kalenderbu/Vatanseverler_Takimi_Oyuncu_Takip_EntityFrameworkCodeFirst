using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatanseverlerAnaliz
{
    class TakimDB : DbContext
    {
        public TakimDB() : base("Name=Baglanti")
        {

        }
        public DbSet<Oyuncular> Oyunculars { get; set; }
    }
}
