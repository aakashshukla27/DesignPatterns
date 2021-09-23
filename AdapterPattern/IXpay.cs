using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    interface IXpay
    {
        public string GetCreditCardNumber();
        public string GetCustomerName();
        public string GetCardExpMonth();
        public string GetCardExpYear();
        public short GetCardCVVNumber();
        public double GetAmount();


        public void SetCreditCardNumber(string creditCardNumber);
        public void SetCustomerName(string customerName);
        public void SetCardExpiryMonth(string cardExpMonth);
        public void SetCardExpiryYear(string cardExpYear);
        public void SetCardCVVNumber(short cvvNumber);
        public void SetAmount(double amount);



    }
}
