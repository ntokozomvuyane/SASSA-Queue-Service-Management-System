using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sassa_Queue_And_Service_Management_System
{
    public class Booking
    {
        private string idCode;
        private string serviceCentre;
        private string serviceType;
        private string Date;
        private string Time;
        private string Status;

        public void SetAppointment(string _idCode, string service_centre, string service_type, string _date, string _time, string _status)
        {
            this.idCode = _idCode;
            this.serviceCentre = service_centre;
            this.serviceType = service_type;
            this.Date = _date;
            this.Time = _time;
            this.Status = _status;
        }

        public string GetAppointmentInfo()
        {
            return idCode + "," + serviceCentre + "," + serviceType + "," + Date + "," + Time + "," + Status;
           
        }


































    }

}
