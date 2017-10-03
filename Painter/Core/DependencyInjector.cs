using System.Windows.Forms;
using Painter.Controllers;
using Painter.Controllers.Interfaces;
using Painter.Core.Interfaces;
using Painter.Views;

namespace Painter.Core
{
    public class DependencyInjector
    {
        public IEventAggregator EventAggregator;
        public MainForm MainForm;
        public IPMenuController PMenuController;
        public IOpenFileDialogController OpenFileDialogController;
        public PTabControlController PTabControlController;

        public DependencyInjector()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            EventAggregator = new EventAggregator();


            MainForm = new MainForm();
            OpenFileDialogController = new OpenFileDialogController();
            PMenuController = new PMenuController(EventAggregator, MainForm.pMenu);
            PMenuController.OpenFileDialogController = OpenFileDialogController;
            PTabControlController = new PTabControlController(EventAggregator, MainForm.pTabControl1);
        }

        public void Start()
        {
            Application.Run(MainForm);
        }
    }
}