using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PE15_01
{
    /// <summary>
    /// information.xaml の相互作用ロジック
    /// </summary>
    public partial class information : Window
    {
        PartShift _partShift;
        public information()
        {
            InitializeComponent();
            _partShift = (PartShift)this.FindResource("partShift");
        }


        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listView.SelectedItem == null)
                return;
            listView.Items.Refresh();
            // PartShift selectedItem = (PartShift)listView.SelectedItem;
            TaxPrice selectedItem = (TaxPrice)listView.SelectedItem;
            this.DataContext = selectedItem;
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            // PartShift newPartShift = new PartShift("",0,0,0);
            // _partShift.Add(newPartShift);
            // listView.SelectedItem = newPartShift;
            TaxPrice newTaxPrice = new TaxPrice("", 0, 0, 0, 0);
            _partShift.Add(newTaxPrice);
            listView.SelectedItem = newTaxPrice;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            // PartShift selectedItem = (PartShift)listView.SelectedItem;
            TaxPrice selectedItem = (TaxPrice)listView.SelectedItem;
        }


    }
}
