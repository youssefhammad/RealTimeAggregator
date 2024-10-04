using RealTimeAggregator.Data.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly PurchaseUnitOfWork _unitOfWork;

        public PurchaseService(PurchaseUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
