using Gather.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentGateway.Interface
{
    public interface IPaymentBL
    {
        public ServiceResult paymentVNPay();

    }
}
