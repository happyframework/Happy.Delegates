using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Happy.Delegates.Impls;

namespace Happy.Delegates
{
    public sealed partial class DelegateExecutor
    {
		public void ExecuteAction(Action action)
		{
			Func<object> delagateWapper = ()=> { 
				action(); 

				return null; 
			};

			var context = new DelegateExecuteContext(this, delagateWapper);

			context.Next();
		}

		public void ExecuteAction<T1>(Action<T1> action, T1 arg1)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4, arg5); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));
			arguments.Add(new DelegateArgument(typeof(T5), arg5));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4, arg5, arg6); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));
			arguments.Add(new DelegateArgument(typeof(T5), arg5));
			arguments.Add(new DelegateArgument(typeof(T6), arg6));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4, arg5, arg6, arg7); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));
			arguments.Add(new DelegateArgument(typeof(T5), arg5));
			arguments.Add(new DelegateArgument(typeof(T6), arg6));
			arguments.Add(new DelegateArgument(typeof(T7), arg7));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));
			arguments.Add(new DelegateArgument(typeof(T5), arg5));
			arguments.Add(new DelegateArgument(typeof(T6), arg6));
			arguments.Add(new DelegateArgument(typeof(T7), arg7));
			arguments.Add(new DelegateArgument(typeof(T8), arg8));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));
			arguments.Add(new DelegateArgument(typeof(T5), arg5));
			arguments.Add(new DelegateArgument(typeof(T6), arg6));
			arguments.Add(new DelegateArgument(typeof(T7), arg7));
			arguments.Add(new DelegateArgument(typeof(T8), arg8));
			arguments.Add(new DelegateArgument(typeof(T9), arg9));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));
			arguments.Add(new DelegateArgument(typeof(T5), arg5));
			arguments.Add(new DelegateArgument(typeof(T6), arg6));
			arguments.Add(new DelegateArgument(typeof(T7), arg7));
			arguments.Add(new DelegateArgument(typeof(T8), arg8));
			arguments.Add(new DelegateArgument(typeof(T9), arg9));
			arguments.Add(new DelegateArgument(typeof(T10), arg10));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));
			arguments.Add(new DelegateArgument(typeof(T5), arg5));
			arguments.Add(new DelegateArgument(typeof(T6), arg6));
			arguments.Add(new DelegateArgument(typeof(T7), arg7));
			arguments.Add(new DelegateArgument(typeof(T8), arg8));
			arguments.Add(new DelegateArgument(typeof(T9), arg9));
			arguments.Add(new DelegateArgument(typeof(T10), arg10));
			arguments.Add(new DelegateArgument(typeof(T11), arg11));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));
			arguments.Add(new DelegateArgument(typeof(T5), arg5));
			arguments.Add(new DelegateArgument(typeof(T6), arg6));
			arguments.Add(new DelegateArgument(typeof(T7), arg7));
			arguments.Add(new DelegateArgument(typeof(T8), arg8));
			arguments.Add(new DelegateArgument(typeof(T9), arg9));
			arguments.Add(new DelegateArgument(typeof(T10), arg10));
			arguments.Add(new DelegateArgument(typeof(T11), arg11));
			arguments.Add(new DelegateArgument(typeof(T12), arg12));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));
			arguments.Add(new DelegateArgument(typeof(T5), arg5));
			arguments.Add(new DelegateArgument(typeof(T6), arg6));
			arguments.Add(new DelegateArgument(typeof(T7), arg7));
			arguments.Add(new DelegateArgument(typeof(T8), arg8));
			arguments.Add(new DelegateArgument(typeof(T9), arg9));
			arguments.Add(new DelegateArgument(typeof(T10), arg10));
			arguments.Add(new DelegateArgument(typeof(T11), arg11));
			arguments.Add(new DelegateArgument(typeof(T12), arg12));
			arguments.Add(new DelegateArgument(typeof(T13), arg13));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));
			arguments.Add(new DelegateArgument(typeof(T5), arg5));
			arguments.Add(new DelegateArgument(typeof(T6), arg6));
			arguments.Add(new DelegateArgument(typeof(T7), arg7));
			arguments.Add(new DelegateArgument(typeof(T8), arg8));
			arguments.Add(new DelegateArgument(typeof(T9), arg9));
			arguments.Add(new DelegateArgument(typeof(T10), arg10));
			arguments.Add(new DelegateArgument(typeof(T11), arg11));
			arguments.Add(new DelegateArgument(typeof(T12), arg12));
			arguments.Add(new DelegateArgument(typeof(T13), arg13));
			arguments.Add(new DelegateArgument(typeof(T14), arg14));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));
			arguments.Add(new DelegateArgument(typeof(T5), arg5));
			arguments.Add(new DelegateArgument(typeof(T6), arg6));
			arguments.Add(new DelegateArgument(typeof(T7), arg7));
			arguments.Add(new DelegateArgument(typeof(T8), arg8));
			arguments.Add(new DelegateArgument(typeof(T9), arg9));
			arguments.Add(new DelegateArgument(typeof(T10), arg10));
			arguments.Add(new DelegateArgument(typeof(T11), arg11));
			arguments.Add(new DelegateArgument(typeof(T12), arg12));
			arguments.Add(new DelegateArgument(typeof(T13), arg13));
			arguments.Add(new DelegateArgument(typeof(T14), arg14));
			arguments.Add(new DelegateArgument(typeof(T15), arg15));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}

		public void ExecuteAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
		{
			Func<object> delagateWapper = ()=> { 
				action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16); 

				return null; 
			};

			var arguments = new List<DelegateArgument>();
			arguments.Add(new DelegateArgument(typeof(T1), arg1));
			arguments.Add(new DelegateArgument(typeof(T2), arg2));
			arguments.Add(new DelegateArgument(typeof(T3), arg3));
			arguments.Add(new DelegateArgument(typeof(T4), arg4));
			arguments.Add(new DelegateArgument(typeof(T5), arg5));
			arguments.Add(new DelegateArgument(typeof(T6), arg6));
			arguments.Add(new DelegateArgument(typeof(T7), arg7));
			arguments.Add(new DelegateArgument(typeof(T8), arg8));
			arguments.Add(new DelegateArgument(typeof(T9), arg9));
			arguments.Add(new DelegateArgument(typeof(T10), arg10));
			arguments.Add(new DelegateArgument(typeof(T11), arg11));
			arguments.Add(new DelegateArgument(typeof(T12), arg12));
			arguments.Add(new DelegateArgument(typeof(T13), arg13));
			arguments.Add(new DelegateArgument(typeof(T14), arg14));
			arguments.Add(new DelegateArgument(typeof(T15), arg15));
			arguments.Add(new DelegateArgument(typeof(T16), arg16));

			var context = new DelegateExecuteContext(this, delagateWapper, arguments);

			context.Next();
		}
	}
}