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
    public sealed partial class DelagateExecutor
    {
        private readonly List<IDelagateInterceptor> _interceptors
            = new List<IDelagateInterceptor>();

        private DelagateExecutor() { }

        /// <summary>
        /// 创建一个新的委托执行器。
        /// </summary>
        public static DelagateExecutor New()
        {
            return new DelagateExecutor();
        }

        /// <summary>
        /// 注册<paramref name="interceptor"/>。
        /// </summary>
        public DelagateExecutor RegisterInterceptor(IDelagateInterceptor interceptor)
        {
            Check.MustNotNull(interceptor, "interceptor");

            _interceptors.Add(interceptor);

            return this;
        }

        internal ReadOnlyCollection<IDelagateInterceptor> Interceptors
        {
            get
            {
                return new ReadOnlyCollection<IDelagateInterceptor>(_interceptors);
            }
        }
    }
}
