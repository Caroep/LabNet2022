using ejcPooConsola;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPoo
{
    public partial class Form1 : Form
    {
        List<TransportePublico> list = new List<TransportePublico>();
        int cantidad0 = 0;
        int cantidad1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            cantidad0++;
            Omnibus omnibus = new Omnibus();
            omnibus.Pasajeros = Convert.ToInt32(txtO.Text);
            list.Add(omnibus);
            MessageBox.Show("Pasajeros agregados");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            cantidad1++;

            Taxi taxi = new Taxi();
            taxi.Pasajeros = Convert.ToInt32(txtT.Text);
            list.Add(taxi);
            MessageBox.Show("Pasajeros agregados");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            listb.Items.Clear();
            for (int i = 0; i < list.Count-1; i++)
            {
                listb.Items.Add(list.ElementAt(i));
                String.Format("Elemento {0}", i) ;
            }
        }
    }
}
