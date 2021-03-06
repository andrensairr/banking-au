﻿using Banking.AU.Common.Attributes;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.AU.Common.Converters
{
    /// <summary>
    /// Uses FileRepresentation attribute on enum values to encode/decode.  If not present
    /// it uses the enum value.ToString().
    /// </summary>
    public class EnumConverter : ConverterBase
    {
        private Dictionary<object, string> _lookup;

        protected override bool CustomNullHandling => true;

        public EnumConverter(Type enumType)
        {
            _lookup = new Dictionary<object,string>();
            foreach (var e in Enum.GetValues(enumType))
            {
                _lookup.Add(e, e.ToString());
                var attrs = enumType.GetField(e.ToString()).GetCustomAttributes(typeof(FileRepresentationAttribute), false);
                if (attrs.Length == 1)
                    _lookup[e] = ((FileRepresentationAttribute)attrs[0]).Representation;
            }
        }

        public override string FieldToString(object from)
        {
            if (from == null)
                return string.Empty;

            if (_lookup.ContainsKey(from))
                return _lookup[from];
            return base.FieldToString(from);
        }

        public override object StringToField(string from)
        {
            if (String.IsNullOrEmpty(from))
                return null;

            foreach (var pair in _lookup)
                if (pair.Value == from)
                    return pair.Key;
            return 0;
        }
    }
}
