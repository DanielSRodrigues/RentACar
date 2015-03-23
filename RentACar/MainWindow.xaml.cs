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
using Domain;

namespace RentACar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadLogonPage();
        }

        private void LoadLogonPage()
        {

        }

        private void Entrar_Click(object sender, RoutedEventArgs e)
        {
            if (LoginCheck())
            {

            }
        }

        private bool LoginCheck()
        {
            bool ok = true;

            return ok;
        }
    }
}
