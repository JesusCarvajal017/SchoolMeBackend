using Entity.ConfigModels.global;
using Entity.Model.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.ConfigModels.Business
{
    public class AttendantsConfig : IEntityTypeConfiguration<Attendants>
    {
        public void Configure(EntityTypeBuilder<Attendants> builder)
        {
            // Tabla y esquema
            builder.ToTable("attendants", schema: "business");

            // PK (de ABaseEntity)
            builder.HasKey(a => a.Id);

            // Columnas
            builder.Property(a => a.Id)
                   .HasColumnName("id")
                   .IsRequired();

            builder.Property(a => a.StudentId)
                   .HasColumnName("student_id")
                   .IsRequired();

            builder.Property(a => a.PersonId)
                   .HasColumnName("person_id")
                   .IsRequired();

            // Enum -> número (portátil para SQL Server / PostgreSQL / MySQL)
            builder.Property(a => a.RelationShipTypeEnum)
                   .HasColumnName("relationship_type")
                   .HasConversion<int>()     // guarda como int; si prefieres byte, usa .HasConversion<byte>()
                   .IsRequired();

            // Auditoría / estado comunes
            builder.MapBaseModel();

            // ÚNICO: un mismo Person no debe repetirse como acudiente del mismo Student
            builder.HasIndex(a => new { a.StudentId, a.PersonId })
                   .HasDatabaseName("uq_attendants_student_person")
                   .IsUnique();

            // Índices de apoyo
            //builder.HasIndex(a => a.StudentId).HasDatabaseName("ix_attendants_student");
            //builder.HasIndex(a => a.PersonId).HasDatabaseName("ix_attendants_person");

            // (Opcional) CHECK de rango para el enum (siempre que tu enum sea 1..N conocidos)
            // Nota: MySQL < 8.0.16 ignora CHECKs
            // builder.HasCheckConstraint("ck_attendants_relationship_type", "[relationship_type] BETWEEN 1 AND 5");

            // Relaciones
            builder.HasOne(a => a.Student)
                   .WithMany(s => s.Attendants)         // agrega ICollection<Attendants> en Student si la quieres
                   .HasForeignKey(a => a.StudentId)
                   .HasConstraintName("fk_attendants_student")
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Person)
                   .WithMany(p => p.Attendants)         // agrega ICollection<Attendants> en Person si la quieres
                   .HasForeignKey(a => a.PersonId)
                   .HasConstraintName("fk_attendants_person")
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
