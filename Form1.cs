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

        public Form1()
        {
            InitializeComponent();

            ///Khởi tạo webview2////
            webView2 = new WebView2();
            webView2.Dock = DockStyle.Fill;
            pictureBox4.Controls.Add(webView2);


        }
        SimpleTcpClient client;
        private async Task initizated()
        {
            await webView2.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initizated();

            webView2.Source = new Uri("http://192.168.0.134:8087/");

        }

        //Các sự kiện thực hiện khi load form
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
                DataLabels = true
            });
            pieChart.Series.Add(new PieSeries
            {
                Title = "Passed",
                Values = new ChartValues<int> { 0 },
                DataLabels = true
            });

            pieChart.LegendLocation = LegendLocation.Bottom;
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

                // Change picCheck image based on received message
                if (e.MessageString.Trim() == "0")
                {
                    picCheck.Image = Image.FromFile(Constant.img_path_faild);
                    count_faild ++;
                }
                else if (e.MessageString.Trim() == "1")
                {
                    picCheck.Image = Image.FromFile(Constant.img_path_pass);
                    count_passed ++;
                }
                UpdatePieChart();
                UpdateTotal();
            });
        }
        private void UpdateTotal()
        {
            txtTotal.Text= count_total.ToString();
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
                btnConnect.Enabled = false;
                picStatusCognex.Image = Image.FromFile(Constant.img_path_connected);
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
                picCheck.Image = null;

                // Check if webView2.CoreWebView2 is initialized before calling its methods
                if (webView2.CoreWebView2 != null)
                {
                    webView2.CoreWebView2.Stop();
                    webView2.CoreWebView2.Navigate("about:blank");
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
         
        private void chartPie_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
