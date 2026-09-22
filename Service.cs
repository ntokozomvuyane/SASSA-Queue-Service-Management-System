using System;
using System.Collections.Generic;
using System.Text;

namespace SASSAQueueManagementSystem
{
    public class Service
    {
        public string ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; private set; } = true;

        public void ActivateService()
        {
            IsActive = true;
        }

        public void DeactivateService()
        {
            IsActive = false;
        }

        public override string ToString()
        {
            return ServiceName;
        }
    }

}

