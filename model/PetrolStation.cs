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
        private String nameMunicipality;
        private String tradeName;
        private string flag;
        private String addres;
        private String typeProduct;
        private double price;

      

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
        }


        public string Year { get => year; set => year = value; }
        public string Month { get => month; set => month = value; }
        public string NameDepartment { get => nameDepartment; set => nameDepartment = value; }
        public string NameMunicipality { get => nameMunicipality; set => nameMunicipality = value; }
        public string TradeName { get => tradeName; set => tradeName = value; }
        public string Flag { get => flag; set => flag = value; }
        public string Addres { get => addres; set => addres = value; }
        public string TypeProduct { get => typeProduct; set => typeProduct = value; }
        public double Price { get => price; set => price = value; }
        
    }
}
