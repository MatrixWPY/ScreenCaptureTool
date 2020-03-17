using System;
using System.Timers;

namespace ScreenCapture_Interface
{
    public class TimerSet
    {
        private Timer Timer;
        public DateTime SetTime;
        public DateTime SetTimeFrom;
        public DateTime SetTimeTo;
        public int Frequency;
        public DateTime CaptureTime;
        public delegate void TimerInvoke();

        public void TimerStart(int iTimeCaptureMode, TimerInvoke tiCallback)
        {
            if (null != Timer)
            {
                Timer.Dispose();
            }
            Timer = new System.Timers.Timer(1000);
            Timer.Elapsed += delegate
            {
                CheckTimer(iTimeCaptureMode, tiCallback);
            };
            Timer.Start();
        }

        public void TimerStop()
        {
            Timer.Stop();
            Timer.Dispose();
        }

        public void Dispose()
        {
            TimerStop();
        }

        private void CheckTimer(int iTimeCaptureMode, TimerInvoke tiCallback)
        {
            DateTime dtNow = DateTime.Now;

            switch (iTimeCaptureMode)
            {
                case 0:
                    if (dtNow.ToString("HH:mm:ss") == SetTime.ToString("HH:mm:ss"))
                    {
                        tiCallback();
                    }
                    break;

                case 1:
                    if (dtNow > SetTimeFrom && dtNow < SetTimeTo)
                    {
                        if (dtNow.ToString("HH:mm:ss") == CaptureTime.ToString("HH:mm:ss"))
                        {
                            CaptureTime = CaptureTime.AddMinutes(Frequency);
                            tiCallback();
                        }
                    }
                    else
                    {
                        CaptureTime = SetTimeFrom.AddMinutes(Frequency);
                    }
                    break;
            }
        }
    }
}
