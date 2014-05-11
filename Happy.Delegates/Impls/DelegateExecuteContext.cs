using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Happy.Delegates.Impls
{
    internal sealed class DelegateExecuteContext : IDelegateExecuteContext
    {
        private readonly DelegateExecutor _executor;
        private readonly Func<object> _delagateWapper;
        private readonly List<DelegateArgument> _arguments
            = new List<DelegateArgument>();
        private int _currentInterceptorIndex = -1;

        internal DelegateExecuteContext(DelegateExecutor executor, Func<object> delagateWapper)
        {
            Check.MustNotNull("executor", "executor");
            Check.MustNotNull("delagateWapper", "delagateWapper");

            _executor = executor;
            _delagateWapper = delagateWapper;
        }

        internal DelegateExecuteContext(DelegateExecutor executor, Func<object> delagateWapper,
                                 IEnumerable<DelegateArgument> arguments)
            : this(executor, delagateWapper)
        {
            Check.MustNotNull("arguments", "arguments");

            _arguments = arguments.ToList();
        }

        public ReadOnlyCollection<DelegateArgument> Arguments
        {
            get
            {
                return new ReadOnlyCollection<DelegateArgument>(_arguments);
            }
        }

        public object Next()
        {
            _currentInterceptorIndex++;
            if (_currentInterceptorIndex < _executor.Interceptors.Count)
            {
                return _executor.Interceptors[_currentInterceptorIndex].Intercept(this);
            }
            else
            {
                return _delagateWapper();
            }
        }
    }
}
