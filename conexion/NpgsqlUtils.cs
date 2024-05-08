using Microsoft.Extensions.Configuration;
using Npgsql;
using SaveTheOceanFormJoanMendo.Model;

namespace SaveTheOcean2.Connections
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            //Aqui se ha de cambiar la ruta del archivo appsettings.json, no he encontrado una forma de hacerlo de forma relativa
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"C:\Users\joanm\source\repos\JoanMendo\SaveTheOceanFormsJoanMendo\conexion\appsettings.json")
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static Cetaceo GetCetaceo(NpgsqlDataReader reader)
        {
            Cetaceo cetaceo = new Cetaceo()
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                Superfamilia = reader.GetString(reader.GetOrdinal("superfamilia")),
                Especie = reader.GetString(reader.GetOrdinal("especie")),
                PesoAproximado = reader.GetInt32(reader.GetOrdinal("pesoaproximado")),
            };

            return cetaceo;
        }

        public static AveMarina GetAveMarina(NpgsqlDataReader reader)
        {
            AveMarina aveMarina = new AveMarina()
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                Superfamilia = reader.GetString(reader.GetOrdinal("superfamilia")),
                Especie = reader.GetString(reader.GetOrdinal("especie")),
                PesoAproximado = reader.GetInt32(reader.GetOrdinal("pesoaproximado")),
            };

            return aveMarina;
        }

        public static TortugaMarina GetTortugaMarina(NpgsqlDataReader reader)
        {
            TortugaMarina tortugaMarina = new TortugaMarina()
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                Superfamilia = reader.GetString(reader.GetOrdinal("superfamilia")),
                Especie = reader.GetString(reader.GetOrdinal("especie")),
                PesoAproximado = reader.GetInt32(reader.GetOrdinal("pesoaproximado")),
            };

            return tortugaMarina;
        }

        public static Rescate GetRescate(NpgsqlDataReader reader)
        {
            Rescate rescate = new Rescate()
            {
                NumeroRescate = reader.GetString(reader.GetOrdinal("numerorescate")),
                FechaRescate = reader.GetDateTime(reader.GetOrdinal("fecharescate")),
                Superfamilia = reader.GetString(reader.GetOrdinal("superfamilia")),
                GradoAfectacion = reader.GetInt32(reader.GetOrdinal("gradoafectacion")),
                Localizacion = reader.GetString(reader.GetOrdinal("localizacion"))
            };

            return rescate;
        }
    }
}
