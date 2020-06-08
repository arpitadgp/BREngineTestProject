using System;

namespace BREngineTestProject
{
    public class PurchaseOrderVideo : PurchaseOrder 
    {
        public override string OrderProcess(PaymentFor paymentFor)
        {
            string result = string.Empty;
            if (paymentFor != PaymentFor.None)
            {
                result = "Generated purchase slip for Learning to Ski video \n";
                result += "Added a free video on First Aid as per 1997 court order";
            }
            else result = base.OrderProcess(paymentFor);
            return result;
        }
    }
}