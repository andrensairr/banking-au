using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Banking.AU.ABA.Records
{
    public enum ReturnCode
    {
        [Description("Invalid BSB (1)")]
        InvalidBsbNumber = 1,

        [Description("Payment Stopped (2)")]
        PaymentStopped,

        [Description("Account Closed (3)")]
        AccountClosed,

        [Description("Customer Deceased (4)")]
        CustomerDeceased,

        [Description("Incorrect Account Number (5)")]
        NoAccountOrIncorrectAccountNumber,

        [Description("Refer to Customer (6)")]
        ReferToCustomer,

        [Description("Deleted (7)")]
        Deleted, // [deleted]; Presumably no longer used.

        [Description("Invalid User Id (8)")]
        InvalidUserIdNumber,

        [Description("Technically Invalid (9)")]
        TechnicallyInvalid
    }
}
