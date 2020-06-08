using System;

namespace BREngineTestProject
{
    public class PurchaseOrderPhysicalProduct : PurchaseOrder, IPuchaseCommissionEvent
    {               

        public override string OrderProcess(PaymentFor paymentFor)
        {
            string result = string.Empty;
            if (paymentFor != PaymentFor.None)
            {
                result = "Generate a packing slip for shipping \n";
                result += GenerateCommissionPayment();
            }
            else result = base.OrderProcess(paymentFor);
            return result;
        }

        public string GenerateCommissionPayment()
        {
            return "Commission generated for your Product Purchase";
        }
    }
}