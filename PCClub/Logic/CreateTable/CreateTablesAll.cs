using PCClub.DataBase;
using PCClub.DataBase.Tables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PCClub.Logic.CreateTable
{
    internal class CreateTablesAll
    {
        public CreateTablesAll()
        {
                    
        }
        public void CreateTableUser(string FirstName, 
                                    string LastName, 
                                    string SureName, 
                                    decimal Salary, 
                                    DateTime BirthDay, 
                                    string Email,
                                    string Login, 
                                    string Password, 
                                    int RoleUser,
                                    string Phone)
        {
            try
            {
                using(PCClubeContext context = new PCClubeContext())
                {
                    var UserCreate = new User();

                    UserCreate.FirstName = FirstName;
                    UserCreate.LastName = LastName;
                    UserCreate.SureName = SureName;
                    UserCreate.Salary = Salary;
                    UserCreate.Birthday = BirthDay;
                    UserCreate.DateRegistration = DateTime.Now;
                    UserCreate.Email = Email;
                    UserCreate.RoleId = RoleUser;
                    UserCreate.Login = Login;
                    UserCreate.Password = Password;
                    UserCreate.Phone = Phone;

                    context.Users.Add(UserCreate);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: \n{ex.Message}", "Ошибка при создании user!", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
        }
    }
}
