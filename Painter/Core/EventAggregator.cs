using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Painter.Core.Interfaces;

namespace Painter.Core
{
    public class EventAggregator : IEventAggregator
    {
        private Dictionary<Type, IList> subscriber;

        public EventAggregator()
        {
            subscriber = new Dictionary<Type, IList>();
        }

        public void Publish<TEventArgs>(Object sender, TEventArgs eventArgs) where TEventArgs : EventArgs
        {
            Type t = typeof(TEventArgs);
            IList actionlst;
            if (subscriber.ContainsKey(t))
            {
                actionlst = new List<Subscription<TEventArgs>>(subscriber[t].Cast<Subscription<TEventArgs>>());

                foreach (Subscription<TEventArgs> a in actionlst)
                {
                    a.EventHandler(sender, eventArgs);
                }
            }
        }

        public Subscription<TEventArgs> Subscribe<TEventArgs>(PainterEventHandler<TEventArgs> eventHandler) where TEventArgs : EventArgs
        {
            Type t = typeof(TEventArgs);
            IList actionlst;
            var actiondetail = new Subscription<TEventArgs>(eventHandler, this);

            if (!subscriber.TryGetValue(t, out actionlst))
            {
                actionlst = new List<Subscription<TEventArgs>>();
                actionlst.Add(actiondetail);
                subscriber.Add(t, actionlst);
            }
            else
            {
                actionlst.Add(actiondetail);
            }

            return actiondetail;
        }

        public void UnSubscribe<TEventArgs>(Subscription<TEventArgs> subscription) where TEventArgs : EventArgs
        {
            Type t = typeof(TEventArgs);
            if (subscriber.ContainsKey(t))
            {
                subscriber[t].Remove(subscription);
            }
        }
    }
}
