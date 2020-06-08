using System;

namespace BREngineTestProject
{
    public class PurchaseOrderBook : PurchaseOrder, IPuchaseCommissionEvent
    {
        public override string  OrderProcess(PaymentFor paymentFor)
        {
            string result = string.Empty;
            if (paymentFor != PaymentFor.None) 
            {
                result = "Create a duplicate slip for royalty department \n";
                result += GenerateCommissionPayment();
            }
            else result = base.OrderProcess(paymentFor);
            return result;
        }

        public string GenerateCommissionPayment()
        {
           return "Commission generated for your Book Purchase";
        }

    }
}