using Entity.ConfigModels.global;
using Entity.Model.Paramters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.ConfigModels.Parameters
{
    public class GroupsConfig : IEntityTypeConfiguration<Groups>
    {
        public void Configure(EntityTypeBuilder<Groups> builder)
        {

            // Tabla y esquema (cámbialo a "parameters" si lo prefieres)
            builder.ToTable("groups", schema: "parameters");

            // Clave primaria
            builder.HasKey(g => g.Id);

            // Columnas
            builder.Property(g => g.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(g => g.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(g => g.GradeId)
                .HasColumnName("grade_id")
                .IsRequired();

            builder.Property(g => g.AmountStudents)
                .HasColumnName("amount_students")
                .IsRequired()
                .HasDefaultValue(0);

           
            builder.MapBaseModel();

            // Relaciones
            builder.HasOne(g => g.Grade)
                .WithMany() // usa .WithMany(x => x.Groups) si tienes la colección en Grade
                .HasForeignKey(g => g.GradeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Índices
            //builder.HasIndex(g => new { g.GradeId, g.Name })
            //    .IsUnique(); // un nombre de grupo único por grado



        }
    }
}
