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
        /// The day of the month of the originating transaction. Positions 75 – 76 of the original type 0 (descriptive) record.
        /// </summary>
        [FieldOrder(11)]
        [FieldFixedLength(2)]
        public int OriginalDayOfProcessing;

        /// <summary>
        /// Original User’s ID Number. Positions 57 – 62 of the original type 0 (descriptive) record.
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
