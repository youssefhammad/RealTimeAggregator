using RealTimeAggregator.Data.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Services
{
    public class SalesService : ISalesService
    {
        private readonly SalesUnitOfWork _unitOfWork;

        public SalesService(SalesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
