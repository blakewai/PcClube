using PCClub.DataBase;
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

namespace PCClub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            MainFrame.NavigationService.Navigate(new Uri("Pages/Authorization.Xaml", UriKind.RelativeOrAbsolute));
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;


            //Создание пользователя, прописывается в CreateUser
            //Logic.CreateTable.CreateTablesAll CreateUser = new Logic.CreateTable.CreateTablesAll();
            //CreateUser.CreateTableUser("Roma", 
            //                           "Gavrikov", 
            //                           "Evginevich", 
            //                           20000, 
            //                           new DateTime(2007, 02, 16), 
            //                           "roma@mail.ru", 
            //                           "Roma", 
            //                           "123", 
            //                           1,
            //                           "+79808962008");
        }
    }
}