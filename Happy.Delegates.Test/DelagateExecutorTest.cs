using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Happy.Delegates.Test
{
    [TestFixture]
    public class DelagateExecutorTest
    {
        [Test]
        public void ExecuteFunc_Test()
        {
            var result = DelagateExecutor.New()
                                    .RegisterInterceptor(new TestDelagateFilter())
                                    .ExecuteFunc(this.TestFunc, "hello，", "world！");

            Assert.AreEqual("【hello，world！】", result);
        }

        [Test]
        public void ExecuteAction_Test()
        {
            DelagateExecutor.New()
                            .RegisterInterceptor(new TestDelagateFilter())
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

        private sealed class TestDelagateFilter : IDelagateInterceptor
        {
            public object Intercept(IDelagateContext context)
            {
                foreach (var item in context.Arguments)
                {
                    Console.WriteLine(string.Format("参数：{0}", item.Value));
                }

                return "【" + context.Next() + "】";
            }
        }
    }
}
