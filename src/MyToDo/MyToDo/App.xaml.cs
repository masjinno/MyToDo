using MyToDo.View;
using System.Windows;

namespace MyToDo
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Main window
        /// </summary>
        private MainWindow view;

        private void StartupApplication(object sender, StartupEventArgs e)
        {
            view = new MainWindow();
            view.Show();
        }
    }
}
