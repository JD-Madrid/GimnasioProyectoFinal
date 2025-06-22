using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal_GYM.Models
{
    public class GymContext: DbContext
    {
        public DbSet<Cliente> clientes{ get; set; }
        public DbSet<Plan> planes { get; set; }
        public DbSet<Actividad> actividades{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BJ002AS\\SQLEXPRESS;Initial Catalog=GimnasioDB;" +
                " Integrated Security= true; TrustServerCertificate= true; Encrypt= true");
            base.OnConfiguring(optionsBuilder);
        }

    


}
}
