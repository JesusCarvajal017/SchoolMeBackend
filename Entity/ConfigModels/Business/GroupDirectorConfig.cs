using Entity.ConfigModels.global;
using Entity.Model.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.ConfigModels.Business
{
    public class GroupDirectorConfig : IEntityTypeConfiguration<GroupDirector>
    {
        public void Configure(EntityTypeBuilder<GroupDirector> builder)
        {
            builder.ToTable("group_director", schema: "business");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .HasColumnName("id")
                   .IsRequired();

            builder.Property(x => x.TeacherId)
                   .HasColumnName("teacher_id")
                   .IsRequired();

            // Auditoría/estado de ABaseEntity (created_at, updated_at, status, etc.)
            builder.MapBaseModel();

            // Queremos "un GroupDirector por Teacher" (evita duplicados del mismo docente)
            builder.HasIndex(x => x.TeacherId)
                   .HasDatabaseName("uq_group_director_teacher")
                   .IsUnique();

            builder.HasOne(x => x.Teacher)
                   .WithMany(t => t.GroupDirector)          // colección ya la tienes en Teacher
                   .HasForeignKey(x => x.TeacherId)
                   .HasConstraintName("fk_group_director_teacher")
                   .OnDelete(DeleteBehavior.Restrict);

            //// Relación 1:N con Group (se configura desde Group también)
            //builder.HasMany(x => x.Groups)
            //       .WithOne(g => g.GroupDirector)
            //       .HasForeignKey(g => g.GroupDirectorId)
            //       .HasConstraintName("fk_group_group_director")
            //       .OnDelete(DeleteBehavior.SetNull);        // si borras el director, los grupos quedan sin director

        }
    }
}