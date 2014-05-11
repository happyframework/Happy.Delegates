using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Happy.Delegates
{
    /// <summary>
    /// 委托执行器。
    /// </summary>
    public sealed partial class DelegateExecutor
    {
        private readonly List<IDelegateInterceptor> _interceptors
            = new List<IDelegateInterceptor>();

        private DelegateExecutor() { }

        /// <summary>
        /// 创建一个新的委托执行器。
        /// </summary>
        public static DelegateExecutor New()
        {
            return new DelegateExecutor();
        }

        /// <summary>
        /// 注册<paramref name="interceptor"/>。
        /// </summary>
        public DelegateExecutor RegisterInterceptor(IDelegateInterceptor interceptor)
        {
            Check.MustNotNull(interceptor, "interceptor");

            _interceptors.Add(interceptor);

            return this;
        }

        internal ReadOnlyCollection<IDelegateInterceptor> Interceptors
        {
            get
            {
                return new ReadOnlyCollection<IDelegateInterceptor>(_interceptors);
            }
        }
    }
}
