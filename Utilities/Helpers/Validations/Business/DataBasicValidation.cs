using Entity.Dtos.Business.DataBasic;
using FluentValidation;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Utilities.Helpers.Business
{
    public class DataBasicValidation : AbstractValidator<DataBasicDto>
    {

        // Patrón básico para direcciones urbanas en Colombia
        private static readonly Regex AddressCoRegex = new Regex(
            @"^(?:
            (?:Cl|Calle|Cra|Carrera|Av|Avenida|Tv|Transv|Transversal|Dg|Diagonal|Autop(?:ista)?)\.?\s+   # tipo de vía
          )
          \d{1,3}[A-Z]?                                             # número principal (ej. 100, 8A)
          (?:\s*(?:Sur|Norte|Este|Oeste|Occidente))?                # sufijo de orientación opcional
          \s*(?:No\.?|#)\s*                                         # separador No./#
          \d{1,3}[A-Z]?                                             # número secundario
          \s*-\s*
          \d{1,3}                                                   # número complementario
          (?:\s*(?:Int\.?|Interior|Apto\.?|Apartamento|Of\.?|Oficina|Torre|Piso)\s*\w+)*  # complementos
          \s*$",
            RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.IgnorePatternWhitespace
        );

        public DataBasicValidation()
        {
            RuleFor(x => x.PersonId)
                .GreaterThan(0)
                 .WithMessage("El id de la persona no es valido.")
            .NotEmpty().WithMessage("El id de la persona es obligatorio");

            RuleFor(x => x.RhId)
                .GreaterThan(0)
                 .WithMessage("El id de rh no es valido.")
                .NotEmpty().WithMessage("El id del rh es obligatorio");

            RuleFor(x => x.Status)
                .InclusiveBetween(0, 5)
                .WithMessage("El estado debe estar entre 0 y 5.");

            RuleFor(x => x.Adress)
              .Cascade(CascadeMode.Stop)
              // Obligatoria (no nula/espacios)
              .Must(v => !string.IsNullOrWhiteSpace(v))
                  .WithMessage("La dirección es obligatoria.")
              // Longitud 8–100 considerando Trim
              .Must(v => {
                  var s = v!.Trim();
                  return s.Length >= 8 && s.Length <= 100;
              })
                  .WithMessage("La dirección debe tener entre 8 y 100 caracteres.")

              // Formato (evaluado sobre el Trim)
              .Must(v => AddressCoRegex.IsMatch(v!.Trim()))
                  .WithMessage("Formato inválido. Ejemplos: 'Cra 15 # 85-24', 'Calle 100 # 8A-55'.");


                RuleFor(x => x.BrithDate)
                .NotEmpty().WithMessage("La fecha de nacimiento es obligatoria.")
                .Matches(@"^\d{2}-\d{2}-\d{4}$")
                    .WithMessage("Usa el formato dd-MM-yyyy (ej: 26-08-2025).")
                .Must(s => DateTime.TryParseExact(s, "dd-MM-yyyy",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                    .WithMessage("Fecha inválida. Usa dd-MM-yyyy.");

                RuleFor(x => x.StratumStatus)
                    .InclusiveBetween(0, 5)
                    .WithMessage("Los valores validos debe estar entre 0 y 5.");

                RuleFor(x => x.EpsId)
                    .GreaterThan(0)
                     .WithMessage("El id de la eps no es valido.")
                .NotEmpty().WithMessage("El id de la eps es obligatorio");

                RuleFor(x => x.MunisipalityId)
                       .GreaterThan(0)
                        .WithMessage("El id del municipio no es valido.")
                   .NotEmpty().WithMessage("El id del municipio es obligatorio");
        }


    }

        //RuleFor(x => x.Name)
        //.Cascade(CascadeMode.Stop)
        //.NotEmpty().WithMessage("El nombre es obligatorio.")
        //.Must(s => !string.IsNullOrWhiteSpace(s))
        //    .WithMessage("El nombre no puede ser solo espacios.")
        //.Matches(@"^[\p{L}\s'\-]+$") // letras Unicode + espacios + ' y -
        //    .WithMessage("El nombre solo puede contener letras y espacios (sin números).")
        // .MinimumLength(4).WithMessage("El nombre debe tener al menos 4 caracteres.")
        // .MaximumLength(15).WithMessage("El nombre no puede exceder 15 caracteres.");
    
    
}
