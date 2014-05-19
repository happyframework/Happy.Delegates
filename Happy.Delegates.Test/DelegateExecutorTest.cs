using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Happy.Delegates.Test
{
    [TestFixture]
    public class DelegateExecutorTest
    {
        [Test]
        public void ExecuteFunc_Test()
        {
            var result = DelegateExecutor.New()
                                    .RegisterInterceptor(new TestDelagateInterceptor())
                                    .ExecuteFunc(this.TestFunc, "hello，", "world！");

            Assert.AreEqual("【hello，world！】", result);
        }

        [Test]
        public void ExecuteAction_Test()
        {
            DelegateExecutor.New()
                            .RegisterInterceptor(new TestDelagateInterceptor())
                            .ExecuteAction(this.TestAction, "hello，", "world！");
        }

        private string TestFunc(string arg1, string arg2)
        {
            return arg1 + arg2;
        }

        private void TestAction(string arg1, string arg2)
        {
            Console.WriteLine(arg1 + arg2);
        }

        private sealed class TestDelagateInterceptor : IDelegateInterceptor
        {
            public object Intercept(IDelegateExecuteContext context)
            {
                foreach (var item in context.Arguments)
                {
                    Console.WriteLine(string.Format("参数：{0}", item.Value));
                }

                return "【" + context.Proceed() + "】";
            }
        }
    }
}
