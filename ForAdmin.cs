using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace finalotomasyon
{
    public partial class ForAdmin : Form
    {
        public ForAdmin()
        {
            InitializeComponent();
        }
        
        private void ForAdmin_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
            Updatedgv_roleChanged();
        }

        private void Updatedgv_roleChanged() 
        {
            finalGorselEntities vt = new finalGorselEntities();
            var users = vt.Users.ToList();
            dgv_roleChanged.Columns.Clear();

            DataGridViewColumn Column = new DataGridViewColumn();
            dgv_roleChanged.Columns.Add("UserID", "User ID");
            dgv_roleChanged.Columns.Add("UserRoleID", "Role ID");
            dgv_roleChanged.Columns.Add("UserUsername", "Username");
            dgv_roleChanged.Columns.Add("UserName", "Name");
            dgv_roleChanged.Columns.Add("UserSurname", "Surname");

            foreach (var user in users)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.UserID });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.UserRoleID });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.UserUsername });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.UserName });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.UserSurname });

                dgv_roleChanged.Rows.Add(row);
            }
        }

        private void UpdateDataGridView()
        {
            finalGorselEntities vt = new finalGorselEntities();
            var cars = vt.Cars.ToList();
            dgv_car.Columns.Clear();

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Car Image";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_car.Columns.Add(imageColumn);
            dgv_car.Columns.Add("CarID", "ID");
            dgv_car.Columns.Add("CarBrand", "Brand");
            dgv_car.Columns.Add("CarModel", "Model");
            dgv_car.Columns.Add("CarCategory", "Category");
            dgv_car.Columns.Add("CarColor", "Color");
            dgv_car.Columns.Add("CarYear", "Year");
            dgv_car.Columns.Add("CarKm", "Km");
            dgv_car.Columns.Add("CarPrice", "Price");

            foreach (var car in cars)
            {
                DataGridViewRow row = new DataGridViewRow();
                Image image = ByteArrayToImage(car.CarImage);
                DataGridViewImageCell imageCell = new DataGridViewImageCell();
                imageCell.Value = image;
                row.Cells.Add(imageCell);
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarBrand });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarModel });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarCategory });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarColor });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarYear });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarKm });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarPrice });
                dgv_car.Rows.Add(row);
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null)
            {
                Console.WriteLine("byteArray is null.");
                return null;
            }

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image originalImage = Image.FromStream(ms);
                Bitmap resizedImage = new Bitmap(originalImage, new Size(192, 108));
                return resizedImage;
            }
        }

        private void ClearTextBoxes()
        {
            txt_CID.Clear();
            txt_CBrand.Clear();
            txt_CModel.Clear();
            txt_CColor.Clear();
            txt_CKm.Clear();
            txt_CPrice.Clear();
            txt_CYear.Clear();
            txt_CCategory.Clear();
        }

        private void GetCarDetails(int carID)
        {
            finalGorselEntities vt = new finalGorselEntities();

            var car = vt.Cars.FirstOrDefault(c => c.CarID == carID);

            if (car != null)
            {
                txt_CBrand.Text = car.CarBrand;
                txt_CModel.Text = car.CarModel;
                txt_CColor.Text = car.CarColor;
                txt_CKm.Text = car.CarKm;
                txt_CPrice.Text = car.CarPrice;
                txt_CYear.Text = car.CarYear;
                txt_CCategory.Text = car.CarCategory;
            }
            else
            {
                MessageBox.Show("Car not found with the given Car ID.");
                ClearTextBoxes();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string brand = txt_CBrand.Text;
            string model = txt_CModel.Text;
            string color = txt_CColor.Text;
            string km = txt_CKm.Text;
            string price = txt_CPrice.Text;
            string year = txt_CYear.Text;
            string category = txt_CCategory.Text;

            metots.AddCar(brand, model, color, km, price, year, category);
            UpdateDataGridView();
            ClearTextBoxes();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_CID.Text, out int carID))
            {
                string brand = txt_CBrand.Text;
                string model = txt_CModel.Text;
                string color = txt_CColor.Text;
                string km = txt_CKm.Text;
                string price = txt_CPrice.Text;
                string year = txt_CYear.Text;
                string category = txt_CCategory.Text;

                metots.UpdateCar(carID, brand, model, color, km, price, year, category);
            }
            else
            {
                MessageBox.Show("Please enter a valid Car ID for update.");
            }
            UpdateDataGridView();
            ClearTextBoxes();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_CID.Text, out int carID))
            {
                metots.DeleteCar(carID);
            }
            else
            {
                MessageBox.Show("Please enter a valid Car ID for deletion.");
            }
            UpdateDataGridView();
            ClearTextBoxes();
        }

        private void btn_BringCar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_CID.Text, out int carID))
            {
                GetCarDetails(carID);
            }
            else
            {
                MessageBox.Show("Please enter a valid Car ID.");
            }
        }

        private void btn_UploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] imageData;
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            imageData = br.ReadBytes((int)fs.Length);
                        }
                    }
                    if (int.TryParse(txt_CID.Text, out int carID))
                    {
                        metots.UpdateCarImage(carID, imageData);
                       
                        MessageBox.Show("Image uploaded successfully.");
                        UpdateDataGridView();
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Car ID before uploading an image.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error uploading image: {ex.Message}");
                }
            }
        }

        private void btn_Rolechange_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Rolechange.Text, out int UserID))
            {
                int RoleID = Convert.ToInt32(cbb_Rolechange.SelectedItem);

                metots.RoleUpdate(UserID, RoleID);
            }
            else
            {
                MessageBox.Show("Please enter a valid User ID for update.");
            }
            Updatedgv_roleChanged();
            txt_Rolechange.Clear();
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Rolechange.Text, out int UserID))
            {
                metots.DeleteUser(UserID);
            }
            else
            {
                MessageBox.Show("Please enter a valid User ID for Delete.");
            }
            Updatedgv_roleChanged();
            txt_Rolechange.Clear();
        }
    }
}