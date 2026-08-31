using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sassa_Queue_And_Service_Management_System
{
    internal class QueueItem
    {
        public string QueueNumber {  get; set; }
        public string Reference {  get; set; }
        public string Service { get; set; }
        public string Status {  get; set; }
    }
}
