using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Digi21.Digi3D
{
    public class Panes
    {
        public Pane Add(Form form) => throw null;
        public Pane Add(Form form, Size size) => throw null;
        public Pane Add(Form form, PaneDock initialDock) => throw null;
        public Pane Add(Form form, Size size, PaneDock initialDock) => throw null;
        public Pane Add(Form form, PaneDock initialDock, bool allowClose) => throw null;
        public Pane Add(Form form, Size size, PaneDock initialDock, bool allowClose) => throw null;

        public T Add<T>(Form form, params object[] args) where T : Pane => throw null;
        public T Add<T>(Form form, Size size, params object[] args) where T : Pane => throw null;
        public T Add<T>(Form form, PaneDock initialDock, params object[] args) where T : Pane => throw null;
        public T Add<T>(Form form, Size size, PaneDock initialDock, params object[] args) where T : Pane => throw null;
        public T Add<T>(Form form, PaneDock initialDock, bool allowClose, params object[] args) where T : Pane => throw null;
        public T Add<T>(Form form, Size size, PaneDock initialDock, bool allowClose, params object[] args) where T : Pane => throw null;

    }
}
