using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressCode.Common;
using System.IO;
using System.Reflection;
using System.Transactions;
using ExpressCode.Repository;

namespace ExpressCode
{
    public class AopTest : IInterceptor
    {
        // 是否开启事务
        private bool isTran = false;
        public void Intercept(IInvocation invocation)
        {

            //NLogHelper.AddAOPLog(invocation, "返回结果", true);
            //invocation.Proceed();//在被拦截的方法执行完毕后 继续执行
            //Console.WriteLine("方法执行后");

            #region  日志2.0
            // 记录被拦截方法的日志信息
            //var dataInterceptor = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}" +
            //    $"当前执行方法:{invocation.Method.Name} " +
            //    $"参数是: {string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray())} \r\n";
            //try
            //{
            //    // 在被拦截的方法执行完毕后 继续执行当前方法
            //    invocation.Proceed();

            //    dataInterceptor += ($"方法执行完毕,返回结果:{invocation.ReturnValue}");

            //    #region 输出当前项目日志
            //    var path = Directory.GetCurrentDirectory() + @"\Log";
            //    if (!Directory.Exists(path))
            //    {
            //        Directory.CreateDirectory(path);
            //    }
            //    string fileName = path + $@"\InterceptLog-{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.log";
            //    StreamWriter sw = File.AppendText(fileName);
            //    sw.WriteLine(dataInterceptor);
            //    sw.Close();
            //    #endregion
            //}
            //catch (Exception e)
            //{
            //    #region 输出当前项目日志
            //    var path = Directory.GetCurrentDirectory() + @"\Log";
            //    if (!Directory.Exists(path))
            //    {
            //        Directory.CreateDirectory(path);
            //    }
            //    string fileName = path + $@"\InterceptLog-{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.log";
            //    StreamWriter sw = File.AppendText(fileName);
            //    sw.WriteLine(dataInterceptor + $"方法执行者出现异常：{e.Message + e.InnerException}");
            //    sw.Close();
            //    #endregion
            //    dataInterceptor += ($"方法执行者出现异常：{e.Message + e.InnerException}");
            //}
            #endregion

            if (!isTran)
            {
                MethodInfo methodInfo = invocation.Method;
                if (methodInfo == null)
                {
                    methodInfo = invocation.MethodInvocationTarget;
                }

                TransactionCallHandlerAttribute transaction =
                    methodInfo.GetCustomAttributes<TransactionCallHandlerAttribute>(true).FirstOrDefault();
                if (transaction != null)
                {
                    TransactionOptions transactionOptions = new TransactionOptions();
                    //设置事务隔离级别
                    transactionOptions.IsolationLevel = transaction.IsolationLevel;
                    //设置事务超时时间为60秒
                    transactionOptions.Timeout = new TimeSpan(0, 0, transaction.Timeout);
                    using (TransactionScope scope = new TransactionScope(transaction.ScopeOption, transactionOptions))
                    {
                        try
                        {
                            //实现事务性工作
                            invocation.Proceed();
                            scope.Complete();
                        }
                        catch (Exception ex)
                        {
                            // 记录异常
                            throw ex;
                        }
                    }
                }
                else
                {
                    // 没有事务时直接执行方法
                    invocation.Proceed();
                }
            }
            else
            {
                //跳过拦截
                invocation.Proceed();
            }

        }

    }
    
}
