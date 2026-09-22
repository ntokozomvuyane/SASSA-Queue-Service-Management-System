using System;
using System.Collections.Generic;
using System.Text;

namespace SASSAQueueManagementSystem
{
    public class Booking
    {
        public string ReferenceNumber { get; private set; }
        public Beneficiary Beneficiary { get; set; }
        public Service Service { get; set; }
        public ServiceCentre ServiceCentre { get; set; }
        public TimeSlot TimeSlot { get; private set; }
        public DateTime DateCreated { get; private set; }
        public BookingStatus Status { get; private set; }
 
        public bool CreateBooking(TimeSlot selectedTimeSlot)
        {
            if (Beneficiary == null ||
                Service == null ||
                ServiceCentre == null ||
                selectedTimeSlot == null)
            {
                return false;
            }
 
            if (!Service.IsActive ||
                !ServiceCentre.IsActive ||
                !selectedTimeSlot.ReservePosition())
            {
                return false;
            }
 
            TimeSlot = selectedTimeSlot;
            ReferenceNumber = GenerateReferenceNumber();
            DateCreated = DateTime.Now;
            Status = BookingStatus.Booked;
 
            return true;
        }
 
        private string GenerateReferenceNumber()
        {
            return "SASSA-" +
                   DateTime.Now.ToString("yyyyMMddHHmmss") +
                   "-" +
                   Guid.NewGuid().ToString()
                       .Substring(0, 4)
                       .ToUpper();
        }
 
        public bool CancelBooking()
        {
            if (Status == BookingStatus.Completed ||
                Status == BookingStatus.Cancelled)
            {
                return false;
            }
 
            TimeSlot?.ReleasePosition();
            Status = BookingStatus.Cancelled;
 
            return true;
        }
 
        public bool RescheduleBooking(TimeSlot newTimeSlot)
        {
            if (newTimeSlot == null ||
                Status == BookingStatus.Completed ||
                Status == BookingStatus.Cancelled)
            {
                return false;
            }
 
            // Reserve the new position before releasing the old one.
            if (!newTimeSlot.ReservePosition())
            {
                return false;
            }
 
            TimeSlot?.ReleasePosition();
            TimeSlot = newTimeSlot;
            Status = BookingStatus.Booked;
 
            return true;
        }
 
        public bool CheckIn()
        {
            if (Status != BookingStatus.Booked)
            {
                return false;
            }
 
            Status = BookingStatus.CheckedIn;
            return true;
        }
 
        public void UpdateStatus(BookingStatus newStatus)
        {
            Status = newStatus;
        }
    }

    }

