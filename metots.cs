using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace finalotomasyon
{
    internal class metots
    {

        public static bool Login(string username, string password)
        {
            finalGorselEntities vt = new finalGorselEntities();
            var user = vt.Users.FirstOrDefault(u => u.UserUsername == username && u.UserPassword == password);

            if (user != null)
            {
                MessageBox.Show("Welcome " + " " + username);
                return true;
            }
            else
            {
                MessageBox.Show("Error!!!");
                return false;
            }
        }

        public static void Register(string name, string surname, string username, string password)
        {
            finalGorselEntities vt = new finalGorselEntities();
            var newUser = new User
            {
                UserName = name,
                UserSurname = surname,
                UserUsername = username,
                UserPassword = password,
                UserRoleID = 2

            };

            vt.Users.Add(newUser);
            vt.SaveChanges();

            if (newUser != null) MessageBox.Show("Registered");
            else MessageBox.Show("Error!!!");
        }

        public static void AddCar(string brand, string model, string color, string km, string price, string year, string category)
        {
            finalGorselEntities vt = new finalGorselEntities();
            

            var newCar = new Car
            {
                CarBrand = brand,
                CarModel = model,
                CarColor = color,
                CarKm = km,
                CarPrice = price,
                CarYear = year,
                CarCategory = category
            };

            vt.Cars.Add(newCar);
            vt.SaveChanges();

            MessageBox.Show("New Car Added.");
        }

        public static void DeleteCar(int carID)
        {
            finalGorselEntities vt = new finalGorselEntities();

            var carToDelete = vt.Cars.FirstOrDefault(c => c.CarID == carID);

            if (carToDelete != null)
            {
                vt.Cars.Remove(carToDelete);
                vt.SaveChanges();
                MessageBox.Show("Car Deleted.");
            }
        }

        
        public static void UpdateCarImage(int carID, byte[] imageData)
        {
            using (finalGorselEntities vt = new finalGorselEntities())
            {
                var car = vt.Cars.FirstOrDefault(c => c.CarID == carID);
                if (car != null)
                {
                    car.CarImage = imageData;
                    vt.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Car not found with the given Car ID.");
                }
            }
        }


        public static void UpdateCar(int carID, string brand, string model, string color, string km, string price, string year, string category)
        {
            finalGorselEntities vt = new finalGorselEntities();

            var carToUpdate = vt.Cars.FirstOrDefault(c => c.CarID == carID);

            if (carToUpdate != null)
            {
                carToUpdate.CarBrand = brand;
                carToUpdate.CarModel = model;
                carToUpdate.CarColor = color;
                carToUpdate.CarKm = km;
                carToUpdate.CarPrice = price;
                carToUpdate.CarYear = year;
                carToUpdate.CarCategory = category;

                vt.SaveChanges();
                MessageBox.Show("Car Updated.");
            }
        }
        public static void RoleUpdate(int UserID, int RoleID)
        {
            finalGorselEntities vt = new finalGorselEntities();
            var userToUpdate = vt.Users.FirstOrDefault(u => u.UserID == UserID);
            if (userToUpdate != null)
            {
                userToUpdate.UserRoleID = RoleID;

                vt.SaveChanges();
                MessageBox.Show("User Role Has Changed.");
            }
        }

        public static void DeleteUser(int UserID)
        {
            finalGorselEntities vt = new finalGorselEntities();
            var userToDelete = vt.Users.FirstOrDefault(u => u.UserID == UserID);
            if (userToDelete != null)
            {
                vt.Users.Remove(userToDelete);
                vt.SaveChanges();
                MessageBox.Show("User Removed.");
            }
        }
    }
}