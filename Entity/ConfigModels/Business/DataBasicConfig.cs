using Entity.ConfigModels.global;
using Entity.Model.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.ConfigModels.Business
{
    public class DataBasicConfig : IEntityTypeConfiguration<DataBasic>
    {
        public void Configure(EntityTypeBuilder<DataBasic> builder)
        {
            builder.ToTable("dataBasic", schema: "business");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .IsRequired();
            builder.Property(p => p.PersonId)
                .HasColumnName("personaId")
                .IsRequired();

            builder.Property(p => p.RhId)
                .HasColumnName("rhId")
                .IsRequired();

            builder.Property(p => p.Adress)
                .HasColumnName("adress")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.BrithDate)
                .HasColumnName("birthDate")
                .HasColumnType("timestamp")
                .IsRequired();

            builder.Property(p => p.StratumStatus)
                .HasColumnName("stratumStatus")
                .IsRequired();

            builder.Property(p => p.MaterialStatusId)
                .HasColumnName("materialStatusId")
                .IsRequired();

            builder.Property(p => p.EpsId)
                .HasColumnName("epsId")
                .IsRequired();

            builder.Property(p => p.MunisipalityId)
                .HasColumnName("munisipalityId")
                .IsRequired();

            // Llaves foraenas
            builder.HasOne(db => db.Person)       
             .WithOne(p => p.DataBasic)     
             .HasForeignKey<DataBasic>(db => db.PersonId)  
             .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ur => ur.Rh)
              .WithMany(r => r.DataBasics)
              .HasForeignKey(ur => ur.RhId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ur => ur.Eps)
              .WithMany(r => r.DataBasics)
              .HasForeignKey(ur => ur.EpsId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ur => ur.Munisipality)
              .WithMany(r => r.DataBasics)
              .HasForeignKey(ur => ur.MunisipalityId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ur => ur.MaterialStatus)
              .WithMany(r => r.DataBasic)
              .HasForeignKey(ur => ur.MaterialStatusId)
              .OnDelete(DeleteBehavior.Restrict);


            builder.MapBaseModel();

      
        }
    }
}
