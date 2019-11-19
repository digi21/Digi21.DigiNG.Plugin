
namespace Digi21.DigiNG
{
    public static class DigitizingLineOptions
    {
        public static bool SmoothLineWhenFinish { get; set; }
        public static bool ParalelizeLineWhenFinish { get; set; }
        public static bool GeneralizeLineWhenFinish { get; set; }
        public static bool CloseLineWhenFinish { get; set; }
        public static double AngularTolerance { get; set; }
        public static double ContinuousModeIncrement { get; set; }
        public static double GeneralizationTolerance { get; set; }
    }
}
