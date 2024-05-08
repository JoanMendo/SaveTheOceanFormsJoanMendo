namespace SaveTheOceanFormJoanMendo.Model;

public abstract class AAnimal
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Superfamilia { get; set; }
    public string Especie { get; set; }
    public double PesoAproximado { get; set; }

    public AAnimal(string nombre, string superfamilia, string especie, double peso)
    {
        Nombre = nombre;
        Superfamilia = superfamilia;
        Especie = especie;
        PesoAproximado = peso;
    }

   
    public override string ToString()
    {
        return $"Información del Animal:\n" +
                $"------------------------\n" +
                $"Nombre: {Nombre}\n" +
                $"Superfamilia: {Superfamilia}\n" +
                $"Especie: {Especie}\n" +
                $"Peso Aproximado: {PesoAproximado} kg";
    }

    public abstract int AplicarTratamiento(string localizacion, int gradoAfectacion);
}
