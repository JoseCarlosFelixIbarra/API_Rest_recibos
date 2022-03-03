using Microsoft.EntityFrameworkCore;
using API_Rest_recibos.Models;
using System.Threading.Tasks;
using System;

namespace API_Rest_recibos.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option) : base(option) { 
        
        }

        public DbSet<recibo_model> recibo { get; set; }

        public DbSet<usuario_model> usuario { get; set; }

    }
}
