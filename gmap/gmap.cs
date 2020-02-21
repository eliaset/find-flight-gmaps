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

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace gmap
{
    public partial class gmap : Form
    {

        private SupplyCenter supplyCenter;
        private GMarkerGoogle marker;
        private GMapOverlay markerOverlay;
        private GMapRoute route;


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

        private void gmap_Load(object sender, EventArgs e)
        {
            /**
            gMapC.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            **/
            gMapC.MapProvider = GMapProviders.GoogleMap;
            gMapC.Position = new GMap.NET.PointLatLng(4.570868, -74.2973328);
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapC.MinZoom = 2;
            gMapC.MaxZoom = 18;
            gMapC.Zoom = 5;



           


            //geocodificación
            GeoCoderStatusCode statusCode;
            string dirrecion = "Cali";
            var pointLatng = GoogleMapProvider.Instance.GetPoint(dirrecion.Trim(), out statusCode);
          
            if (statusCode == GeoCoderStatusCode.G_GEO_SUCCESS)
            {
                String lat = pointLatng?.Lat.ToString();
                String lng = pointLatng?.Lng.ToString();
                markerOverlay = new GMapOverlay("Marcador");
                marker = new GMarkerGoogle(new PointLatLng(Double.Parse(lat), Double.Parse(lng)), GMarkerGoogleType.green);
                markerOverlay.Markers.Add(marker);

                gMapC.Overlays.Add(markerOverlay);
                MessageBox.Show("entre");
            }
           
    

           


        }
    }
}
