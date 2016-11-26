using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BattleCry.Util.Model;
using BattleCry.Util;
using System.Collections.Generic;
using BattleCry.Sound.Model;

namespace BattleCry.Sound
{
    class SoundBoard : ISoundBoard
    {
        private string _command;
        private readonly string _rootDirectory;
        private List<PlayQueueItem> _playQueue;
        [DllImport("winmm.dll")]

        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        public SoundBoard(string rootDirectory)
        {
            _rootDirectory = rootDirectory;
            _playQueue = new List<PlayQueueItem>();
        }

        public void Close()
        {
            _command = "close MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
        }

        public void Play(SoundPlaySetting soundPlaySettings)
        {
            Hearthstone_Deck_Tracker.Utility.Logging.Log.Info($"Playing: cardid: ${soundPlaySettings.CardId}, file name: ${soundPlaySettings.FileName}");
            if (soundPlaySettings.Delay <= 0)
            {
                DelayedPlayback(soundPlaySettings);
            }
            else
            {
                _playQueue.Add(new PlayQueueItem
                {
                    SoundPlaySetting = soundPlaySettings,
                    StartPlayingAfter = DateTime.Now.AddMilliseconds(soundPlaySettings.Delay).Ticks
                });
            }
        }

        private void DelayedPlayback(SoundPlaySetting soundPlaySettings)
        {
            Close();

            _command = "open \"" + _rootDirectory + soundPlaySettings.FileName + "\" type mpegvideo alias MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);

            _command = "play MediaFile";

            mciSendString(_command, null, 0, IntPtr.Zero);
        }

        public void Update()
        {
            var nowTicks = DateTime.Now.Ticks;
            var itemsToRemove = new List<PlayQueueItem>();

            foreach(var item in _playQueue)
            {
                if(nowTicks >= item.StartPlayingAfter)
                {
                    DelayedPlayback(item.SoundPlaySetting);
                    itemsToRemove.Add(item);
                }
            }

            foreach(var item in itemsToRemove)
            {
                _playQueue.Remove(item);
            }
        }
    }
}
