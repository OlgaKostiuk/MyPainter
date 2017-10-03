using System;

namespace Painter.Controllers.Interfaces
{
    public interface IPMenuController
    {
        IOpenFileDialogController OpenFileDialogController { get; set; }
        void OnOpenFile(object sender, EventArgs e);
    }
}