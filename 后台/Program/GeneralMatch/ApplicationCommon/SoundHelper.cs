using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Runtime.InteropServices;

namespace ApplicationCommon
{
    public struct playControl
    {
        public int playId;
        public string filename;
        public int loop;
    }

    public class SoundHelper
    {
        [DllImport("winmm.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool PlaySound(string pszSound,
            IntPtr hMod, SoundFlags sf);

        private static Hashtable hht = new Hashtable();

        [Flags]
        private enum SoundFlags : int
        {
            SND_SYNC = 0x0000,  /* play synchronously (default) */
            SND_ASYNC = 0x0001,  /* play asynchronously */
            SND_NODEFAULT = 0x0002,  /* silence (!default) if sound not found */
            SND_MEMORY = 0x0004,  /* pszSound points to a memory file */
            SND_LOOP = 0x0008,  /* loop the sound until next sndPlaySound */
            SND_NOSTOP = 0x0010,  /* don't stop any currently playing sound */
            SND_NOWAIT = 0x00002000, /* don't wait if the driver is busy */
            SND_ALIAS = 0x00010000, /* name is a registry alias */
            SND_ALIAS_ID = 0x00110000, /* alias is a predefined ID */
            SND_FILENAME = 0x00020000, /* name is file name */
            SND_RESOURCE = 0x00040004  /* name is resource name or atom */
        }

        public static void playAudio(int playId, string fileName, bool isloop)
        {
            if (isloop)
            {
                playAudio(playId, fileName, 0);
            }
            else
            {
                playAudio(playId, fileName, 1);
            }
        }

        public static void playAudio(int playId, string fileName, int loop)
        {
            bool addThread = true;
            if (hht.ContainsKey(playId))
            {
                object obj = hht[playId];

                if (obj == null)
                {
                    hht.Remove(playId);
                }
                else
                {
                    if (((Thread)obj).ThreadState == ThreadState.Running)
                    {
                        addThread = false;
                    }
                    else
                    {
                        ((Thread)obj).Abort();
                        hht.Remove(playId);
                    }
                }

            }

            if (addThread)
            {
                Thread t = new Thread(new ParameterizedThreadStart(myPlay));
                hht.Add(playId, t);
                playControl playCon = new playControl();
                playCon.filename = fileName;
                playCon.loop = loop;
                playCon.playId = playId;
                t.Start(playCon);
            }
        }

        public static void stopAudio(int playId)
        {
            disposeThread(playId);
        }

        private static void myPlay(object playStruct)
        {
            int err = 0;

            string temp_filename = ((playControl)playStruct).filename;
            int temp_loop = ((playControl)playStruct).loop;
            int temp_playId = ((playControl)playStruct).playId;

            if (temp_filename == string.Empty)
            {
                throw new Exception("请指定一个声音文件");
            }

            string[] checkFileType = temp_filename.Trim().Split(new char[] { '.' });
            if (checkFileType.Length == 2)
            {
                if (checkFileType[1].ToLower() == "wav")
                {
                    try
                    {
                        #region ......
                        if (temp_loop > 0)
                        {
                            for (int i = 0; i < temp_loop; i++)
                            {
                                if (!PlaySound(temp_filename, IntPtr.Zero, SoundFlags.SND_FILENAME | SoundFlags.SND_SYNC))
                                {
                                    throw new Exception("不能找到声音文件");
                                }
                            }
                        }
                        else
                        {
                            while (true)
                            {
                                if (!PlaySound(temp_filename, IntPtr.Zero, SoundFlags.SND_FILENAME | SoundFlags.SND_SYNC))
                                {
                                    throw new Exception("不能找到声音文件");
                                }
                            }
                        }
                        #endregion

                    }
                    catch
                    {
                        err = Marshal.GetLastWin32Error();
                        if (err != 0)
                        {
                            throw new Exception(err.ToString() + "播放声音失败");
                        }
                    }
                }
            }

            disposeThread(temp_playId);

        }

        private static void disposeThread(int playId)
        {
            if (((Thread)hht[playId]) != null)
                ((Thread)hht[playId]).Abort();
            hht.Remove(playId);
        }

        public static void PlaySound(String soundName)
        {
            try
            {
                String path = String.Format(@"{0}\{1}", DirectoryHelper.SoundDirectory, soundName);
                playAudio(0, String.Format(@"{0}\{1}", DirectoryHelper.SoundDirectory, soundName), false);
            }
            catch { }
        }

        public static void PlaySoundByFile(string fileName)
        {
            try
            {
                playAudio(0, fileName, false);
            }
            catch { }
        }
    }
}
