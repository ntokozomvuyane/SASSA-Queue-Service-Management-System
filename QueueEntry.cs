using System;
using System.Collections.Generic;
using System.Text;


namespace SASSAQueueManagementSystem
{
    public class QueueEntry
    {
        public string QueueNumber { get; private set; }
        public Booking Booking { get; private set; }
        public DateTime CheckInTime { get; private set; }
        public DateTime? ServiceStartTime { get; private set; }
        public DateTime? CompletionTime { get; private set; }
        public QueueStatus Status { get; private set; }

        public int PeopleAhead { get; set; }
        public int EstimatedWaitingTime { get; set; }

        public bool CheckInBooking(Booking booking)
        {
            if (booking == null || !booking.CheckIn())
            {
                return false;
            }

            Booking = booking;
            QueueNumber = GenerateQueueNumber();
            CheckInTime = DateTime.Now;
            Status = QueueStatus.CheckedIn;

            return true;
        }

        private string GenerateQueueNumber()
        {
            return "Q" + DateTime.Now.ToString("HHmmss");
        }

        public bool MoveToWaiting()
        {
            if (Status != QueueStatus.CheckedIn)
            {
                return false;
            }

            Status = QueueStatus.Waiting;
            Booking.UpdateStatus(BookingStatus.Waiting);

            return true;
        }

        public bool CallNext()
        {
            if (Status != QueueStatus.Waiting)
            {
                return false;
            }

            Status = QueueStatus.Called;
            Booking.UpdateStatus(BookingStatus.Called);

            return true;
        }

        public bool StartService()
        {
            if (Status != QueueStatus.Called)
            {
                return false;
            }

            Status = QueueStatus.BeingServed;
            ServiceStartTime = DateTime.Now;
            Booking.UpdateStatus(BookingStatus.BeingServed);

            return true;
        }

        public bool CompleteService()
        {
            if (Status != QueueStatus.BeingServed)
            {
                return false;
            }

            Status = QueueStatus.Completed;
            CompletionTime = DateTime.Now;
            Booking.UpdateStatus(BookingStatus.Completed);

            return true;
        }

        public bool MarkAsNoShow()
        {
            if (Status != QueueStatus.Waiting &&
                Status != QueueStatus.Called)
            {
                return false;
            }

            Status = QueueStatus.NoShow;
            Booking.UpdateStatus(BookingStatus.NoShow);

            return true;
        }
        public static QueueEntry CreateForCheckIn(
    Booking booking, string queueNumber)
        {
            if (booking == null)
                throw new ArgumentNullException(nameof(booking));
            if (string.IsNullOrWhiteSpace(queueNumber))
                throw new ArgumentException("Queue number is required.",
                    nameof(queueNumber));

            QueueEntry entry = new QueueEntry();
            entry.QueueNumber = queueNumber;
            entry.Booking = booking;
            entry.CheckInTime = DateTime.Now;
            entry.Status = QueueStatus.CheckedIn;
            entry.PeopleAhead = 0;
            entry.EstimatedWaitingTime = 0;
            return entry;
        }

    }

}

