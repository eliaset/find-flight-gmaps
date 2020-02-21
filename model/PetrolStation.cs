using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    class PetrolStation
    {

        // public enum TYPEPRODUCT { BIODISEL_EXTRA, GASOLINA_XTRA_OXIGENADA, GASOLINA_CORRIENTE_OXIGENADA, BIOACEM_AL_9, ACEM_DIESEL_ECOLOGICO, ACPM_DIESEL }


        private String year;
        private String month;
        private String nameDepartment;
        private double latitude;
        private double longitude;
        private String nameMunicipality;
        private String tradeName;
        private string flag;
        private String addres;
        private String typeProduct;
        private double price;

<<<<<<< HEAD
      

        public PetrolStation(String year, String month, String nameDepartment, String nameMunicipaly, String tradeName, String flag, String adress, String
            product, double price) 
        {
            this.year = year;
            this.month = month;
            this.nameDepartment = nameDepartment;
            this.nameMunicipality = nameMunicipaly;
            this.tradeName = tradeName;
            this.flag = flag;
            this.addres = adress;
            this.typeProduct = product;
            this.price = price;
=======
        public PetrolStation()
        {
>>>>>>> master
        }

        public PetrolStation(string month, string nameDepartment, double latitude, double longitude, string nameMunicipality, string tradeName, string flag, string addres, string typeProduct, double price)
        {
            this.month = month;
            this.nameDepartment = nameDepartment;
            this.latitude = latitude;
            this.longitude = longitude;
            this.nameMunicipality = nameMunicipality;
            this.tradeName = tradeName;
            this.flag = flag;
            this.addres = addres;
            this.typeProduct = typeProduct;
            this.price = price;
        }

<<<<<<< HEAD
        public string Year { get => year; set => year = value; }
        public string Month { get => month; set => month = value; }
        public string NameDepartment { get => nameDepartment; set => nameDepartment = value; }
=======
        public string Month { get => month; set => month = value; }
        public string NameDepartment { get => nameDepartment; set => nameDepartment = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
>>>>>>> master
        public string NameMunicipality { get => nameMunicipality; set => nameMunicipality = value; }
        public string TradeName { get => tradeName; set => tradeName = value; }
        public string Flag { get => flag; set => flag = value; }
        public string Addres { get => addres; set => addres = value; }
        public string TypeProduct { get => typeProduct; set => typeProduct = value; }
        public double Price { get => price; set => price = value; }
<<<<<<< HEAD
        
=======
>>>>>>> master
    }
}
