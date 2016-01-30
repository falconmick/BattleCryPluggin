using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleCry
{
    class SoundBoard : ISoundBoard
    {
        private string _command;
        private readonly string _rootDirectory;
        [DllImport("winmm.dll")]

        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        public SoundBoard(string rootDirectory)
        {
            _rootDirectory = rootDirectory;
        }

        public void Close()
        {
            _command = "close MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
        }

        public void Play(SoundPlaySetting soundPlaySettings)
        {
            Task.Factory.StartNew(() => Thread.Sleep(soundPlaySettings.Delay))
            .ContinueWith((t) =>
            {
                Close();

                _command = "open \"" + _rootDirectory + soundPlaySettings.FileName + "\" type mpegvideo alias MediaFile";
                mciSendString(_command, null, 0, IntPtr.Zero);

                _command = "play MediaFile";

                mciSendString(_command, null, 0, IntPtr.Zero);
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
