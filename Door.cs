using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
   public class Door : DoorStatusSubject
   {
       public bool open;   
        public void OpenDoor()
        {
            open = true;
            Notify();
        }

        public void CloseDoor()
        {
            open = false;
            Notify();
        }
        
    }
}
