using Dapper;
using Palworld_Breed.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palworld_Breed.pages
{
    public partial class page_paldex : UserControl
    {

        #region Page Functions
        public page_paldex()
        {
            InitializeComponent();
        }

        private void page_paldex_Load(object sender, EventArgs e)
        {           
            cb_paldex.DataSource = CC_SQliteDatabase.listOfPals();
        }
        #endregion


        #region Shared Functions
        

        #endregion

        #region Events
        private void cb_paldex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_paldex.SelectedItem != null)
            {
                // Cast the selected item to the Pal object
                Pal selectedPal = (Pal)cb_paldex.SelectedItem;

                lbl_price.Text = selectedPal.Price.ToString();
                lbl_fire.Text = selectedPal.Flame.ToString();
                lbl_water.Text = selectedPal.Watering.ToString();
                lbl_seeding.Text = selectedPal.Seeding.ToString();
                lbl_electricity.Text = selectedPal.Electricity.ToString();
                lbl_handcraft.Text = selectedPal.Handcraft.ToString();
                lbl_collection.Text = selectedPal.Collection.ToString();
                lbl_oil.Text = selectedPal.Oil_Extraction.ToString();
                lbl_foresting.Text = selectedPal.Deforest.ToString();
                lbl_mining.Text = selectedPal.Mining.ToString();
                lbl_medicine.Text = selectedPal.Medicine.ToString();
                lbl_cooling.Text = selectedPal.Cool.ToString();
                lbl_transport.Text = selectedPal.Transport.ToString();
                lbl_farming.Text = selectedPal.Farm.ToString();

                // Display the image in the PictureBox
                if (selectedPal.Picture != null)
                {
                    // Convert byte array to image
                    Image palImage = CC_Converter.ByteArrayToImage(selectedPal.Picture);
                    
                    // Display the image in the PictureBox
                    pb_pal.Image = palImage;

                    // Optionally adjust the PictureBox's size mode
                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    // If there's no image, clear the PictureBox or set a placeholder image
                    pb_pal.Image = null; // or set to a placeholder image
                }
            }
        }

        private void btn_img_upload_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to allow user to select an image file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set filter options for file dialog (only images)
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image File";

                // If the user selects a file and clicks OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image from file
                    string filePath = openFileDialog.FileName;

                    // Load the image from the file
                    Image selectedImage = Image.FromFile(filePath);

                    // Call the InsertImage method to store the image in the database
                    Pal selectedPal = (Pal)cb_paldex.SelectedItem;
                    CC_SQliteDatabase.InsertImage(selectedPal.ID, selectedImage);

                    // Optionally, you can provide feedback to the user (e.g., message box)
                    //MessageBox.Show("Image successfully saved to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cb_paldex.DataSource = CC_SQliteDatabase.listOfPals();
                }
            }
        }
        #endregion

    }
}
