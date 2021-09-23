using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class XPay : IXpay
    {

        private string creditCardNumber;
        private string customerName;
        private string cardExpiryYear;
        private string cardExpiryMonth;
        private short cardCVVNumber;
        private double amount;




        public double GetAmount()
        {
            return amount;
        }

        public short GetCardCVVNumber()
        {
            return cardCVVNumber;
        }

        public string GetCardExpMonth()
        {
            return cardExpiryMonth;
        }

        public string GetCardExpYear()
        {
            return cardExpiryYear;
        }

        public string GetCreditCardNumber()
        {
            return creditCardNumber;
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public void SetAmount(double amount)
        {
            this.amount = amount;
        }

        public void SetCardCVVNumber(short cvvNumber)
        {
            this.cardCVVNumber = cvvNumber;
        }

        public void SetCardExpiryMonth(string cardExpMonth)
        {
            this.cardExpiryMonth = cardExpMonth;
        }

        public void SetCardExpiryYear(string cardExpYear)
        {
            this.cardExpiryYear = cardExpYear;
        }

        public void SetCreditCardNumber(string creditCardNumber)
        {
            this.creditCardNumber = creditCardNumber;
        }

        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }
    }
}
