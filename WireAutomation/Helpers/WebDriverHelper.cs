using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Helpers
{
    public static class WebDriverHelper
    {
        /// <summary>
        /// Method allows to make some attempts while waiting for an element
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="delegateFunction"></param>
        /// <param name="attempts"></param>
        /// <returns></returns>
        public static T Retry<T>(Func<T> delegateFunction, int attempts)
        {
            if (attempts == 0)
                return delegateFunction();

            var exception = new Exception("Element not found");

            for (; attempts > 0; attempts--)
            {
                try
                {
                    return delegateFunction();
                }
                catch (Exception ex)
                {
                    exception = ex;
                    Task.Delay(1000).Wait();
                }
            }
            throw exception;
        }

        /// <summary>
        /// Method waits for condition
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="attempts"></param>
        public static void WaitForCondition(Func<bool> condition, int attempts = 10)
        {
            for (var i = attempts; i > 0; i--)
            {
                Task.Delay(1000).Wait();
                if (condition())
                    return;
            }
            throw new Exception($"Invalid condition after {attempts} attempts");
        }
    }
}
