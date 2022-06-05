using Draft.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.WPF.States.Accounts
{
    public interface IAccountStore
    {
        Account CurrentAccount { get; set; }
        event Action StateChanged;
    }
}
