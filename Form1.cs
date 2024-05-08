using SaveTheOcean2.DAO;
using SaveTheOceanFormJoanMendo.Model;

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

       
    }
}
