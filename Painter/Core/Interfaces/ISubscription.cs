using System;

namespace Painter.Core.Interfaces
{
    public interface ISubscription<TEventArgs> where TEventArgs : EventArgs
    {
        PainterEventHandler<TEventArgs> EventHandler { get; }
    }
}