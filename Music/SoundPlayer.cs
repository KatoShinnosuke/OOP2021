using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
     class SoundPlayer
    {
        private System.Media.SoundPlayer player = null;
        private void PlaySound(string waveFile)
        {
            if (player != null)
                StopSound();
            player = new System.Media.SoundPlayer(waveFile);
            player.Play();
        }
        private void StopSound()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }

    }
}
