﻿#if UNITY_METRO && !UNITY_EDITOR

namespace System.Threading
{
    public class Thread
    {
        public static void Sleep(int ms)
        {
            new System.Threading.ManualResetEvent(false).WaitOne(ms);
        }
    }
}

#endif