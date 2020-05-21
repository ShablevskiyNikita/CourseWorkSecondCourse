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
using CourseWork.Models;

namespace CourseWork
{
    public partial class DeviceForm: Form
    {
        public delegate void SaveDevice(CommunicationDevice device);

        public SaveDevice saveNewDeviceInfo;

        CommunicationDevice deviceInfo;

        private bool creatingNewElement = false;

        private string newDeviceIconLink;

        private string addIconPath = @"../../images/control-Icons/AddImage.png";

        public DeviceForm(CommunicationDevice device)
        {                  
            InitializeComponent();
            if (device != null)
            {
                deviceInfo = device;
                FillFormFields();
                addImage_button.BackgroundImage = new Bitmap(deviceInfo.IconPath != null ? deviceInfo.IconPath : addIconPath);
                communicationTypes_listBox1.Visible = false;
                communicationType_label.Visible = false;
            }
            else
            {
                creatingNewElement = true;
                communicationTypes_listBox1.Visible = true;
                communicationType_label.Visible = true;
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
        }

        private void addImage_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select a Image";
            openFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";


            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (creatingNewElement)
                {
                    newDeviceIconLink = openFile.FileName;
                }
                else
                {
                    deviceInfo.IconPath = openFile.FileName;
                }
                addImage_button.BackgroundImage = Image.FromFile(openFile.FileName);
            }
            else
            {
                openFile.Dispose();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (creatingNewElement)
            {
                deviceInfo = CreateDeviceInstance();
                if(newDeviceIconLink != null)
                {
                    deviceInfo.IconPath = newDeviceIconLink;
                }
            }

            deviceInfo.Brand = brand_textBox.Text;
            deviceInfo.Model = model_textBox.Text;
            deviceInfo.Description = description_textBox.Text;
            deviceInfo.Price = double.Parse(price_textBox.Text);
            deviceInfo.DataTransmissionRange = double.Parse(dataTranmissionRange_textBox.Text);
            deviceInfo.WorkingHours = int.Parse(workingHours_textBox.Text);
            deviceInfo.GuaranteeMonth =int.Parse(guaranteeMonth_textBox.Text);
            deviceInfo.Frequency = double.Parse(signalFrequency_textBox.Text);
            deviceInfo.Weight = double.Parse(weight_textBox.Text);

            if(creatingNewElement)
            {
                saveNewDeviceInfo(deviceInfo);
            }

            DialogResult = DialogResult.OK;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FillFormFields()
        {
            brand_textBox.Text = deviceInfo.Brand != null ? deviceInfo.Brand : "";
            model_textBox.Text = deviceInfo.Model != null ? deviceInfo.Model : "";
            description_textBox.Text = deviceInfo.Description != null ? deviceInfo.Description : "";
            price_textBox.Text = deviceInfo.Price.ToString();
            dataTranmissionRange_textBox.Text = deviceInfo.DataTransmissionRange.ToString();
            workingHours_textBox.Text = deviceInfo.WorkingHours.ToString();
            guaranteeMonth_textBox.Text = deviceInfo.GuaranteeMonth.ToString();
            signalFrequency_textBox.Text = deviceInfo.Frequency.ToString();
            weight_textBox.Text = deviceInfo.Weight.ToString();
        }

        private CommunicationDevice CreateDeviceInstance()
        {
            string selectedType = communicationTypes_listBox1.SelectedItem.ToString();

            switch(selectedType)
            {
                case "Bluetooth":
                    return new BluetoothDevice();
                case "Radio":
                    return new RadioDevice();
                case "Mobile":
                    return new MobileDevice();
                case "WiFi":
                    return new WiFiDevice();
                case "Satellite":
                    return new SatelliteDevice();

                default:
                    return null;
            }

        }
    }
}
