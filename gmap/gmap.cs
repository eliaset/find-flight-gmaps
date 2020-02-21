using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;

namespace gmap
{
    public partial class gmap : Form
    {

        private SupplyCenter supplyCenter;

        public gmap()
        {
            InitializeComponent();

            cbFilter.Items.Add("Mes");
            cbFilter.Items.Add("Municipio");
            cbFilter.Items.Add("Bandera");
            cbFilter.Items.Add("Producto");
            cbFilter.Items.Add("Precio");

            supplyCenter = new SupplyCenter();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
      

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void btSearchStation_Click(object sender, EventArgs e)
        {

        }

        private void btClearStation_Click(object sender, EventArgs e)
        {

        }

        private void btClearFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
