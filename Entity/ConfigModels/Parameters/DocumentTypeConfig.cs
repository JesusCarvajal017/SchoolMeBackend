using Entity.ConfigModels.global;
using Entity.Model.Paramters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.ConfigModels.Parameters
{
    public class DocumentTypeConfig : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.ToTable("documentType", schema: "parameters");

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
                new DocumentType
                {
                    Id = 1,
                    Name = "Cedula Ciudadana",
                    Acronym = "C.C"
                    
                },
                 new DocumentType
                 {
                     Id = 2,
                     Name = "Targeta de identidad",
                     Acronym = "T.I"

                 },
                  new DocumentType
                  {
                      Id = 3,
                      Name = "Registro civil",
                      Acronym = "R.C"

                  }
            );
        }
    }
}
