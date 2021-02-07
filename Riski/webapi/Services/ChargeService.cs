using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Services
{
    public class ChargeService
    {
        private ICreditFactory _creditCompenyFactory;
        public ChargeService(ICreditFactory creditCompanyFactory)
        {
            _creditCompenyFactory = creditCompanyFactory;
        }

        public async Task Charge(TransactionInfo transaction)
        {
            var creditCompany = _creditCompenyFactory.GetCreditCompany(transaction);
            var response  = await creditCompany.ChargeCredit(transaction);


         //   return null;
        }
    }
}
