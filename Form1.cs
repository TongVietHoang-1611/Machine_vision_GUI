﻿using Microsoft.Web.WebView2.WinForms;
using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using System.IO;
using Machine_vision_GUI.utils;
using LiveCharts.Wpf;
using LiveCharts;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Media;
using Machine_vision_GUI.Properties;
using Machine_vision_GUI.UI.Settings;

namespace Machine_vision_GUI
{
    public partial class Form1 : Form
    {
        private WebView2 webView2;
        private bool isConnected = false;
        private bool isRunning = false;
        private int count_faild = 0;
        private int count_passed = 0;
        private int count_total = 0;
        SimpleTcpClient client;


        ConnectSql db = new ConnectSql();

        public Form1()
        {
            InitializeComponent();
            webView2 = new WebView2();
            webView2.Dock = DockStyle.Fill;

/*            txtIP.KeyPress += new KeyPressEventHandler(txtIP_KeyPress);
            txtIP.Leave += new EventHandler(txtIP_Leave);

            txtPort.KeyPress += new KeyPressEventHandler(txtPort_KeyPress);
            txtPort.Leave += new EventHandler(txtPort_Leave);*/


        }



        private async Task initizated()
        {
            await webView2.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initizated();

            webView2.Source = new Uri("http://192.168.0.134:8087/");

        }

        private void InitializePieChart()
        {
            if (pieChart.Series == null)
                pieChart.Series = new LiveCharts.SeriesCollection();

            pieChart.Series.Clear();
            pieChart.Series.Add(new PieSeries
            {
                Title = "Failed",
                Values = new ChartValues<int> { 0 },
                DataLabels = true,
                FontSize = 16,
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)) // Red
            });
            pieChart.Series.Add(new PieSeries
            {
                Title = "Passed",
                Values = new ChartValues<int> { 0 },
                DataLabels = true,
                FontSize = 16,
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(128, 128, 0)) // Green
            });

            pieChart.LegendLocation = LegendLocation.Bottom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;


            InitializePieChart();


            if (File.Exists(Constant.img_path_disconnected))
            {
                picStatusCognex.Image = Image.FromFile(Constant.img_path_disconnected);
                picStatusPLC.Image = Image.FromFile(Constant.img_path_disconnected);
            }

            else
            {
                MessageBox.Show("Image file not found at: " + Constant.img_path_disconnected, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnConnect.Enabled = false;
            picCheck.Image = Image.FromFile(Constant.img_path_NoImg);
            pictureBox4.Image = Image.FromFile(Constant.img_path_NoImg);

        }


        private void UpdateTotal()
        {
            txtTotal.Text = count_total.ToString(); 
        }
        private void UpdatePieChart()
        {
            pieChart.Series[0].Values[0] = count_faild;
            pieChart.Series[1].Values[0] = count_passed;
            pieChart.Refresh(); // Để đảm bảo biểu đồ được vẽ lại
        }



        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameItem.Text) || string.IsNullOrWhiteSpace(txtIP.Text) || string.IsNullOrWhiteSpace(txtPort.Text))
            {
                btnConnect.Enabled = true;
            }

            try
            {
                client.Connect(txtIP.Text, int.Parse(txtPort.Text));
                isConnected = true;

                //MessageBox.Show("Connected to server successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox4.Controls.Add(webView2);
                btnConnect.Enabled = false;
                picStatusCognex.Image = Image.FromFile(Constant.img_path_connected);
                dataGridView1.DataSource = db.LoadData(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnConnect.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnected)
                {
                    throw new InvalidOperationException("Client is not connected");
                }

                client.Disconnect();
                isConnected = false;
                // Change to disconnected image
                picStatusCognex.Image = Image.FromFile(Constant.img_path_disconnected);
                btnConnect.Enabled = true;
                picCheck.Image = Image.FromFile(Constant.img_path_NoImg);


                // Check if webView2.CoreWebView2 is initialized before calling its methods
                if (webView2.CoreWebView2 != null)
                {
                    webView2.CoreWebView2.Stop();
                    webView2.CoreWebView2.Navigate("about:blank");
                    pictureBox4.Controls.Remove(webView2);
                    pictureBox4.Image = Image.FromFile(Constant.img_path_NoImg);
                }

                //MessageBox.Show("Disconnected from server successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Having error, please check again! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNameItem_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu tất cả các TextBox đều không trống và không chỉ chứa khoảng trắng
            if (!string.IsNullOrWhiteSpace(txtNameItem.Text) &&
                !string.IsNullOrWhiteSpace(txtIP.Text) &&
                !string.IsNullOrWhiteSpace(txtPort.Text))
            {
                btnConnect.Enabled = true;
            }
            else
            {
                btnConnect.Enabled = false;
            }
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtMessage.Invoke((MethodInvoker)delegate ()
            {
                txtMessage.Text += e.MessageString;
                count_total++;

                txtTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

                InitBrowser();

                isRunning = true;

                picStatusCognex.Image = Image.FromFile(Constant.img_path_connected);

                string status = e.MessageString.Trim() == "0" ? "failed" : "passed";
                picCheck.Image = Image.FromFile(e.MessageString.Trim() == "0" ? Constant.img_path_faild : Constant.img_path_pass);

                count_faild += e.MessageString.Trim() == "0" ? 1 : 0;
                count_passed += e.MessageString.Trim() == "1" ? 1 : 0;

                UpdatePieChart();
                UpdateTotal();
               
                // Lưu dữ liệu vào cơ sở dữ liệu
                db.AddData( txtNameItem.Text, Convert.ToDateTime(txtTime.Text), status);
                db.UpdateDataGridView(dataGridView1);
                FormatDataGridView();
            });
        }

        private void FormatDataGridView()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                // Căn giữa tên cột (header)
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Căn giữa nội dung của cột
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

            settings form = new settings(this);
            form.ShowDialog();

            // Show the SettingsForm as a dialog
            
        }
/*        private void updateIpPort()
        {
            using (var settingsForm = new Machine_vision_GUI.UI.Settings.settings())
            {
                // Set initial values if needed
                settingsForm.ServerIP = txtIP.Text;
                settingsForm.Port = txtPort.Text;

                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the main form's text boxes with values from the settings form
                    txtIP.Text = settingsForm.ServerIP;
                    txtPort.Text = settingsForm.Port;
                }
            }
        }*/
        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
