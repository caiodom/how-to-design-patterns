using ChainOfResponsability.Handler;
using ChainOfResponsability.Handler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class ApprovalChain
    {
        private IHandler _firstHandler;

        public ApprovalChain(Dictionary<int, IHandler> maplvlHandler)
        {
            ConfigureChain(maplvlHandler);
        }

        private void ConfigureChain(Dictionary<int,IHandler> maplvlHandler)
        {
            if(maplvlHandler is null)
                throw new ArgumentNullException(nameof(maplvlHandler), "The handler mapping cannot be null. Please provide a valid mapping for the approval levels.");

            if (maplvlHandler.Count == 1)
            {
                _firstHandler = maplvlHandler[0];
                return;
            }

            var orderedLvlHandler = maplvlHandler.OrderBy(x => x.Key).ToList();
            for (int i = 0; i < orderedLvlHandler.Count - 1 ; i++)
                orderedLvlHandler[i].Value.SetNext(orderedLvlHandler[i + 1].Value);

            _firstHandler = orderedLvlHandler[0].Value;
        }


        public void StartChain(decimal refundAmount)
        {
            if (_firstHandler == null)
                throw new InvalidOperationException("Approval chain is not configured.");

            _firstHandler.HandleRequest(new RefundRequest(refundAmount));
        }

    }
}
