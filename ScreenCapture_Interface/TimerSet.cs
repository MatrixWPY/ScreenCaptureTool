using System;

namespace ScreenCapture_Interface
{
    public class TimerSet
    {
        private System.Timers.Timer Timer;
        public DateTime SetTime;
        public DateTime SetTimeFrom;
        public DateTime SetTimeTo;
        public int Frequency;
        public DateTime CaptureTime;
        public delegate void TimerInvoke(int iMutipleScreenMode, string strSavePath);

        public void TimerStart(int iTimeCaptureMode, int iMutipleScreenMode, string strSavePath, TimerInvoke tiCallback)
        {
            if (null != Timer)
            {
                Timer.Dispose();
            }
            Timer = new System.Timers.Timer(1000);
            Timer.Elapsed += delegate
            {
                CheckTimer(iTimeCaptureMode, iMutipleScreenMode, strSavePath, tiCallback);
            };
            Timer.Start();
        }

        public void TimerStop()
        {
            Timer.Stop();
            Timer.Dispose();
        }

        private void CheckTimer(int iTimeCaptureMode, int iMutipleScreenMode, string strSavePath, TimerInvoke tiCallback)
        {
            DateTime dtNow = DateTime.Now;

            switch (iTimeCaptureMode)
            {
                case 0:
                    if (dtNow.ToString("HH:mm:ss") == SetTime.ToString("HH:mm:ss"))
                    {
                        tiCallback(iMutipleScreenMode, strSavePath);
                    }
                    break;

                case 1:
                    if (dtNow > SetTimeFrom && dtNow < SetTimeTo)
                    {
                        if (dtNow.ToString("HH:mm:ss") == CaptureTime.ToString("HH:mm:ss"))
                        {
                            CaptureTime = CaptureTime.AddMinutes(Frequency);
                            tiCallback(iMutipleScreenMode, strSavePath);
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
