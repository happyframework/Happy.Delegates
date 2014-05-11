using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Happy.Delegates
{
    /// <summary>
    /// 委托上下文。
    /// </summary>
    public interface IDelagateContext
    {
        /// <summary>
        /// 参数集合。
        /// </summary>
        ReadOnlyCollection<DelagateArgument> Arguments { get; }

        /// <summary>
        /// 执行下一个拦截器，如果到终点了，就执行目标委托。
        /// </summary>
        object Next();
    }
}
