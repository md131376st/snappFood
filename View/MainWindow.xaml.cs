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
using workinterview.ViewModel;

namespace workinterview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ApiHandler apihandler;
        public MainWindow()
        {
            InitializeComponent();
            apihandler = new ApiHandler();
            MainGrid.ItemsSource = apihandler.VenderLst;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn= e.Source as Button;
            switch (btn.Name)
            {
                case "max_rate":
                    apihandler.CallApi(SortingParameres.max_rate);
                    break;
                case "least_expensive":
                    apihandler.CallApi(SortingParameres.least_expensive);
                    break;
                case "top_performance":
                    apihandler.CallApi(SortingParameres.top_performance);
                    break;
                case "most_expensive":
                    apihandler.CallApi(SortingParameres.most_expensive);
                    break;
                default:
                    apihandler.CallApi(SortingParameres.defult);
                    break;
            }

            MainGrid.Items.Refresh();
        }
    }
}
