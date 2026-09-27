namespace Digi21.Digi3D
{
    public class Progress
    {
        internal Progress() => throw null;
        public bool Visible { get; set; }
        public int Value { get; set; }
        public int Maximum { get; set; }
        public int Minimum { get; set; }
    }
}
