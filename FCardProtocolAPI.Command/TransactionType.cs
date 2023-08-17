using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCardProtocolAPI.Command
{
    public enum TransactionType
    {
        DefaultTransaction,
        CardTransaction,
        KeepAliveTransaction,
        FaceTransaction
    }
}
