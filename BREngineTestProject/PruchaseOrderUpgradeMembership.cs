using System;

namespace BREngineTestProject
{
    public class PruchaseOrderUpgradeMembership : PurchaseOrder, IPuchaseMembershipEvents 
    {       

        public override string OrderProcess(PaymentFor paymentFor)
        {
            string result = string.Empty;
            if (paymentFor != PaymentFor.None)
            {
                result = "Membership is upgraded...\n";
                result += SendEmail();
            }
            else result = base.OrderProcess(paymentFor);
            return result;
        }

        public string SendEmail()
        {
           return "Email sent regarding you Membership Upgrade to your registered email account";
        }
    }
}