using System;
using System.Collections.Generic;
using System.Text;

    namespace SASSAQueueManagementSystem
    {
        public static class SystemData
        {
            public static List<Service> Services { get; }
                = new List<Service>();

            public static List<ServiceCentre> ServiceCentres { get; }
                = new List<ServiceCentre>();

            public static List<TimeSlot> TimeSlots { get; }
                = new List<TimeSlot>();

            public static List<Booking> Bookings { get; }
                = new List<Booking>();
             public static List<QueueEntry> QueueEntries { get; }
               = new List<QueueEntry>();
        
            static SystemData()
            {
                Services.Add(new Service
                {
                    ServiceID = "S001",
                    ServiceName = "New Grant Application",
                    Description = "Apply for a new grant"
                });

                Services.Add(new Service
                {
                    ServiceID = "S002",
                    ServiceName = "Payment Enquiry",
                    Description = "Enquire about grant payments"
                });

                Services.Add(new Service
                {
                    ServiceID = "S003",
                    ServiceName = "Document Submission",
                    Description = "Submit required documents"
                });

                ServiceCentre johannesburgCentre =
                    new ServiceCentre
                    {
                        CentreID = "C001",
                        CentreName = "Johannesburg SASSA Centre",
                        Address = "Johannesburg"
                    };

                ServiceCentre sowetoCentre =
                    new ServiceCentre
                    {
                        CentreID = "C002",
                        CentreName = "Soweto SASSA Centre",
                        Address = "Soweto"
                    };

                ServiceCentres.Add(johannesburgCentre);
                ServiceCentres.Add(sowetoCentre);

                AddTimeSlot(
                    johannesburgCentre,
                    "T001",
                    DateTime.Today.AddDays(1),
                    new TimeSpan(9, 0, 0),
                    10);

                AddTimeSlot(
                    johannesburgCentre,
                    "T002",
                    DateTime.Today.AddDays(1),
                    new TimeSpan(11, 0, 0),
                    10);

                AddTimeSlot(
                    sowetoCentre,
                    "T003",
                    DateTime.Today.AddDays(2),
                    new TimeSpan(10, 0, 0),
                    8);
            }

            private static void AddTimeSlot(
                ServiceCentre centre,
                string slotID,
                DateTime date,
                TimeSpan time,
                int capacity)
            {
                TimeSlot slot = new TimeSlot
                {
                    SlotID = slotID,
                    CentreID = centre.CentreID,
                    Date = date,
                    Time = time,
                    Capacity = capacity
                };

                TimeSlots.Add(slot);
                centre.AddTimeSlot(slot);
            }
        }
    }










