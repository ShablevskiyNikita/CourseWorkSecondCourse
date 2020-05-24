using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            // Створюємо екземпляр класу, для вибору файлу
            OpenFileDialog openFile = new OpenFileDialog();
            // Задаємо параметри для вибору файлу
            openFile.Title = "Select a Image";
            openFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            // відкриваємо вікно для вибору файлу
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Перевіряємо чи ми створюємо новий прилад, чи редагуємо створений
                if (creatingNewElement)
                {
                    // Зберегаємо шлях до файлу
                    newDeviceIconLink = openFile.FileName;
                }
                else
                {
                    // Зберегаємо шлях до файлу
                    deviceInfo.IconPath = openFile.FileName;
                }
                // Змінюємо вигляд зображення приладу
                addImage_button.BackgroundImage = Image.FromFile(openFile.FileName);
            }
            else
            {
                // Знищуємо екземпляр классу
                openFile.Dispose();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (!CheckAllFields())
            {
                MessageBox.Show("Вам потрібно заповнити всі поля!");
                return;
            }

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

        private bool CheckAllFields()
        {
            return brand_textBox.Text != "" && model_textBox.Text != ""
                && description_textBox.Text != "" && price_textBox.Text != ""
                && dataTranmissionRange_textBox.Text != "" && workingHours_textBox.Text != ""
                && guaranteeMonth_textBox.Text != "" && guaranteeMonth_textBox.Text != ""
                && signalFrequency_textBox.Text != "" && weight_textBox.Text != "" && (creatingNewElement ? communicationTypes_listBox1.SelectedItem != null : true); 
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

        private void brand_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\w+");
            if (!regexGroupFormat.IsMatch(brand_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Назва тренду повинна складатися із букв, і не може бути пустою!");
            }
        }

        private void model_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\w+");
            if (!regexGroupFormat.IsMatch(model_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Назва тренду повинна складатися із букв, і не може бути пустою!");
            }
        }

        private void description_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\w+");
            if (!regexGroupFormat.IsMatch(description_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Назва тренду повинна складатися із букв, і не може бути пустою!");
            }
        }

        private void price_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$|^\d+,\d+$");
            if (!regexGroupFormat.IsMatch(price_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Ціна повинна бути числом, вигляду 100 або 100,10 і не може бути пустою!");
            }
        }

        private void dataTranmissionRange_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$|^\d+,\d+$");
            if (!regexGroupFormat.IsMatch(dataTranmissionRange_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Радус дії повинен бути числом, вигляду 100 або 100,10 і не може бути пустим!");
            }
        }

        private void workingHours_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$");
            if (!regexGroupFormat.IsMatch(workingHours_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Кількість робочих часів повинна бути цілим числом і не може бути пустим!");
            }
        }

        private void guaranteeMonth_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+");
            if (!regexGroupFormat.IsMatch(guaranteeMonth_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Кількість гарантійних місцяв повинна бути цілим числом!");
            }
        }

        private void signalFrequency_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\w+");
            if (!regexGroupFormat.IsMatch(signalFrequency_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Частота сигналу повинна бути числом, вигляду 100 або 100,10 і не може бути пустою!");
            }
        }

        private void weight_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\w+");
            if (!regexGroupFormat.IsMatch(weight_textBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Назва тренду повинна складатися із букв, і не може бути пустою!");
            }
        }

        private void communicationTypes_listBox1_Validating(object sender, CancelEventArgs e)
        {          
            if (communicationTypes_listBox1.SelectedItem == null)
            {
                e.Cancel = true;
                MessageBox.Show("Ви повинні обрати тип девайсу!");
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10) // The upper right "X" was clicked
            {
                AutoValidate = AutoValidate.Disable; //Deactivate all validations
            }
            base.WndProc(ref m);
        }

        // To capture the "Esc" key
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                AutoValidate = AutoValidate.Disable;
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
