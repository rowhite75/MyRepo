using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinAppCommon
{
    public class Bill
    {
        public DateTime ReceivedDate { get; set; }
        public decimal Amount { get; set; }
        public string Name { get; set; }
    }
}
