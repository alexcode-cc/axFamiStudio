﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Media
{
    public class SystemSound
    {
        // MATTT Move to platform utils.
        public void Play()
        {
            // DROIDTODO
        }
    }

    public sealed class SystemSounds
    {
        public static SystemSound Beep { get; }
    }
}