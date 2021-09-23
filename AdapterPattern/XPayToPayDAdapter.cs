using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class XPayToPayDAdapter : IPayD
    {

        private string custCardNo;
        private string cardOwnerName;
        private string cardExpMonthDate;
        private int cVVNo;
        private double totalAmount;

        private readonly XPay xpay;

        public XPayToPayDAdapter(XPay xpay)
        {
            this.xpay = xpay;
            setProp();
        }
        public string getCardExpMonthDate()
        {
            return custCardNo;
        }

        public string getCardOwnerName()
        {
            return cardOwnerName;
        }

        public string getCustCardNo()
        {
            return custCardNo;
        }

        public int getCVVNo()
        {
            return cVVNo;
        }

        public double getTotalAmount()
        {
            return totalAmount;
        }

        public void setCardExpMonthDate(string cardExpMonthDate)
        {
            this.cardExpMonthDate = cardExpMonthDate; 
        }

        public void setCardOwnerName(string cardOwnerName)
        {
            this.cardOwnerName = cardOwnerName;
        }

        public void setCustCardNo(string custCardNo)
        {
            this.custCardNo = custCardNo;
        }

        public void setCVVNo(int cVVNo)
        {
            this.cVVNo = cVVNo;
        }

        public void setTotalAmount(double totalAmount)
        {
            this.totalAmount = totalAmount;
        }

        private void setProp()
        {
            setCardOwnerName(this.xpay.GetCustomerName());
            setCustCardNo(this.xpay.GetCreditCardNumber());
            setCardExpMonthDate(this.xpay.GetCardExpMonth() + "/" + this.xpay.GetCardExpYear());
            setCVVNo(Convert.ToInt32(this.xpay.GetCardCVVNumber()));
            setTotalAmount(this.xpay.GetAmount());

        }
    }
}
