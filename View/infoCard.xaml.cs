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
using workinterview.Model;

namespace workinterview.View
{
    /// <summary>
    /// Interaction logic for infoCard.xaml
    /// </summary>
    public partial class infoCard : UserControl
    {
        public infoCard()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public Vender Info {get; set; }
    }
}
