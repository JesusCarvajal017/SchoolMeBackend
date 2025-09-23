using Entity.Enum;

namespace Utilities.helpers
{
    public static class DaysExtensions
    {

        // Mapa en español (ajústalo si quieres inglés)
        private static readonly (Days flag, string text)[] Map =
        {
            (Days.Monday,    "Lunes"),
            (Days.Tuesday,   "Martes"),
            (Days.Wednesday, "Miércoles"),
            (Days.Thursday,  "Jueves"),
            (Days.Friday,    "Viernes"),
            (Days.Saturday,  "Sábado"),
            (Days.Sunday,    "Domingo"),
        };

        public static IEnumerable<string> ToTexts(this Days flags)
            => Map.Where(x => flags.HasFlag(x.flag)).Select(x => x.text);

        public static string ToCsv(this Days flags, string sep = ", ")
            => string.Join(sep, flags.ToTexts());

        public static Days FromTexts(IEnumerable<string> texts)
        {
            if (texts == null) return Days.None;
            Days acc = Days.None;

            foreach (var t in texts)
            {
                var match = Map.FirstOrDefault(x =>
                    string.Equals(x.text, t, StringComparison.OrdinalIgnoreCase));
                if (match.flag != default) acc |= match.flag;
            }
            return acc;
        }

        // Si te llega "Monday, Friday" (inglés) y quieres soportarlo:
        private static readonly (Days flag, string en)[] MapEn =
        {
            (Days.Monday,    "Monday"),
            (Days.Tuesday,   "Tuesday"),
            (Days.Wednesday, "Wednesday"),
            (Days.Thursday,  "Thursday"),
            (Days.Friday,    "Friday"),
            (Days.Saturday,  "Saturday"),
            (Days.Sunday,    "Sunday"),
        };

        public static Days FromCsvEnglish(string csv)
        {
            if (string.IsNullOrWhiteSpace(csv)) return Days.None;
            var parts = csv.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            Days acc = Days.None;
            foreach (var p in parts)
            {
                var m = MapEn.FirstOrDefault(x => string.Equals(x.en, p, StringComparison.OrdinalIgnoreCase));
                if (m.flag != default) acc |= m.flag;
            }
            return acc;
        }

    }
}
