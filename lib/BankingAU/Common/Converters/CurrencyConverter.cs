﻿using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.AU.Common.Converters
{
    /// <summary>
    /// Provides conversion from dollars to cents.
    /// </summary>
    public class CurrencyConverter : ConverterBase
    {
        public CurrencyConverter()
        { }

        public override string FieldToString(object from)
        {
            if (from is decimal)
                return ((int)(((decimal)from) * 100)).ToString();
            return string.Empty;
        }

        public override object StringToField(string from)
        {
            decimal result;
            if (Decimal.TryParse(from, out result))
                return result / 100;
            return 0;
        }
    }

    /// <summary>
    /// Provides conversion from dollars to cents, ensuring a value greater than zero.
    /// </summary>
    public class UnsignedCurrencyConverter : ConverterBase
    {
        public UnsignedCurrencyConverter()
        { }

        public override string FieldToString(object from)
        {
            if (from is decimal)
                return ((int)(Math.Abs((decimal)from) * 100)).ToString();
            return string.Empty;
        }

        public override object StringToField(string from)
        {
            decimal result;
            if (Decimal.TryParse(from, out result))
                return result / 100;
            return 0;
        }
    }
}
