using Machine_vision_GUI.utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Machine_vision_GUI.UI.Image
{
    public partial class ImageFaild : Form
    {
        private Form1 _form1;
        private int selectedId;

        public ImageFaild(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void ImageFaild_Load(object sender, EventArgs e)
        {
            // Get the index of the currently selected row
            int rowIndex = _form1.dataGridView1.CurrentRow.Index;

            // Retrieve the selected ID from the DataGridView
            string selectedIdStr = _form1.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

            // Parse the ID and set it
            if (int.TryParse(selectedIdStr, out selectedId))
            {
                // Format the ID as a three-digit string with leading zeros
                string formattedId = selectedId.ToString("D3");

                // Construct the path to the image file
                string imagePath = $@"F:\api\Image{formattedId}.bmp";

                // Check if the image file exists and load it into the PictureBox
                if (System.IO.File.Exists(imagePath))
                {
                    txtImage.Image = System.Drawing.Image.FromFile(imagePath);
                    txtImage.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust image display as needed

                    string status = _form1.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                    picStatus.Image = System.Drawing.Image.FromFile(status.Trim() == "failed" ? Constant.img_path_faild : Constant.img_path_pass);
                    picStatus.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Image not found at: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle cases where the ID is not a valid integer
                MessageBox.Show("Invalid ID format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu");
            this.Close();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            // Increment the current ID
            selectedId++;

            // Format the new ID as a three-digit string with leading zeros
            string formattedId = selectedId.ToString("D3");

            // Construct the path to the new image file
            string imagePath = $@"F:\api\Image{formattedId}.bmp";

            // Check if the image file exists and load it into the PictureBox
            if (System.IO.File.Exists(imagePath))
            {
                txtImage.Image = System.Drawing.Image.FromFile(imagePath);
                txtImage.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust image display as needed

                // Update status display
                string status = GetStatusForId(selectedId);
                picStatus.Image = System.Drawing.Image.FromFile(status == "failed" ? Constant.img_path_faild : Constant.img_path_pass);
                picStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Image not found at: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            // Decrement the current ID
            selectedId--;

            if (selectedId < 0) // Ensure ID does not go below 0
            {
                MessageBox.Show("No previous images available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Format the new ID as a three-digit string with leading zeros
            string formattedId = selectedId.ToString("D3");

            // Construct the path to the new image file
            string imagePath = $@"F:\api\Image{formattedId}.bmp";

            // Check if the image file exists and load it into the PictureBox
            if (System.IO.File.Exists(imagePath))
            {
                txtImage.Image = System.Drawing.Image.FromFile(imagePath);
                txtImage.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust image display as needed

                // Update status display
                string status = GetStatusForId(selectedId);
                picStatus.Image = System.Drawing.Image.FromFile(status == "failed" ? Constant.img_path_faild : Constant.img_path_pass);
                picStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Image not found at: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetStatusForId(int id)
        {
            // Method to get the status for a given ID from the DataGridView
            foreach (DataGridViewRow row in _form1.dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) == id)
                {
                    return row.Cells[3].Value.ToString().Trim();
                }
            }
            return "pass"; // Default status if not found
        }
    }
}
