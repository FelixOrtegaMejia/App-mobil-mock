using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TelerikWinFormsApp1
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hobbie hob = new hobbie();
            hob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comunidad com = new comunidad();
            com.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            agenda agen = new agenda();
            agen.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deporte dep = new deporte();
            dep.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
