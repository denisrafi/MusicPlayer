using System.Runtime.InteropServices;
using System.Text;

namespace WFA
{
    class Band
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder stringBuilder, int uReturnLength, int hwdCallBack);


        public void open(string File)
        {
            string Format = @"open ""{0}""type MPEGVideo alias MediaFile";
            string command = string.Format(Format,File);
            mciSendString(command, null, 0, 0);
        }

        public void play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0); 
        }
    }
}
