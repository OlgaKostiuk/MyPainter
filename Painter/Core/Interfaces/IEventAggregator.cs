using System;

namespace Painter.Core.Interfaces
{
    public interface IEventAggregator
    {
        void Publish<TEventArgs>(Object sender, TEventArgs eventArgs) where TEventArgs : EventArgs;
        Subscription<TEventArgs> Subscribe<TEventArgs>(Core.PainterEventHandler<TEventArgs> painterEventHandler) where TEventArgs : EventArgs;
        void UnSubscribe<TEventArgs>(Subscription<TEventArgs> subscription) where TEventArgs : EventArgs;
    }
}