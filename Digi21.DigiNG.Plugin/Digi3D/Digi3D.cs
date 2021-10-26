using System;

namespace Digi21.Digi3D
{
    public static class Digi3D
    {
        static Digi3D() => throw null;
        public static void Music(MusicType music) => throw null;
        public static void ShowBallon(string title, string description, int seconds) => throw null;
        public static void ShowBallon(string title, string description, int seconds, BallonIcon icon) => throw null;
        public static void SynthesizeVoice(string text) => throw null;

        public static bool EnableSounds { get; set; }
        public static Panes Panes => throw null;
        public static Tasks Tasks => throw null;
        public static OutputWindow OutputWindow => throw null;
        public static StatusBar StatusBar => throw null;
        public static System.Drawing.Color BackgroundColor => throw null;
        public static System.Drawing.Color ForegroundColor => throw null;
        public static String CommandLine => throw null;
    }
}
