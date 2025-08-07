using Entity.ConfigModels.global;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.ConfigModels.Security
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("person", schema: "security");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(p => p.FisrtName)
                .HasColumnName("fisrtName")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.SecondName)
               .HasColumnName("secondName")
               .IsRequired()
               .HasMaxLength(100);

            builder.Property(p => p.LastName)
                .HasColumnName("lastName")
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(p => p.SecondLastName)
             .HasColumnName("secondLastName")
             .IsRequired()
             .HasMaxLength(100);

            builder.Property(p => p.Identification)
               .HasColumnName("identification")
               .IsRequired();

            builder.Property(p => p.Nation)
            .HasColumnName("nation")
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.Phone)
               .HasColumnName("phone")
               .IsRequired();

            builder.Property(p => p.Gender)
               .HasColumnName("gender")
               .IsRequired();

            builder.Property(p => p.Age)
              .HasColumnName("age")
              .IsRequired();

            builder.HasOne(ur => ur.DocumentType)
              .WithMany(r => r.Persons)
              .HasForeignKey(ur => ur.DocumentTypeId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.MapBaseModel();

        }
    }
}
