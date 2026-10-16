using Microsoft.EntityFrameworkCore;
using Tiendaonline.API.Models;

namespace Tiendaonline.API.Data
{
    public class TiendaonlineDbContext :DbContext
    {
        public TiendaonlineDbContext(DbContextOptions<TiendaonlineDbContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<MetodoPago> MetodosPago { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

    }
}
