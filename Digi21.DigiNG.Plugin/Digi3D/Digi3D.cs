namespace Digi21.Digi3D
{
    public static class Digi3D
    {
        static Digi3D() { throw null; }
        public static void Music(MusicType music) { throw null; }
        public static void ShowBallon(string title, string description, int seconds) { throw null; }
        public static void ShowBallon(string title, string description, int seconds, BallonIcon icon) { throw null; }
        public static void SynthesizeVoice(string text) { throw null; }

        public static bool EnableSounds { get; set; }
        public static Panes Panes { get; }
        public static Tasks Tasks { get; }
        public static OutputWindow OutputWindow { get; }
        public static StatusBar StatusBar { get; }
    }
}
