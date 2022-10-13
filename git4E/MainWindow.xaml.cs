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

namespace git4E
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        //Belletti Lorenzo 4^E
        
        
        public MainWindow()
        {
            InitializeComponent();


            stampa_lbl.Content = "Hello word.com";


            nome_lbl.Content = "Belletti Lorenzo 4^E";
        }
    }
}
