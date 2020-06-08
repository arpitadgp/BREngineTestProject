using System;

namespace BREngineTestProject
{
    public interface IChain
    {
        IChain SetNext(IChain chain);

        public string OrderProcess(PaymentFor paymentFor);
        
    }
}