﻿using Remotely.ScreenCast.Core.Interfaces;
using System;

namespace Remotely.ScreenCast.Linux.Services
{
    public class AudioCapturerLinux : IAudioCapturer
    {
#pragma warning disable
        public event EventHandler<byte[]> AudioSampleReady;
#pragma warning restore

        public void ToggleAudio(bool toggleOn)
        {
            // Not implemented.
        }
    }
}
