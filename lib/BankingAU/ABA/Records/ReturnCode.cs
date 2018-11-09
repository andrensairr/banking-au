using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.AU.ABA.Records
{
    public enum ReturnCode
    {
        InvalidBsbNumber = 1,
        PaymentStopped,
        AccountClosed,
        CustomerDeceased,
        NoAccountOrIncorrectAccountNumber,
        ReferToCustomer,
        Deleted, // [deleted]; Presumably no longer used.
        InvalidUserIdNumber,
        TechnicallyInvalid
    }
}
