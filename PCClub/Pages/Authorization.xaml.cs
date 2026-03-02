using PCClub.DataBase;
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
    public partial class Authorization : Page
    {
        public static int _userId;
        public static int _userRole;
        public Authorization()
        {
            InitializeComponent();
        }

        private bool IsInput()
        {
            if(LoginTB.Text == string.Empty || LoginTB.Text == null)
            {
                MessageBox.Show("Введите данные в поле с логиным!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
                return false; 
            }
            if (PasswordPB.Password == string.Empty || PasswordPB.Password == null)
            {
                MessageBox.Show("Введите данные в поле с паролем!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }

            return true;
        }

        private void AuthorizationBT_Click(object sender, RoutedEventArgs e)
        {
            if(IsInput())
            {
                try
                {
                    using(PCClubeContext context = new PCClubeContext())
                    {
                        var UserCheck = context.Users.Where(x => x.Login == LoginTB.Text 
                                                         && x.Password == PasswordPB.Password)
                                                     .FirstOrDefault();
                        if (UserCheck != null)
                        {
                            Console.WriteLine("В аккаунт удалось войти!");
                            _userId = UserCheck.Id;
                            _userRole = UserCheck.RoleId;
                            this.NavigationService.Navigate(new Uri("Pages/Profile.Xaml", UriKind.RelativeOrAbsolute));
                        }
                        else
                        {
                            MessageBox.Show("Не удалось войти в аккаунт!", "Ошибка", MessageBoxButton.OK,MessageBoxImage.Information);
                            Console.WriteLine("В аккаунт не удалось войти!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: \n{ex.Message}", "Ошибка связана с авторизацией!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
