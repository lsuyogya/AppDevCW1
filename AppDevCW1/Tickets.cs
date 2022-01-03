using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevCW1
{
    public class Tickets
    {
        public int ticketNo { get; set; }
        public string type { get; set; }
        public int count { get; set; }
        public DateTime sysInDate { get; set; }
        public DateTime sysOutDate { get; set; }
        public string day { get; set; }
        public Boolean checkedOut { get; set; }
        public double totalPrice { get; set; }
    }
}
