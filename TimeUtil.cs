using System;

namespace Infrastructure
{
    public class TimeUtil
    {
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long GetTimeStamp(DateTime time)
        {
            TimeSpan ts = time - new DateTime(1970, 1, 1, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }
        /// <summary>
        /// 时间戳转时间
        /// </summary>
        /// <param name="timespan"></param>
        public static DateTime GetTime(long timespan)
        {
            TimeSpan ts = new TimeSpan(timespan);
            var start = new DateTime(1970, 1, 1, 0, 0, 0);
            return start.Add(ts);
        }
    }
}
