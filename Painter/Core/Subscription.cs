using System;
using Painter.Core.Interfaces;

namespace Painter.Core
{
    public delegate void PainterEventHandler<in TEventArgs>(Object sender, TEventArgs e) where TEventArgs : EventArgs;

    public class Subscription<TEventArgs> : ISubscription<TEventArgs> where TEventArgs : EventArgs
    {
        public PainterEventHandler<TEventArgs> EventHandler { get; }
        private readonly EventAggregator _eventAggregator;
        private bool _isDisposed;
        public Subscription(PainterEventHandler<TEventArgs> painterEventHandler, EventAggregator eventAggregator)
        {
            EventHandler = painterEventHandler;
            _eventAggregator = eventAggregator;
        }

        ~Subscription()
        {
            if (!_isDisposed)
                Dispose();
        }

        public void Dispose()
        {
            _eventAggregator.UnSubscribe(this);
            _isDisposed = true;
        }
    }
}
