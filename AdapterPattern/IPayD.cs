using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    interface IPayD
    {
        public string getCustCardNo();
        public string getCardOwnerName();
        public string getCardExpMonthDate();
        public int getCVVNo();
        public double getTotalAmount();
        public void setCustCardNo(string custCardNo);
        public void setCardOwnerName(string cardOwnerName);
        public void setCardExpMonthDate(string cardExpMonthDate);
        public void setCVVNo(int cVVNo);
        public void setTotalAmount(double totalAmount);
    }
}
