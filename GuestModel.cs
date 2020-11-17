using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary.Models
{
    public class GuestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MessageToHost { get; set; }

        public string GuestInfo
        {
            get
            {
                return $"{ FirstName } {LastName}: {MessageToHost}";
            }
        }
    }
}
