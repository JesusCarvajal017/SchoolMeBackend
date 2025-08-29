
using Entity.ConfigModels.global;
using Entity.Model.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.ConfigModels.Business
{
    public class AgendaConfig : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.ToTable("agenda", schema: "business");

            //builder.HasKey(p => p.Id);

            //builder.Property(p => p.Id)
            //    .HasColumnName("id")
            //    .IsRequired();

            //builder.Property(p => p.GroupId)
            //    .HasColumnName("groupId")
            //    .IsRequired();

            //// FK: Agenda N:1 Group
            //builder.HasOne(a => a.Group)
            //    .WithMany(g => g.Agenda)
            //    .HasForeignKey(a => a.GroupId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.MapBaseModel();
        }


        
    }
}
