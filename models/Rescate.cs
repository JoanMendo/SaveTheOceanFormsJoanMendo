namespace SaveTheOceanFormJoanMendo.Model;

    public class Rescate
    {
        public string NumeroRescate { get; set; }
        public DateTime FechaRescate { get; set; }
        public string Superfamilia { get; set; }
        public int GradoAfectacion { get; set; }
        public string Localizacion { get; set; }

        public Rescate(string superfamilia, int gradoAfectacion, string localizacion)
        {
            NumeroRescate = "RES" + new Random().Next(0, 1001);
            FechaRescate = DateTime.Now;
            Superfamilia = superfamilia;
            GradoAfectacion = gradoAfectacion;
            Localizacion = localizacion;
        }

        public Rescate() { }

        public static Rescate GenerarRescateAleatorio(string superFamilia)
        {
            int gradoAfectacion = new Random().Next(1, 99);
            string[] localizaciones = ["En la ubicación", "En el CRAM"];
            string localizacion = localizaciones[new Random().Next(0, 2)];
            return new Rescate(superFamilia, gradoAfectacion, localizacion);
        }

        public override string ToString()
        {
            return $"Información del Rescate:\n" +
                    $"------------------------\n" +
                    $"Número de Rescate: {NumeroRescate}\n" +
                    $"Fecha del Rescate: {FechaRescate}\n" +
                    $"Superfamilia: {Superfamilia}\n" +
                    $"Grado de Afectación: {GradoAfectacion}%\n" +
                    $"Localización: {Localizacion}";
        }
    }

