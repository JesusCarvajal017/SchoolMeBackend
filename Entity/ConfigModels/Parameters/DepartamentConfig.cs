using Entity.ConfigModels.global;
using Entity.Model.Paramters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.ConfigModels.Parameters
{
    public class DepartamentConfig : IEntityTypeConfiguration<Departament>
    {
        public void Configure(EntityTypeBuilder<Departament> builder)
        {
            builder.ToTable("departamet");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .IsRequired();
            builder.Property(p => p.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(100);


            builder.MapBaseModel();

            builder.HasData(
                new Departament { Id = 1, Name = "Amazonas" },
                new Departament { Id = 2, Name = "Antioquia" },
                new Departament { Id = 3, Name = "Arauca" },
                new Departament { Id = 4, Name = "Atlántico" },
                new Departament { Id = 5, Name = "Bolívar" },
                new Departament { Id = 6, Name = "Boyacá" },
                new Departament { Id = 7, Name = "Caldas" },
                new Departament { Id = 8, Name = "Caquetá" },
                new Departament { Id = 9, Name = "Casanare" },
                new Departament { Id = 10, Name = "Cauca" },
                new Departament { Id = 11, Name = "Cesar" },
                new Departament { Id = 12, Name = "Chocó" },
                new Departament { Id = 13, Name = "Córdoba" },
                new Departament { Id = 14, Name = "Cundinamarca" },
                new Departament { Id = 15, Name = "Guainía" },
                new Departament { Id = 16, Name = "Guaviare" },
                new Departament { Id = 17, Name = "Huila" },
                new Departament { Id = 18, Name = "La Guajira" },
                new Departament { Id = 19, Name = "Magdalena" },
                new Departament { Id = 20, Name = "Meta" },
                new Departament { Id = 21, Name = "Nariño" },
                new Departament { Id = 22, Name = "Norte de Santander" },
                new Departament { Id = 23, Name = "Putumayo" },
                new Departament { Id = 24, Name = "Quindío" },
                new Departament { Id = 25, Name = "Risaralda" },
                new Departament { Id = 26, Name = "San Andrés y Providencia" },
                new Departament { Id = 27, Name = "Santander" },
                new Departament { Id = 28, Name = "Sucre" },
                new Departament { Id = 29, Name = "Tolima" },
                new Departament { Id = 30, Name = "Valle del Cauca" },
                new Departament { Id = 31, Name = "Vaupés" },
                new Departament { Id = 32, Name = "Vichada" }
            );

        }
    }
}
