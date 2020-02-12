using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
   public class UserValidation
    {
        public bool ValidateEntryRequest(int id)
        {
            if (id == 1234)
            {
                return true;
            }
            else return false;
        }
    }
}
