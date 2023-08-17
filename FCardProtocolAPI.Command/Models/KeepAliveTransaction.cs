using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCardProtocolAPI.Command.Models
{
    public class KeepAliveTransaction
    {
        public string Sn { get; set; }

        public string KeepAliveTime { get; set; }
    }
}
