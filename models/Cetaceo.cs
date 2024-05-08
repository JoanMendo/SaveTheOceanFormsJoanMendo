namespace SaveTheOceanFormJoanMendo.Model;

    public class Cetaceo : AAnimal
    {
        public Cetaceo() : base(GenerarNombreAleatorio(), "Cetaceo", "Cetaceum Cetonis", GenerarPeso())
        {

        }


        private static string GenerarNombreAleatorio()
        {
            string[] nombres = ["Victor", "Willyrex", "Isabel Ayuso", "Nicky Nicole", "CetaceoXML", "Employee"];
            return nombres[new Random().Next(0, nombres.Length)];
        }

        public override int AplicarTratamiento(string localizacion, int gradoAfectacion)
        {
            bool curarEnLocalizacion = localizacion == "En el CRAM";
            int x = curarEnLocalizacion ? 50 : 0;
            int nuevoGradoAfectacion = gradoAfectacion - ((gradoAfectacion / 5) + x);
            return nuevoGradoAfectacion;
        }
   
        private static double GenerarPeso()
        {
            Random random = new Random();
            double pesoAleatorio = random.NextDouble() * (524.0 - 72.0) + 100.0;
            return Math.Round(pesoAleatorio, 2);
        }
    }

