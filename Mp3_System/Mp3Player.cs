using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mp3_System
{
    class Mp3Player : IDisposable
    {
        public bool Repeat { get; set; }

        public Mp3Player(string fileName)
        {
            const string FORMAT = @"open""{0}""type mpegvideo alias MediaFile";
            string command = string.Format(FORMAT, fileName);
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void Play()
        {
            string command = "play MadiaFile";
            if (Repeat) command += "REPEAT";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void Stop()
        {
            string command = "Stop MadiaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand,
            StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        public void Dispose()
        {
            string command = "close MadiaFile";
            mciSendString(command, null, 0, IntPtr.Zero);

        }
    }
}
