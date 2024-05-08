namespace SaveTheOceanFormJoanMendo.Model;

    public class Jugador
    {
        public string Nombre { get; set; }
        public int Experiencia { get; set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Experiencia = 0;
        }
        public void GanarExperiencia(int puntos)
        {
            Experiencia += puntos;
        }


    }

