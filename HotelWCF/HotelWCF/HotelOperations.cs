using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWCF
{

    class HotelOperations : IHotelOperations
    {
        public List<HotelData> GetAllHotels()
        {
            List<HotelData> hotelList = new List<HotelData>();
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/" + "HotelList.json";
            using (StreamReader streamReader = new StreamReader(path))
            {
                var readData = streamReader.ReadToEnd();
                hotelList = JsonConvert.DeserializeObject<List<HotelData>>(readData);
            }
            return hotelList;
        }

        public HotelData GetHotelById(int hotelId)
        {
            var hotel = GetAllHotels().Find(x => x.HotelId == hotelId);
            return hotel;
        }
    }
}
