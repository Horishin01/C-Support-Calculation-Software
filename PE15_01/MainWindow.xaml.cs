using Microsoft.VisualBasic;
using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PE15_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //TaxPrice _taxPrice;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Infomation_Click(object sender, RoutedEventArgs e)
        {
            // 現在のウィンドウを取得
            var currentWindow = Window.GetWindow(this);

            // 新しいウィンドウを作成
            var newWindow = new information();

            // 現在のウィンドウを閉じる
            //currentWindow.Close();

            // 新しいウィンドウを表示
            newWindow.Show();
        }
        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listView.SelectedItem == null)
                return;
            listView.Items.Refresh();
            PartShift selectedItem = (PartShift)listView.SelectedItem;
            this.DataContext = selectedItem;
        }



    }
}
