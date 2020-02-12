using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    class EntryNotification
    {
        public void NotifyEntryDenied()
        {
            Console.WriteLine("Denied");
        }

        public void NotifyEntryGranted()
        {
            Console.WriteLine("Granted");
        }
    }
}
