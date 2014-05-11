using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Happy.Delegates.Impls
{
    internal sealed class DelagateContext : IDelagateContext
    {
        private readonly DelagateExecutor _executor;
        private readonly Func<object> _delagateWapper;
        private readonly List<DelagateArgument> _arguments
            = new List<DelagateArgument>();
        private int _currentFilterIndex = -1;

        internal DelagateContext(DelagateExecutor executor, Func<object> delagateWapper)
        {
            Check.MustNotNull("executor", "executor");
            Check.MustNotNull("delagateWapper", "delagateWapper");

            _executor = executor;
            _delagateWapper = delagateWapper;
        }

        internal DelagateContext(DelagateExecutor executor, Func<object> delagateWapper,
                                 IEnumerable<DelagateArgument> arguments)
            : this(executor, delagateWapper)
        {
            Check.MustNotNull("arguments", "arguments");

            _arguments = arguments.ToList();
        }

        public ReadOnlyCollection<DelagateArgument> Arguments
        {
            get
            {
                return new ReadOnlyCollection<DelagateArgument>(_arguments);
            }
        }

        public object Next()
        {
            _currentFilterIndex++;
            if (_currentFilterIndex < _executor.Interceptors.Count)
            {
                return _executor.Interceptors[_currentFilterIndex].Intercept(this);
            }
            else
            {
                return _delagateWapper();
            }
        }
    }
}
