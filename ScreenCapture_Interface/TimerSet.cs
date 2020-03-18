using System.Timers;

namespace ScreenCapture_Interface
{
    public class TimerSet
    {
        private Timer Timer;
        public delegate void TimerInvoke();

        public void TimerStart(double dMillisecond, TimerInvoke tiCallback)
        {
            if (null != Timer)
            {
                Timer.Dispose();
            }
            Timer = new Timer(dMillisecond);
            Timer.Elapsed += delegate
            {
                tiCallback();
            };
            Timer.Start();
        }

        public void TimerStop()
        {
            if (null != Timer)
            {
                Timer.Stop();
                Timer.Dispose();
            }
        }

        public void Dispose()
        {
            if (null != Timer)
            {
                Timer.Dispose();
            }
        }
    }
}
