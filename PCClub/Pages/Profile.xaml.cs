using System;
using System.Collections.Generic;
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

namespace PCClub.Pages
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();

            ProfileIdRole();
            ProfileInfo();
            Collor();
        }

        public void Collor()
        {
            Collor_Profile.BorderBrush = new SolidColorBrush(Colors.Black);
            Collor_Accessories.BorderBrush = new SolidColorBrush(Colors.Black);
            Collor_Data.BorderBrush = new SolidColorBrush(Colors.Black);
            Collor_Employee.BorderBrush = new SolidColorBrush(Colors.Black);
            Collor_Manager.BorderBrush = new SolidColorBrush(Colors.Black);
            Collor_Tariff.BorderBrush = new SolidColorBrush(Colors.Black);
        }

        public void ProfileIdRole()
        {
            switch (Authorization._userRole)
            {
                case 1:
                    Collor_Accessories.Visibility = Visibility.Collapsed;
                    AccessoriesBT.Visibility = Visibility.Collapsed;

                    Collor_Manager.Visibility = Visibility.Visible;
                    ManagerBT.Visibility = Visibility.Visible;

                    Collor_Tariff.Visibility = Visibility.Collapsed;
                    TariffBT.Visibility = Visibility.Collapsed;

                    Collor_Employee.Visibility = Visibility.Visible;
                    EmployeeBT.Visibility = Visibility.Visible;
                    break;
                case 2:
                    Collor_Accessories.Visibility = Visibility.Collapsed;
                    AccessoriesBT.Visibility = Visibility.Collapsed;

                    Collor_Manager.Visibility = Visibility.Collapsed;
                    ManagerBT.Visibility = Visibility.Collapsed;

                    Collor_Tariff.Visibility = Visibility.Collapsed;
                    TariffBT.Visibility = Visibility.Collapsed;

                    Collor_Employee.Visibility = Visibility.Visible;
                    EmployeeBT.Visibility = Visibility.Visible;
                    break;
                case 3:
                    Collor_Accessories.Visibility = Visibility.Visible;
                    AccessoriesBT.Visibility = Visibility.Visible;

                    Collor_Manager.Visibility = Visibility.Collapsed;
                    ManagerBT.Visibility = Visibility.Collapsed;

                    Collor_Tariff.Visibility = Visibility.Visible;
                    TariffBT.Visibility = Visibility.Visible;

                    Collor_Employee.Visibility = Visibility.Collapsed;
                    EmployeeBT.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        public void ProfileInfo()
        {
            FrameUser.NavigationService.Navigate(new Uri("Pages\\PagesUser\\ProfileUser.xaml", UriKind.RelativeOrAbsolute));
            Collor_Profile.BorderThickness = new Thickness(1, 1, 1, 0);
            
            Collor_Accessories.BorderThickness = new Thickness (0, 0, 0, 0);
            Collor_Data.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Employee.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Manager.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Tariff.BorderThickness = new Thickness(0, 0, 0, 0);
        }

        private void ProfileBT_Click(object sender, RoutedEventArgs e)
        {
            ProfileInfo();
        }

        private void EmployeeBT_Click(object sender, RoutedEventArgs e)
        {
            FrameUser.NavigationService.Navigate(new Uri("Pages\\PagesUser\\EmploeeyrsListInfo.xaml", UriKind.RelativeOrAbsolute));
            Collor_Profile.BorderThickness = new Thickness(0, 0, 0, 0);

            Collor_Accessories.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Data.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Employee.BorderThickness = new Thickness(1, 1, 1, 0);
            Collor_Manager.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Tariff.BorderThickness = new Thickness(0, 0, 0, 0);
        }

        private void DataBT_Click(object sender, RoutedEventArgs e)
        {
            FrameUser.NavigationService.Navigate(new Uri("Pages\\PagesUser\\ProfileUser.xaml", UriKind.RelativeOrAbsolute));
            Collor_Profile.BorderThickness = new Thickness(0, 0, 0, 0);

            Collor_Accessories.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Data.BorderThickness = new Thickness(1, 1, 1, 0);
            Collor_Employee.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Manager.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Tariff.BorderThickness = new Thickness(0, 0, 0, 0);
        }

        private void TariffBT_Click(object sender, RoutedEventArgs e)
        {
            FrameUser.NavigationService.Navigate(new Uri("Pages\\PagesUser\\ProfileUser.xaml", UriKind.RelativeOrAbsolute));
            Collor_Profile.BorderThickness = new Thickness(0, 0, 0, 0);

            Collor_Accessories.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Data.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Employee.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Manager.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Tariff.BorderThickness = new Thickness(1, 1, 1, 0);
        }

        private void AccessoriesBT_Click(object sender, RoutedEventArgs e)
        {
            FrameUser.NavigationService.Navigate(new Uri("Pages\\PagesUser\\ProfileUser.xaml", UriKind.RelativeOrAbsolute));
            Collor_Profile.BorderThickness = new Thickness(0, 0, 0, 0);

            Collor_Accessories.BorderThickness = new Thickness(1, 1, 1, 0);
            Collor_Data.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Employee.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Manager.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Tariff.BorderThickness = new Thickness(0, 0, 0, 0);
        }

        private void ManagerBT_Click(object sender, RoutedEventArgs e)
        {
            FrameUser.NavigationService.Navigate(new Uri("Pages\\PagesUser\\ProfileUser.xaml", UriKind.RelativeOrAbsolute));
            Collor_Profile.BorderThickness = new Thickness(0, 0, 0, 0);

            Collor_Accessories.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Data.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Employee.BorderThickness = new Thickness(0, 0, 0, 0);
            Collor_Manager.BorderThickness = new Thickness(1, 1, 1, 0);
            Collor_Tariff.BorderThickness = new Thickness(0, 0, 0, 0);
        }
    }
}
