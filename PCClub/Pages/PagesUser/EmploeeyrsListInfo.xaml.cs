using PCClub.DataBase;
using PCClub.DataBase.Tables;
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

namespace PCClub.Pages.PagesUser
{
    /// <summary>
    /// Логика взаимодействия для EmploeeyrsListInfo.xaml
    /// </summary>
    public partial class EmploeeyrsListInfo : Page
    {
        public EmploeeyrsListInfo()
        {
            InitializeComponent();
            ListUsers();
            Color_Info();
        }

        private void Color_Info()
        {
        }

        private void ListUsers()
        {
            using(PCClubeContext context = new PCClubeContext())
            {
                DGInfo.ItemsSource = context.Users.Where(x => x.RoleId == 3).ToList();
            }
        }

        private void SearchBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBT_Click(object sender, RoutedEventArgs e)
        {
            using(PCClubeContext context = new PCClubeContext())
            {
                var deleteUser = DGInfo.SelectedItem as User;
                if (deleteUser != null)
                {
                    var result = MessageBox.Show("Вы уверены что вы хотите удалить пользователя?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information);
                    if (result == MessageBoxResult.Yes)
                    {
                        context.Users.Remove(deleteUser);
                        context.SaveChanges();
                        ListUsers();
                    }
                }
                else
                {
                    MessageBox.Show("Выберите пользователя", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void EditBT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
