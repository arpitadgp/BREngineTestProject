using System;

namespace BREngineTestProject
{
    // Enum type to identify, which specific purchase, the payment is made for 
    public enum PaymentFor 
    {
        None,
        PhysicalProduct,
        Book,
        Membership,
        UpgradeMembership,
        Video        
    };


    // Base class
    public abstract class PurchaseOrder : IChain 
    {
        private IChain nexChainOrder;

        public IChain SetNext(IChain chain)
        {
            this.nexChainOrder = chain;
            return chain;
        }        

        public virtual string OrderProcess(PaymentFor paymentFor) 
        {
            if (this.nexChainOrder != null)
            {
                return this.nexChainOrder.OrderProcess(paymentFor);
            }
            else return "None";            
        }
    }
}