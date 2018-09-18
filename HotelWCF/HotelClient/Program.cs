using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelClient.HotelReference;

namespace HotelClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelOperationsClient hotelOperationsClient = new HotelOperationsClient("BasicHttpBinding_IHotelOperations");
            while (true)
            {

                Console.WriteLine("Press 1 to Get All Hotels");
                Console.WriteLine("Press 2 to Get Hotel By Id");
                Console.WriteLine("Press 3 to Exit");
                int option;
                int.TryParse(Console.ReadLine(), out option);
                switch (option)
                {
                    case 1:
                        foreach (HotelData hotel in hotelOperationsClient.GetAllHotels())
                        {
                            Console.WriteLine("Hotel Id : " + hotel.HotelId);
                            Console.WriteLine("Hotel Name : " + hotel.HotelName);
                            Console.WriteLine("Hotel Address : " + hotel.HotelAddress);
                            Console.WriteLine("Hotel Star Rating : " + hotel.StarRating + "\n");

                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Hotel Id");
                        int hotelId;
                        int.TryParse(Console.ReadLine(), out hotelId);
                        HotelData data = hotelOperationsClient.GetHotelById(hotelId);
                        Console.WriteLine("Hotel Id : " + data.HotelId);
                        Console.WriteLine("Hotel Name : " + data.HotelName);
                        Console.WriteLine("Hotel Address : " + data.HotelAddress);
                        Console.WriteLine("Hotel Ratings : " + data.StarRating + "\n");

                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Option");
                        break;


                }
            }
        }
    }
}

