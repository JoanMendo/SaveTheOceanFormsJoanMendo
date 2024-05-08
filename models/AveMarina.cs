namespace SaveTheOceanFormJoanMendo.Model;

    public class AveMarina : AAnimal
    {
        public AveMarina() : base(GenerarNombreAleatorio(), "Ave Marina", "Pajarus Marinus", GenerarPeso())
        {

        }

       
        public override int AplicarTratamiento(string localizacion, int gradoAfectacion)
        {
            bool curarEnLocalizacion = localizacion == "En el CRAM";
            int x = curarEnLocalizacion ? 5 : 0;
            int nuevoGradoAfectacion = (gradoAfectacion - x) / 5;
            return nuevoGradoAfectacion;
        }

       
        private static string GenerarNombreAleatorio()
        {
            string[] nombres = ["Victor", "Avemaria", "Pajarraco", "Colomer", "Puigdemont", "Bing Chillling"];
            return nombres[new Random().Next(0, nombres.Length)];
        }

       
        private static double GenerarPeso()
        {
            Random random = new Random();
            double pesoAleatorio = random.NextDouble() * (4 - 2) + 6;
            return Math.Round(pesoAleatorio, 2);
        }
    }

