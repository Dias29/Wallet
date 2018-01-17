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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wallet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Item item = new Item();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private double tgnInBit;
        private double bit;

        private void SliderTgnChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            tngProc.Text = ((Slider)sender).SelectionEnd.ToString();
        }

        private void SliderBtcChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            btcProc.Text = ((Slider)sender).SelectionEnd.ToString();
        }

        private void ItemValueDragEnter(object sender, DragEventArgs e)
        {
            itemValue.Text = item.ItemValue.ToString();
        }

        private void TgnDragEnter(object sender, DragEventArgs e)
        {
            tgn.Text = item.TgnValue.ToString();
        }

        private void TgnInBtcDragEnter(object sender, DragEventArgs e)
        {
            tgnInBtc.Text = item.BtcInTgn.ToString();
            tgnInBit = double.Parse(tgnInBtc.Text);

        }

        private double TranslateBtc(double btc, double tgn)
        {
            return btc * tgn;
        }

        private void Btc1DragEnter(object sender, DragEventArgs e)
        {
            btc1.Text = item.BtcValue.ToString();
            bit = double.Parse(btc1.Text);
           // translateTgn.Text.
            translateTgn.Text = TranslateBtc(bit, tgnInBit).ToString();
            translateTgn.TextChanged
        }

       
    }
}
