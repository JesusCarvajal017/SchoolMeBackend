using Entity.ConfigModels.Business;
using Entity.ConfigModels.Parameters;
using Entity.ConfigModels.Security;
using Entity.Model.Business;
using Entity.Model.Paramters;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Entity.Context.Main
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options ) : base (options)
        {
                    
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<Form> Form { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<UserRol> UserRol { get; set; }
        public DbSet<ModuleForm> ModuleForm { get; set; }
        public DbSet<RolFormPermission> RolFormPermission { get; set; }

        //Modulo de parametros
        public DbSet<Departament> Departament { get; set; }
        public DbSet<Munisipality> Munisipality { get; set; }
        public DbSet<DocumentType> DocumentType { get; set; }
        public DbSet<Eps> Eps { get; set; }
        public DbSet<MaterialStatus> MaterialStatus { get; set; }
        public DbSet<Rh> Rh { get; set; }

        //Modulo de parametros

        public DbSet<Estudent> DataBasic { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplica tu configuración que implementen IEntityTypeConfiguration<T>

            //Modulo de seguridad
            modelBuilder.ApplyConfiguration(new DepartamentConfig());
            modelBuilder.ApplyConfiguration(new MunisipalityConfig());
            modelBuilder.ApplyConfiguration(new RhConfig());
            modelBuilder.ApplyConfiguration(new EpsConfig());
            modelBuilder.ApplyConfiguration(new DocumentTypeConfig());
            modelBuilder.ApplyConfiguration(new MaterialStatusConfig());

            modelBuilder.ApplyConfiguration(new ModuleConfig());
            modelBuilder.ApplyConfiguration(new FormConfig());
            modelBuilder.ApplyConfiguration(new RolConfig());
            modelBuilder.ApplyConfiguration(new PermissionConfig());
            
            modelBuilder.ApplyConfiguration(new ModuleFormConfig());
            modelBuilder.ApplyConfiguration(new RolFormPermissionConfig());

            // Modulo de parametros

            modelBuilder.ApplyConfiguration(new PersonConfig());

            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new UserRolConfig());

            //Modulo de negocio
            modelBuilder.ApplyConfiguration(new DataBasicConfig());
        }


    }
}
