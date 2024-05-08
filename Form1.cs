using SaveTheOcean2.Connections;
using SaveTheOcean2.DAO;
using SaveTheOceanFormJoanMendo.Model;
using SaveTheOcean2.Helper;
using System.Xml;

namespace SaveTheOceanFormsJoanMendo
{
    public partial class Form1 : Form
    {
        public string nombreJugador { get; set; }
        public string rolJugador { get; set; }
        public AnimalDAO animalDAO { get; set; }
        public RescateDAO rescateDAO { get; set; }
        public Rescate rescate { get; set; }
        public Jugador jugador { get; set; }

        public AAnimal animal { get; set; }
        private int finalGA;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jugador = new Jugador(nombreJugador);
            animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
            rescateDAO = new RescateDAO(NpgsqlUtils.OpenConnection());
            int random = new Random().Next(0, 3);

            animal = Helper.GenerarAnimal(random);
            rescate = Helper.GenerarRescate(random);

            RescueName.Text = RescueName.Text + rescate.NumeroRescate;
            RescueDate.Text = RescueDate.Text + rescate.FechaRescate.ToString();
            SpeciesName.Text = SpeciesName.Text +  animal.Superfamilia;
            Afection.Text = Afection.Text + rescate.GradoAfectacion.ToString();
            location.Text = location.Text + rescate.Localizacion;
            ShowAllUsers();

            rescateDAO.AddRescate(rescate);
            animalDAO.AddAnimal(animal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratarAnimal("Localizacion");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TratarAnimal("En el CRAM");
        }

        private void TratarAnimal(string localizacion)
        {
            finalGA = animal.AplicarTratamiento(localizacion, rescate.GradoAfectacion);
            MessageBox.Show(animal.ToString() + $" GA final: {finalGA}");
            if (finalGA <= 30)
            {
                
                jugador.GanarExperiencia(50);
            }
            else
            {  
                jugador.GanarExperiencia(-20);
            }

            SaveUserDataToXML(jugador.Nombre, rolJugador, jugador.Experiencia);

           
            Application.Exit();

          
        }
        private void SaveUserDataToXML(string nombre, string rol, int exp)
        {
            const string path = "../../../userdata.xml";

            if (!File.Exists(path))
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlDeclaration xmlDecl = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlNode rootNode = xmlDoc.CreateElement("usuarios");
                xmlDoc.InsertBefore(xmlDecl, xmlDoc.DocumentElement);
                xmlDoc.AppendChild(rootNode);
                xmlDoc.Save(path);
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlElement usuarioElement = doc.CreateElement("usuario");
            XmlElement nombreElement = doc.CreateElement("nombre");
            nombreElement.InnerText = nombre;
            usuarioElement.AppendChild(nombreElement);

            XmlElement rolElement = doc.CreateElement("rol");
            rolElement.InnerText = rol;
            usuarioElement.AppendChild(rolElement);

            XmlElement xpElement = doc.CreateElement("experiencia");
            xpElement.InnerText = exp.ToString();
            usuarioElement.AppendChild(xpElement);

            doc.DocumentElement.AppendChild(usuarioElement);

            doc.Save(path);
        }
        private void ShowAllUsers()
        {
            const string path = "../../../userdata.xml";
            if (File.Exists(path))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNodeList usuarios = doc.GetElementsByTagName("usuario");
                foreach (XmlNode usuario in usuarios)
                {
                    string nombre = usuario["nombre"].InnerText;
                    string rol = usuario["rol"].InnerText;
                    string xp = usuario["experiencia"].InnerText;
                    if (Convert.ToInt32(xp) < 0)
                    {
                        xp = "0";
                    }
                    treeView1.Nodes.Add($"{nombre} - {rol} - {xp}");
                }
            }
        }
    }
}
