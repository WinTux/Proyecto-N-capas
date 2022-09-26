using capa_datos.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace capa_datos
{
    public class GestionEmpresaXDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder option) {
            //Ojo acá,,, volver luego
            if (!option.IsConfigured) {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
                var config = builder.Build();
                option.UseSqlServer(config["ConnectionStrings:miConexion"]);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Telefono>(entidad =>
                {
                    entidad.HasOne(t => t.estudiante)
                    .WithMany(es => es.telefonos)
                    .HasForeignKey(t => t.codigoEst)
                    .HasConstraintName("FK_Telefono_Estudiante");
                }
            );
        }

    }
}
