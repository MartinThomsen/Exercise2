using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
   public class DoorController
   {
       private readonly UserValidation _validator;
       private readonly Door _door;
       private readonly EntryNotification _notifier;
       private bool _validated;
        public DoorController(UserValidation validator, Door door, EntryNotification notifier)
        {
            _validator = validator;
            _door = door;
            _notifier = notifier;
        }
        public void RequestEntry(int id)
        {
           _validated = _validator.ValidateEntryRequest(id);

           if (_validated)
           {
                _door.Open();
                _notifier.NotifyEntryGranted();
           }
        }
    }
}
