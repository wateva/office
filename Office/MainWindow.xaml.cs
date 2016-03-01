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
using Office.Entities;

namespace Office
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Firm firm;
        public MainWindow()
        {
            InitializeComponent();
            firm = new Firm();
            
        }

        private void oneStepButton_Click(object sender, RoutedEventArgs e)
        {
            firm.workflow();
        }

        private void oneWeekButton_Click(object sender, RoutedEventArgs e)
        {
            int j, i = firm.days;
            while (i - 7 > 7) i -= 7;
            i = 7 - i;
            for (j = 0; j < i; j++)
                firm.workflow();
            textBlock.Text = firm.reportArr[0];
        }
    }
}
