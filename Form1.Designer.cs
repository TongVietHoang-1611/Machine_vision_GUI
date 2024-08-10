namespace Machine_vision_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picStatusPLC = new System.Windows.Forms.PictureBox();
            this.picStatusCognex = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIdFaild = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusPLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusCognex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(753, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ITEM NAME:";
            // 
            // txtNameItem
            // 
            this.txtNameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameItem.Location = new System.Drawing.Point(843, 290);
            this.txtNameItem.Multiline = true;
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.Size = new System.Drawing.Size(219, 27);
            this.txtNameItem.TabIndex = 7;
            this.txtNameItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameItem.TextChanged += new System.EventHandler(this.txtNameItem_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(795, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "TIME:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 510);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 234);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(815, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(843, 375);
            this.txtIP.Multiline = true;
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(219, 24);
            this.txtIP.TabIndex = 20;
            this.txtIP.Text = "192.168.0.134";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(789, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "PORT:";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(843, 415);
            this.txtPort.Multiline = true;
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = true;
            this.txtPort.Size = new System.Drawing.Size(219, 24);
            this.txtPort.TabIndex = 25;
            this.txtPort.Text = "3000";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pieChart
            // 
            this.pieChart.Location = new System.Drawing.Point(1107, 34);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(255, 292);
            this.pieChart.TabIndex = 26;
            this.pieChart.Text = "pieChart1";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1293, 375);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 39);
            this.txtTotal.TabIndex = 28;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "COGNEX";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "PLC";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(25, 161);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(113, 29);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(25, 114);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(113, 29);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(25, 68);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(113, 29);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Location = new System.Drawing.Point(3, 621);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(159, 108);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 732);
            this.panel1.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Tag = "";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(844, 327);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(218, 30);
            this.txtTime.TabIndex = 29;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1107, 375);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // picStatusPLC
            // 
            this.picStatusPLC.Image = ((System.Drawing.Image)(resources.GetObject("picStatusPLC.Image")));
            this.picStatusPLC.Location = new System.Drawing.Point(576, 439);
            this.picStatusPLC.Name = "picStatusPLC";
            this.picStatusPLC.Size = new System.Drawing.Size(138, 39);
            this.picStatusPLC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStatusPLC.TabIndex = 23;
            this.picStatusPLC.TabStop = false;
            // 
            // picStatusCognex
            // 
            this.picStatusCognex.Image = ((System.Drawing.Image)(resources.GetObject("picStatusCognex.Image")));
            this.picStatusCognex.Location = new System.Drawing.Point(285, 439);
            this.picStatusCognex.Name = "picStatusCognex";
            this.picStatusCognex.Size = new System.Drawing.Size(141, 39);
            this.picStatusCognex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStatusCognex.TabIndex = 21;
            this.picStatusCognex.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(210, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(537, 320);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // picCheck
            // 
            this.picCheck.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCheck.InitialImage")));
            this.picCheck.Location = new System.Drawing.Point(831, 34);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(231, 224);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheck.TabIndex = 10;
            this.picCheck.TabStop = false;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // txtIdFaild
            // 
            this.txtIdFaild.Location = new System.Drawing.Point(1182, 479);
            this.txtIdFaild.Multiline = true;
            this.txtIdFaild.Name = "txtIdFaild";
            this.txtIdFaild.Size = new System.Drawing.Size(113, 25);
            this.txtIdFaild.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1406, 756);
            this.Controls.Add(this.txtIdFaild);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picStatusPLC);
            this.Controls.Add(this.picStatusCognex);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusPLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusCognex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picCheck;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picStatusPLC;
        private System.Windows.Forms.PictureBox picStatusCognex;
        private System.Windows.Forms.Label label6;
        private LiveCharts.WinForms.PieChart pieChart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox txtIP;
        public System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txtIdFaild;
    }
}

