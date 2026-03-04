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

namespace PCClub.Pages.PagesUser
{
    /// <summary>
    /// Логика взаимодействия для ProfileUser.xaml
    /// </summary>
    public partial class ProfileUser : Page
    {
        public static bool _is_Click = true;
        public ProfileUser()
        {
            InitializeComponent();
            Info_User();
        }

        public void Info_User()
        {
            using (PCClubeContext context =  new PCClubeContext())
            {
                var UserInfo = context.Users.Where(x => x.Id == Authorization._userId).FirstOrDefault();
                if (UserInfo != null)
                {
                    FirstNameTB.Text = UserInfo.FirstName;
                    LastNameTB.Text = UserInfo.LastName;
                    SureNameTB.Text = UserInfo.SureName;
                    BirthDayDP.Text = UserInfo.Birthday.ToString();
                    EmailTB.Text = UserInfo.Email;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены что хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                if (Application.Current.MainWindow is MainWindow mainWindow)
                {
                    mainWindow.MainFrame.NavigationService.Navigate(new Uri("Pages/Authorization.xaml", UriKind.RelativeOrAbsolute));
                }
            }
        }

        public bool Check_Input()
        {
            if(FirstNameTB.Text == null || FirstNameTB.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели имя");
                return false; 
            }
            if(LastNameTB.Text == null || LastNameTB.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели фамилию");
                return false; 
            }
            if(BirthDayDP.Text == null || BirthDayDP.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели дату рождения");
                return false; 
            }
            if(EmailTB.Text == null || EmailTB.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели почту");
                return false; 
            }
            return true; 
        }

        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            //Save Users
            if (_is_Click == false)
            {
                FirstNameTB.IsEnabled = false;
                LastNameTB.IsEnabled = false;
                BirthDayDP.IsEnabled = false;
                EmailTB.IsEnabled = false;
                SureNameTB.IsEnabled = false;
                
                using(PCClubeContext context = new PCClubeContext())
                {
                    if (Check_Input())
                    {
                        var userUpdate = context.Users.Where(x => x.Id == Authorization._userId)
                                                      .FirstOrDefault();
                        if (userUpdate != null)
                        {
                            userUpdate.FirstName = FirstNameTB.Text;
                            userUpdate.LastName = LastNameTB.Text;
                            userUpdate.SureName = SureNameTB.Text;
                            userUpdate.Email = EmailTB.Text;
                            userUpdate.Birthday = BirthDayDP.SelectedDate;

                            context.Users.Update(userUpdate);
                            context.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Возникла ошибка!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }

                _is_Click = true;
            }
            //Edit Users
            else if (_is_Click == true)
            {
                FirstNameTB.IsEnabled = true;
                LastNameTB.IsEnabled = true;
                BirthDayDP.IsEnabled = true;
                EmailTB.IsEnabled = true;
                SureNameTB.IsEnabled = true;

                _is_Click = false;
            }
        }
    }
}
