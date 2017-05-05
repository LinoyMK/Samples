using NLog;
using RedLock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DistributedRedLock
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static string resource = "test-redLock";
        private static TimeSpan expiry = TimeSpan.FromSeconds(300000);
        private static TimeSpan waitTime = TimeSpan.FromMilliseconds(303000);
        private static TimeSpan retryTime = TimeSpan.FromMilliseconds(1000);

        static void Main(string[] args)
        {

            var redisLockFactory = new RedisLockFactory(new DnsEndPoint("192.168.0.56", 6379));
            Parallel.For(1, 100, m => DoLock(redisLockFactory, m));
            logger.Trace("End of RedLock testing");
            Console.WriteLine("End of RedLock testing");


            Thread.Sleep(60000);

            Console.ReadKey();
            redisLockFactory.Dispose();
        }

        private static async void DoLock(RedisLockFactory redisLockFactory, int value)
        {
            logger.Trace($"Going to achieve lock with Id {value} and Time :{DateTime.Now.ToString("hh.mm.ss.ffffff")}");

            using (var redisLock = await redisLockFactory.CreateAsync(resource, expiry, waitTime, retryTime))
            {
                if (redisLock.IsAcquired)
                {
                    logger.Trace($"Lock achieved with Id {value} and Time :{DateTime.Now.ToString("hh.mm.ss.ffffff")}");
                    Thread.Sleep(10);
                }
                else
                {
                    logger.Trace($"Failed to get the lock with Id {value} and Time :{DateTime.Now.ToString("hh.mm.ss.ffffff")}");
                }
            }

        }
    }
}
