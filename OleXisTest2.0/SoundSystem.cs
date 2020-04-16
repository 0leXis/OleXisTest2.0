using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using NAudio.Wave;

namespace OleXisTest
{
    static class SoundSystem
    {
        //Предоставляет звуковую подсистему
        static WaveOut Player = new WaveOut();

        //Воспроизведение звука
        static public void PlaySound(byte[] SoundFile)
        {
            Player.Stop();
            Player.Init(new WaveFileReader(new MemoryStream(SoundFile)));
            Player.Play();
        }
    }
}
