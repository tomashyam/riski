using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Credit
{
    public class MasterCard : ICreditCompeny
    {
        public Task<APIResponse> ChargeCredit(TransactionInfo transaction)
        {
            throw new NotImplementedException();
        }
    }
}
