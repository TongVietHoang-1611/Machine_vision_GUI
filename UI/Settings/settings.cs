using System;
using System.Windows.Forms;

namespace Machine_vision_GUI.UI.Settings
{

    public partial class settings : Form
    {

        private Form1 _form1;
        public settings(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Raise the SettingsSaved event
            _form1.txtIP.Text = txtServerSettings.Text;
            _form1.txtPort.Text = txtPortSettings.Text;
            this.Close(); // Close the settings form after saving
        }


    }
}
