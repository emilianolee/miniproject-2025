using MahApps.Metro.Controls;

namespace WpfMrpSimulatorApp.Views
{
    /// <summary>
    /// MainView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : MetroWindow
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;    // x버튼을 눌려도, Alt+F4를 눌러도 안꺼짐
        }
    }
}
