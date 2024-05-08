using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;

namespace SaveTheOceanFormsJoanMendo
{
    public partial class Form3 : Form
    {
        bool error = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void LeaveButton_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Continue_click(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                NameBox.Text = "Has de escribir tu nombre";
                NameBox.ForeColor = Color.Red;
                error = true;
            }
            if (RoleBox.Text != "Técnico" && RoleBox.Text != "Veterinario")
            {
                error = true;
                RoleBox.Text = "Has de elegir una de las dos opciones";
                RoleBox.ForeColor = Color.Red;
            }
            if (error == false)
            {
                Form1 form1 = new Form1();
                form1.nombreJugador = NameBox.Text;
                form1.rolJugador = RoleBox.Text;
                form1.Show();
                this.Hide();
            }
        }

        private void ResetText_click(object sender, EventArgs e)
        {
            error = false;
            if (NameBox.ForeColor == Color.Red)
            {
                NameBox.Text = "";
                NameBox.ForeColor = Color.Black;
            }
            if (RoleBox.ForeColor == Color.Red)
            {
                RoleBox.Text = "";
                RoleBox.ForeColor = Color.Black;
            }
           
        }
    }
}
