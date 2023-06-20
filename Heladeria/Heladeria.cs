using Heladeria.Helado1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria
{
    public partial class Heladeria : Form
    {
        public Heladeria()
        {
            InitializeComponent();
            Helado2 hd = new Helado2();
            addUserControl(hd);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
            panelHelados.Controls.Clear();
            panelHelados.Controls .Add(userControl);
            userControl.BringToFront();

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Helado2 hd = new Helado2();
             addUserControl(hd);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Helado3 hd = new Helado3();
            addUserControl(hd);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Helado4 hd= new Helado4();
            addUserControl(hd);
        }
    }
}
