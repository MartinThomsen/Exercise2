using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();
            UserValidation validation = new UserValidation();
            EntryNotification notification = new EntryNotification();
            DoorController controller = new DoorController(validation, door, notification);

            controller.RequestEntry(1834);

            Console.ReadKey();
        }
    }
}
