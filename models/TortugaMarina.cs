namespace SaveTheOceanFormJoanMendo.Model;

    public class TortugaMarina : AAnimal
    {
        public TortugaMarina() : base(GenerarNombreAleatorio(), "Tortuga Marina", "Chelonia mydas", GenerarPeso())
        {

        }
        private static double GenerarPeso()
        {
            Random random = new Random();
            double pesoAleatorio = random.NextDouble() * (153.0 - 40.0) + 80.0;
            return Math.Round(pesoAleatorio, 2);
        }
    public override int AplicarTratamiento(string localizacion, int gradoAfectacion)
        {
            int x = 5;
            int nuevoGradoAfectacion = (2 * gradoAfectacion + 3) - ((gradoAfectacion - 20) * 2) - x;
            return nuevoGradoAfectacion;
        }

        private static string GenerarNombreAleatorio()
        {
            string[] nombres = ["Maestro Oogway", "Torticulis", "Mariano Rajoy", "ProductID", "Trotuman"];
            return nombres[new Random().Next(0, nombres.Length)];
        }

        
    }

