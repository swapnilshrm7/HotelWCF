using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HotelWCF
{
    [ServiceContract]
    interface IHotelOperations
    {
        [OperationContract]
        List<HotelData> GetAllHotels();
        [OperationContract]
        HotelData GetHotelById(int hotelId);

    }
}
