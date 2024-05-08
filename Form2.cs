using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheOceanFormsJoanMendo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayButton_click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

            
            
        }
    }
}
