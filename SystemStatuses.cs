using System;
using System.Collections.Generic;
using System.Text;

namespace SASSAQueueManagementSystem
{
 
        public enum BookingStatus
        {
            Booked,
            CheckedIn,
            Waiting,
            Called,
            BeingServed,
            Completed,
            Cancelled,
            NoShow
        }

        public enum QueueStatus
        {
            CheckedIn,
            Waiting,
            Called,
            BeingServed,
            Completed,
            NoShow
        }

    }


