using Entity.ConfigModels.global;
using Entity.Model.Paramters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.ConfigModels.Parameters
{
    public class MunisipalityConfig : IEntityTypeConfiguration<Munisipality>
    {
        public void Configure(EntityTypeBuilder<Munisipality> builder)
        {
            builder.ToTable("munisipality", schema: "parameters");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .IsRequired();
            builder.Property(p => p.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.DepartamentId)
                .HasColumnName("departametId")
                .IsRequired();

            builder.MapBaseModel();

            // Llave foraena
            builder.HasOne(ur => ur.Departament)
               .WithMany(r => r.Munisipalitys)
               .HasForeignKey(ur => ur.DepartamentId)
               .OnDelete(DeleteBehavior.Restrict);


            
        }
    }
}
