using System;
using System.Collections.Generic;
using System.Text;

namespace SASSAQueueManagementSystem
{
    public class TimeSlot
    
        {
            private int capacity;

            public string SlotID { get; set; }
            public string CentreID { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan Time { get; set; }

            public int Capacity
            {
                get
                {
                    return capacity;
                }

                set
                {
                    if (value > 0)
                    {
                        capacity = value;
                    }
                }
            }

            public int NumberOfBookings { get; private set; }

            public int AvailablePositions
            {
                get
                {
                    return Capacity - NumberOfBookings;
                }
            }

            public DateTime AppointmentDateTime
            {
                get
                {
                    return Date.Date.Add(Time);
                }
            }

            public bool CheckAvailability()
            {
                return AppointmentDateTime > DateTime.Now
                       && NumberOfBookings < Capacity;
            }

            public bool ReservePosition()
            {
                if (!CheckAvailability())
                {
                    return false;
                }

                NumberOfBookings++;
                return true;
            }

            public void ReleasePosition()
            {
                if (NumberOfBookings > 0)
                {
                    NumberOfBookings--;
                }
            }

            public override string ToString()
            {
                return AppointmentDateTime.ToString(
                    "dd MMMM yyyy HH:mm");
            }
        }
    }


