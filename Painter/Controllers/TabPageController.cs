using System.Windows.Forms;
using Painter.Views;

namespace Painter.Controllers
{
    public class TabPageController
    {
        public TabPageController(PTabControl tabControl)
        {
            TabPage tabPage = new TabPage();
            tabControl.tabControl.Controls.Add(tabPage);
        }
    }
}
