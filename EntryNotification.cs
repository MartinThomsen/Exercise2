using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
   public class EntryNotification
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
