using System;
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
        /// <summary>
        /// Relacion con el modelo.
        /// </summary>
        private SupplyCenter supplyCenter;
        private GMarkerGoogle marker;
        private GMapOverlay markerOverlay;
 



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
            //Elementos de inicio Gmap
            gMapC.DragButton = MouseButtons.Left;
            gMapC.CanDragMap = true;
            gMapC.MapProvider = GMap.NET.MapProviders.OpenCycleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapC.Position = new GMap.NET.PointLatLng(4.570868, -74.2973328);
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapC.MinZoom = 2;
            gMapC.MaxZoom = 18;
            gMapC.Zoom = 5;
            //Fin


            supplyCenter.loadData();



            AddMarker(new PointLatLng(4.570868, -74.2973328), GMarkerGoogleType.green);
            AddMarker(new PointLatLng(10.9685402, -74.7813187), GMarkerGoogleType.red);

             

           
             






        }



        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType gMarkerGoogleType)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd,gMarkerGoogleType);
            markers.Markers.Add(marker);
            gMapC.Overlays.Add(markers);

        }

       




        private void Geocoding(string nameDepartament, string municipality)
        {
         //geocodificación
            GeoCoderStatusCode statusCode;
            var dirrecion =nameDepartament+" "+municipality;
            var pointLatng = OpenCycleMapProvider.Instance.GetPoint(dirrecion.Trim(), out statusCode);
            
            var lat = pointLatng?.Lat.ToString();
            var lng = pointLatng?.Lng.ToString();
            AddMarker(new PointLatLng(Double.Parse(lat), Double.Parse(lng)), GMarkerGoogleType.green);
        }
    


    }
}
