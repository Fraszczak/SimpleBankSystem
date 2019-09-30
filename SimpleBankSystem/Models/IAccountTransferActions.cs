using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Models
{
    interface IAccountTransferActions
    {
        decimal TransferCashFromLocalAccountToLocalAccount(ref decimal from, ref decimal to);
        
    }
}
