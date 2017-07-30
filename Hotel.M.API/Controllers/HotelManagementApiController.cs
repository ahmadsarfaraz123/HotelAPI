using Hotel.M.API.Model;
using Hotel.M.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hotel.M.API.Controllers
{
    public class HotelManagementApiController : ApiController
    {
        public bool Booking(Room order)
        {

            return true;

        }

        public bool AdvanceBooking(Room order)
        {

            return true;

        }
        public bool BookingCancel(Room order)
        {

            return true;

        }

        public bool RoomAvailability()
        {

            return true;

        }

        public bool RoomClassifications()
        {

            return true;

        }

        public int TotalRoomOrders()
        {

            return int.MaxValue;

        }
        
        public bool FoodOrders()
        {

            return true;

        }

        public bool CanceledFoodOrders()
        {

            return true;

        }

        public int TotalFoodOrders()
        {

            return int.MaxValue;

        
        }
        public bool Coustumers()
        {

            return true;

        }

        public bool CoustumersCheckOut()
        {

            return true;

        }

        public bool Payment()
        {

            return true;

        }

    }
}
