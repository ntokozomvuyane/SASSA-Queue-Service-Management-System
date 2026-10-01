using System;
using System.Collections.Generic;
using System.Text;

namespace SASSAQueueManagementSystem
{
    public class ServiceCentre
    {
public string CentreID { get; set; }
        public string CentreName { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; private set; } = true;
 
        public List<TimeSlot> TimeSlots { get; private set; }
            = new List<TimeSlot>();
 
        public void AddTimeSlot(TimeSlot newTimeSlot)
        {
            if (newTimeSlot != null)
            {
                TimeSlots.Add(newTimeSlot);
            }
        }
 
        public void ActivateCentre()
        {
            IsActive = true;
        }
 
        public void DeactivateCentre()
        {
            IsActive = false;
        }
 
        public override string ToString()
        {
            return CentreName;
        }
    }

    }

