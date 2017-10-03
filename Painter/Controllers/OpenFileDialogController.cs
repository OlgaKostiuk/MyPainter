using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter.Controllers
{
    public interface IOpenFileDialogController
    {
        string GetFilePath();
    }

    public class OpenFileDialogController : IOpenFileDialogController
    {
        public string GetFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
    }
}
