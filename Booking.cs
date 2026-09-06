using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sassa_Queue_And_Service_Management_System
{
    class Booking
    {
        private string bookingID;
        private string service;
        private string centre;
        private string date;
        private string time;
        private string status;

        public void SetBookingID(string _bookingID)
        {
            this.bookingID = _bookingID;
        }
        public void SetService(string _service)
        {
            this.service = _service;
        }
        public void SetCentre(string _centre)
        {
            this.centre = _centre;
        }
        public void SetDate(string _date)
        {
            this.date = _date;
        }
        public void SetTime(string _time)
        {
            this.time = _time;
        }
        public void SetStatus(string _status)
        {
            this.status = _status;
        }


        public string GetBookingID()
        {
            return bookingID;
        }
        public string GetService()
        {
            return service;
        }
        public string GetCentre()
        {
            return centre;
        }
        public string GetDate()
        {
            return date;
        }
        public string GetTime()
        {
            return time;
        }
        public string GetStatus()
        {
            return status;
        }
    }
}
