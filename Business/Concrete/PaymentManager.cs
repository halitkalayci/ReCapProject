using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        public IResult MakePayment(CreditCart cart)
        {
            int random = new Random().Next(0, 2);
            if (random == 0)
                return new ErrorResult("Ödeme başarısız.");
            return new SuccessResult("Ödeme başarılı");
        }
    }
}
