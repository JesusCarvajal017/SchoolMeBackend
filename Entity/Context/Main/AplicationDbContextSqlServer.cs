using Entity.ConfigModels.Parameters;
using Entity.ConfigModels.Security;
using Entity.Model.Business;
using Entity.Model.Paramters;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;

namespace Entity.Context.Main
{
    public class AplicationDbContextSqlServer : DbContext
    {
        public AplicationDbContextSqlServer(DbContextOptions<AplicationDbContext> options ) : base (options)
        {
                    
        }

        // Modulo de seguridad
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
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<TypeAnsware> TypeAnsware { get; set; }


        //Modulo de negocio
        public DbSet<DataBasic> DataBasic { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

    

            // Aplica tu configuración que implementen IEntityTypeConfiguration<T>

            // Prioridad de crecion 1
            modelBuilder.ApplyConfiguration(new DepartamentConfig());
            modelBuilder.ApplyConfiguration(new MunisipalityConfig());
            modelBuilder.ApplyConfiguration(new RhConfig());
            modelBuilder.ApplyConfiguration(new EpsConfig());
            modelBuilder.ApplyConfiguration(new DocumentTypeConfig());
            modelBuilder.ApplyConfiguration(new MaterialStatusConfig());
            modelBuilder.ApplyConfiguration(new GradeConfig());
            modelBuilder.ApplyConfiguration(new SubjectConfig());
            modelBuilder.ApplyConfiguration(new TypeAnswareConfig());


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
            


        }


    }
}
