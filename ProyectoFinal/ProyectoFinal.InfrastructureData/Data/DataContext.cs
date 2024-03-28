using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.InfrastructureData.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<FichaClienteEntity> Fichas { get; set; }
        public DbSet<RegistroEntity> Registros { get; set; }
        public DbSet<UsuarioSalonEntity> UsuariosSalon { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }

        public override int SaveChanges()
        {
            try
            {
                AddAuditoryAttributes();
                //List<AuditEntry> auditEntries = GetAuditEntries();
                int response = base.SaveChanges();
                //SaveAuditOtherDB(auditEntries);
                return response;
            }
            catch (Exception ex)
            {
                this.ChangeTracker.Clear();
                throw ex;
            }
        }

        private void AddAuditoryAttributes()
        {
            this.ChangeTracker.DetectChanges();
            var added = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Added)
                        .Select(t => t.Entity)
                        .ToArray();

            foreach (var entity in added)
            {
                if (entity is BaseEntity)
                {
                    var track = entity as BaseEntity;
                    track.CreatedDate = DateTime.Now;
                    track.CreatedBy = 1;
                    track.Status = true;
                }
            }

            var modified = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Modified)
                        .Select(t => t.Entity)
                        .ToArray();

            foreach (var entity in modified)
            {
                if (entity is BaseEntity)
                {
                    var track = entity as BaseEntity;
                    track.UpdatedDate = DateTime.Now;
                    track.UpdatedBy = 1;
                }
            }
        }
    }


}
