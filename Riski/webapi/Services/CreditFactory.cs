using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Credit;
using webapi.Models;

namespace webapi.Services
{
    public interface ICreditFactory
    {
        ICreditCompeny GetCreditCompany(TransactionInfo transaction) ;
    }
    public class CreditFactory : ICreditFactory
    {
        private Visa _visa;
        private MasterCard _masterCard;

        // TODO: constants service.
        private const string VISA_NAME = "visa";
        private const string MASTER_CARD_NAME = "masterCard";

        public CreditFactory(Visa visa, MasterCard masterCard)
        {
            _visa = visa;
            _masterCard = masterCard;
        }

        public ICreditCompeny GetCreditCompany(TransactionInfo transaction)
        {
            switch (transaction.CreditCardCompeny)
            {
                case VISA_NAME:
                    return _visa;
                case MASTER_CARD_NAME:
                    return _masterCard;
                default:
                    return null;
            }
        }
    }
}
