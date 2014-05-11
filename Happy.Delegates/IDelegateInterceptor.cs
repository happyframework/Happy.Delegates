using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Happy.Delegates
{
    /// <summary>
    /// 委托拦截器。
    /// </summary>
    public interface IDelegateInterceptor
    {
        /// <summary>
        /// 拦截委托的执行。
        /// </summary>
        object Intercept(IDelegateExecuteContext context);
    }
}
