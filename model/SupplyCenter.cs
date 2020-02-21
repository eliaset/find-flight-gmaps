using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class SupplyCenter
    {

        private String Path = "C:\\Users\\osvan\\source\\repos\\price-gasoline-gmaps\\DATA_PreciosCombustibles";
        private List<PetrolStation> petrolStation;

        public SupplyCenter()
        {
            petrolStation = new List<PetrolStation>();

        }



        public void loadData()
        {
            StreamReader sr = new StreamReader(Path);
            string line = sr.ReadLine();
            line = sr.ReadLine();
            ///Inicio
            while (line != null)
            {
                String[] elements = line.Split(',');

                String month = elements[0];
                String nameDepartment = elements[1];
                double latitude = 0;
                double longitude = 0;
                String nameMunicipality = elements[2];
                String tradeName = elements[3];
                string flag = elements[4];
                String addres = elements[5];
                String typeProduct = elements[6];
                double price = Double.Parse(elements[7]);


                petrolStation.Add(new PetrolStation(month, nameDepartment, latitude, longitude, nameMunicipality, tradeName, flag, addres, typeProduct, price));
                line = sr.ReadLine();
            }///Fin




        }



        private void loadDepartamentLocation()
        {
            StreamReader sr = new StreamReader(Path);
            string line = sr.ReadLine();
            line = sr.ReadLine();
            ///Inicio
            while (line != null)
            {
                String[] elements = line.Split(',');

                String month = elements[0];
                String nameDepartment = elements[1];
                double latitude = 0;
                double longitude = 0;
                String nameMunicipality = elements[2];
                String tradeName = elements[3];
                string flag = elements[4];
                String addres = elements[5];
                String typeProduct = elements[6];
                double price = Double.Parse(elements[7]);


                petrolStation.Add(new PetrolStation(month, nameDepartment, latitude, longitude, nameMunicipality, tradeName, flag, addres, typeProduct, price));
                line = sr.ReadLine();
            }///Fin
        }



        public void addPetrolStation(string month, string nameDepartment, string latitude, string longitude, string nameMunicipality, string tradeName, string flag, string addres, string typeProduct, double price) {
           
        }











    }
}
