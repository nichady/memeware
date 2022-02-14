using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Martin
{
    internal partial class Martin : CustomForm
    {
        public Martin()
        {
            InitializeComponent();
            Activate();
            Play();
        }
        async void Play()
        {
            await Task.Delay(3000);
            Video video = new Video(AppDomain.CurrentDomain.BaseDirectory + @"\Resources\martin.wmv", false);
            video.Owner = this;
            video.Play();
            WindowState = FormWindowState.Minimized; Show(); WindowState = FormWindowState.Normal;

            await Task.Delay(3000);
            Application.Exit();
        }
    }
}
