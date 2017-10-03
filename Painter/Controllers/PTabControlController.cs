using System;
using System.Collections.Generic;
using Painter.Core.Interfaces;
using Painter.Views;

namespace Painter.Controllers
{
    public class PTabControlController
    {
        private IList<TabPageController> _tabsList = new List<TabPageController>();
        public IEventAggregator EventAggregator;
        public PTabControl PTabControl;

        public PTabControlController(IEventAggregator eventAggregator, PTabControl pTabControl)
        {
            EventAggregator = eventAggregator;
            PTabControl = pTabControl;
            EventAggregator.Subscribe<OpenFileEventArgs>(AddNewTab);
        }

        public void AddNewTab(Object sender, OpenFileEventArgs e)
        {
            new TabPageController(PTabControl);
        }
    }
}
