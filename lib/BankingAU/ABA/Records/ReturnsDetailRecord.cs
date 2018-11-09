using Banking.AU.Common.Converters;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.AU.ABA.Records
{
    public class ReturnsDetailRecord : DetailRecord
    {
        /// <summary>
        /// Valid industry return code, indicating the resons for the return of funds.
        /// Default InvalidBsbNumber.
        /// </summary>
        [FieldOrder(3)]
        [FieldFixedLength(1)]
        public ReturnCode ReturnCode;

        /// <summary>
        /// The day of the month of the originating transaction. Positions 75 – 76 of the original type 0 record.
        /// </summary>
        [FieldOrder(11)]
        [FieldFixedLength(2)]
        public int OriginalDayOfProcessing;

        /// <summary>
        /// Can be used to indicate that a particular record represents a change to a prior record in the batch, or to existing details held on file for the payee. It’s also clear that not every financial institution pays attention to this field. Unless you are dealing with thousands of payments at a time, you should leave this field blank to make it clear that each record represents a separate payment.
        /// Default None.
        /// </summary>
        [FieldOrder(12)]
        [FieldFixedLength(6)]
        [FieldAlign(AlignMode.Right, '0')]
        public int OriginalUserIdentificationNumber;

        public ReturnsDetailRecord()
        {
            RecordType = 2;
        }
    }
}
