using System;
using Painter.Controllers.Interfaces;
using Painter.Core.Interfaces;
using Painter.Views;

namespace Painter.Controllers
{
    public class PMenuController : IPMenuController
    {
        public PMenu PMenu;
        public IEventAggregator EventAggregator;
        public IOpenFileDialogController OpenFileDialogController { get; set; }

        public event Core.PainterEventHandler<OpenFileEventArgs> OpenFile;

        public PMenuController(IEventAggregator eventAggregator, PMenu pMenu)
        {
            EventAggregator = eventAggregator;
            PMenu = pMenu;
            PMenu.openToolStripMenuItem.Click += OnOpenFile;
        }

        public void OnOpenFile(object sender, EventArgs e)
        {
            string path = OpenFileDialogController.GetFilePath();
            var openFileEventArgs = new OpenFileEventArgs
            {
                FilePath = path
            };
            EventAggregator.Publish(this, openFileEventArgs);
        }
    }

    public class OpenFileEventArgs : EventArgs
    {
        public string FilePath;
    }
}
