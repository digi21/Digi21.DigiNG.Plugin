using System;
using System.Drawing;

namespace Digi21.Digi3D
{
    public class Pane
    {
        public event EventHandler SplitterResized;
        public event EventHandler SplitterResizing;
        public event EventHandler Unpinned;
        public event EventHandler Unpinning;
        public event EventHandler Dragging;
        public event EventHandler Detaching;
        public event EventHandler Deactivated;
        public event EventHandler Activated;
        public event EventHandler Expanded;
        public event EventHandler Expanding;
        public event EventHandler Collapsed;
        public event EventHandler Collapsing;
        public event EventHandler Pinned;
        public event EventHandler Pinning;
        public event EventHandler Attached;
        public event EventHandler Attaching;
        public event EventHandler Docked;
        public event EventHandler Docking;
        public event EventHandler Closed;
        public event EventHandler Floated;
        public event EventHandler Floating;
        public event EventHandler Closing;

        public Size MaxTrackSize
        {
            set => throw null;
        }

        public Size MinTrackSize
        {
            set => throw null;
        }

        public bool IsFocus => throw null;

        public bool IsTabsVisible => throw null;

        public bool IsSidePanel => throw null;

        public bool IsFloating => throw null;

        public bool IsSelected => throw null;

        public bool IsHidden => throw null;

        public bool IsClosed => throw null;

        public string Tooltip
        {
            get => throw null;
            set => throw null;
        }

        public string TabCaption
        {
            get => throw null;
            set => throw null;
        }

        public string Title
        {
            get => throw null;
            set => throw null;
        }

        public void SetFocus() => throw null;
        public void Close() => throw null;
        public void Hide() => throw null;
        public void Select() => throw null;
    }
}
