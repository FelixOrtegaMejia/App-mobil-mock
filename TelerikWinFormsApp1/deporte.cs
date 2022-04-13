using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace TelerikWinFormsApp1
{
    public partial class deporte : Telerik.WinControls.UI.RadForm
    {
        public deporte()
        {
            InitializeComponent();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            agenda agen = new agenda();
            agen.Show();
            this.Hide();
        }
    }
}
