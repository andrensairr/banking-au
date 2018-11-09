using Banking.AU.Common.Converters;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.AU.ABA.Records
{
    public class DeDetailRecord : DetailRecord
    {
        /// <summary>
        /// Can be used to indicate that a particular record represents a change to a prior record in the batch, or to existing details held on file for the payee. It’s also clear that not every financial institution pays attention to this field. Unless you are dealing with thousands of payments at a time, you should leave this field blank to make it clear that each record represents a separate payment.
        /// Default None.
        /// </summary>
        [FieldOrder(3)]
        [FieldFixedLength(1)]
        [FieldConverter(typeof(EnumConverter), typeof(Indicator))]
        public Indicator Indicator;

        /// <summary>
        /// Amount of withholding tax in dollars. Must be greater than zero.
        /// </summary>
        [FieldOrder(11)]
        [FieldFixedLength(8)]
        [FieldAlign(AlignMode.Right, '0')]
        [FieldConverter(typeof(CurrencyConverter))]
        public decimal WithholdingTaxAmount;

        public DeDetailRecord()
        {
            RecordType = 1;
            Indicator = Indicator.None;
            TransactionCode = TransactionCode.CreditItem;
        }
    }
}
