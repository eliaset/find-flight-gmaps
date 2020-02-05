using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gmap
{

    class Main
    {
        private string co_City;
        private string co_Longitud;
        private string co_Latitud;
        private string es_City;
        private string es_Longitud;
        private string es_Latitud;
        private string eu_City;
        private string eu_Longitud;
        private string eu_Latitud;

        public Main(string co_City, string co_Longitud, string co_Latitud, string es_City, string es_Longitud, string es_Latitud, string eu_City, string eu_Longitud, string eu_Latitud)
        {
            this.Co_City = co_City;
            this.Co_Longitud = co_Longitud;
            this.Co_Latitud = co_Latitud;
            this.Es_City = es_City;
            this.Es_Longitud = es_Longitud;
            this.Es_Latitud = es_Latitud;
            this.Eu_City = eu_City;
            this.Eu_Longitud = eu_Longitud;
            this.Eu_Latitud = eu_Latitud;
        }

        public string Co_City { get => co_City; set => co_City = value; }
        public string Co_Longitud { get => co_Longitud; set => co_Longitud = value; }
        public string Co_Latitud { get => co_Latitud; set => co_Latitud = value; }
        public string Es_City { get => es_City; set => es_City = value; }
        public string Es_Longitud { get => es_Longitud; set => es_Longitud = value; }
        public string Es_Latitud { get => es_Latitud; set => es_Latitud = value; }
        public string Eu_City { get => eu_City; set => eu_City = value; }
        public string Eu_Longitud { get => eu_Longitud; set => eu_Longitud = value; }
        public string Eu_Latitud { get => eu_Latitud; set => eu_Latitud = value; }
    }
}
