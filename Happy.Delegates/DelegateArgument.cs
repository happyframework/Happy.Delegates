using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Happy.Delegates
{
    /// <summary>
    /// 委托参数。
    /// </summary>
    public sealed class DelegateArgument
    {
        internal DelegateArgument(Type type, object value)
        {
            Check.MustNotNull(type, "type");

            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// 参数类型。
        /// </summary>
        public Type Type { get; private set; }

        /// <summary>
        /// 参数值。
        /// </summary>
        public object Value { get; private set; }
    }
}
