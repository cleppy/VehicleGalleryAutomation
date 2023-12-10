using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalotomasyon
{
    public partial class ForUser : Form
    {
        public ForUser()
        {
            InitializeComponent();
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            finalGorselEntities vt = new finalGorselEntities();
            var cars = vt.Cars.ToList();
            dgv_User.Columns.Clear();

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Car Image";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_User.Columns.Add(imageColumn);
            dgv_User.Columns.Add("CarID", "ID");
            dgv_User.Columns.Add("CarBrand", "Brand");
            dgv_User.Columns.Add("CarModel", "Model");
            dgv_User.Columns.Add("CarCategory", "Category");
            dgv_User.Columns.Add("CarColor", "Color");
            dgv_User.Columns.Add("CarYear", "Year");
            dgv_User.Columns.Add("CarKm", "Km");
            dgv_User.Columns.Add("CarPrice", "Price");

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
                dgv_User.Rows.Add(row);
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

        private void btn_bring_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_SCarID.Text, out int carID))
            {
                GetCarDetails(carID);
            }
            else
            {
                MessageBox.Show("Please enter a valid Car ID.");
            }
        }

        private void GetCarDetails(int carID)
        {
            finalGorselEntities vt = new finalGorselEntities();
            var car = vt.Cars.FirstOrDefault(c => c.CarID == carID);

            if (car != null)
            {
                // Display car details in labels
                lbl_brand.Text = $"Brand: {car.CarBrand}";
                lbl_model.Text = $"Model: {car.CarModel}";
                lbl_color.Text = $"Color: {car.CarColor}";
                lbl_km.Text = $"Km: {car.CarKm}";
                lbl_price.Text = $"Price: {car.CarPrice}";
                lbl_year.Text = $"Year: {car.CarYear}";
                lbl_Category.Text = $"Category: {car.CarCategory}";

                // Display car image in PictureBox
                if (car.CarImage != null)
                {
                    pictureBox1.Image = ByteArrayToImage(car.CarImage);
                }
                else
                {
                    // If the image is not available, you can set a default image or leave it empty.
                    pictureBox1.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Car not found with the given Car ID.");
                ClearCarDetails();
            }
        }

        private void ClearCarDetails()
        {
            // Clear labels and PictureBox
            lbl_brand.Text = "Brand:";
            lbl_model.Text = "Model:";
            lbl_color.Text = "Color:";
            lbl_km.Text = "Km:";
            lbl_price.Text = "Price:";
            lbl_year.Text = "Year:";
            lbl_Category.Text = "Category:";
            pictureBox1.Image = null;
        }

    }

}
