using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        List<CommunicationDevice> devicesList = new List<CommunicationDevice>();
        bool needToSave = false;
        public Form1()
        {
            InitializeComponent();
            delete_button.Enabled = false;
            edit_button.Enabled = false;
            

            devicesList = CommunicationDevice.ReadDevicesList("devices.xml");

            ToolTip TOOLTIP = new ToolTip();

            TOOLTIP.SetToolTip(search_button, "Пошук");
            TOOLTIP.SetToolTip(add_button, "Додати девайс");
            TOOLTIP.SetToolTip(edit_button, "Редагувати дані");
            TOOLTIP.SetToolTip(delete_button, "Видалити девайс");
            TOOLTIP.SetToolTip(clearFilters_button, "Видалити девайс");
            TOOLTIP.SetToolTip(save_button, "Зберегти зміни");
            TOOLTIP.SetToolTip(info_button, "Інформація про програму");

            LoadListViewData(null);
        }

        private void LoadListViewData(List<CommunicationDevice> data)
        {
            // Очищаємо список із приладами
            devices_listView.Clear();
            // Створюємо список для картинок, що будуть відображені біля опису приладу
            ImageList imageList = new ImageList();
            // Задаємо розміри зображення
            imageList.ImageSize = new Size(60, 60);
            // Задаємо зображення для списку приладів
            devices_listView.LargeImageList = imageList;

            // Якщо мето дне отримав інформацію як аргумент, то у список приладів додаємо весь список, що є
            // Якщо отримав інформмацію, то виводимо її
            if(data == null)
            {
                for (int i = 0; i < devicesList.Count; i++)
                {
                    // Додаємо зображення по відповідному ключу
                    imageList.Images.Add(i.ToString(), new Bitmap(devicesList[i].IconPath != null ? devicesList[i].IconPath : devicesList[i].DefaultImagePath));
                    // Додаємо опис приладу, та ключ до відповідного зображення
                    devices_listView.Items.Add(new ListViewItem(devicesList[i].ToString(), i.ToString()));
                }
            }
            else
            {
                for (int i = 0; i < data.Count; i++)
                {
                    // Додаємо зображення по відповідному ключу
                    imageList.Images.Add(i.ToString(), new Bitmap(data[i].IconPath != null ? data[i].IconPath : data[i].DefaultImagePath));
                    // Додаємо опис приладу, та ключ до відповідного зображення
                    devices_listView.Items.Add(new ListViewItem(data[i].ToString(), i.ToString()));
                }
            }
            
        }

        private void devices_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete_button.Enabled = true;
            edit_button.Enabled = true;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            // Створюємо екземпляр форм, в конструктор передаємо null,  адже збереження буде за допомогою делегату
            DeviceForm deviceEditForm = new DeviceForm(null);
            // Передаємо посилання на метод збереження
            deviceEditForm.saveNewDeviceInfo = new DeviceForm.SaveDevice(saveNewDevice);
            // Якщо дані не були збережені, виводимо відповідне повідомлення
            // Відкриваємо форму
            if (deviceEditForm.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Дані не були збережені");
                // ЗАвершуємо роботу методу
                return;
            }
            // після додавання елементу, система матиме не збережені зміни
            needToSave = true;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            // Перевіряємо чи обрав користувач елемент із списку
            if (devices_listView.FocusedItem == null)
            {
                // Виводимо відповідне повідомлення
                MessageBox.Show("Жоден з елементів не було вибрано");
                return;
            }
            // Знаходимо індекс елемента, що був обраний
            int selectedIndex = devices_listView.FocusedItem.Index;
            // Створюємо екзмепляр форми, і передаємо тоді посилання на обраний об'єкт
            DeviceForm deviceEditForm = new DeviceForm(devicesList[selectedIndex]);
            // Відкриваємо форму
            if (deviceEditForm.ShowDialog() == DialogResult.OK)
            {
                // Виводимо нову інформацію
                LoadListViewData(null);
                needToSave = true;
            }
            else
            {
                // Виводимо відповідне повідомлення
                MessageBox.Show("Дані не були збережені");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            // Перевіряємо чи обрав користувач елеиент із списку
            if (devices_listView.FocusedItem == null)
            {
                // Виводимо відповідне повідомлення
                MessageBox.Show("Жоден з елементів не було вибрано");
                return;
            }
            // Знаходимо індекс елемента, що був обраний
            int selectedIndex = devices_listView.FocusedItem.Index;
            DialogResult result = MessageBox.Show("Дійсно бажаєте видалити информацію про девайc?\n\nІнформацію буде не можливо відновити", "Підвтердження дії", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {               
                devicesList.RemoveAt(selectedIndex);
                LoadListViewData(null);
                needToSave = true;
                // Виводимо відповідне повідомлення
                MessageBox.Show("Успішо видалено!");
            }
        }

        private void saveNewDevice(CommunicationDevice deviceInfo)
        {
            devicesList.Add(deviceInfo);
            LoadListViewData(null);
            needToSave = false;
        }

        private void bluetoothDevice_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BluetoothDevice.TypeDescription, "Bluetooth пристрої");
        }

        private void mobileDevices_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MobileDevice.TypeDescription, "Мобільні пристрої");
        }

        private void radioDevices_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RadioDevice.TypeDescription, "Радіо пристірої");
        }

        private void satelliteDevices_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SatelliteDevice.TypeDescription, "Супутникові пристрої");
        }

        private void wifiDevices_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WiFiDevice.TypeDescription, "WiFi пристрої");
        }

        private void search_button_Click(object sender, EventArgs e)
        {   
            // Зберігаємо усі текстові поля
            string searchBrand = brand_textBox.Text;
            string searchModel = model_textBox.Text;

            List<string> searchCommunicationTypes = new List<string>();
            for (int i = 0; i < communicationTypes_checkedListBox.CheckedItems.Count; i++)
            {
                searchCommunicationTypes.Add(communicationTypes_checkedListBox.CheckedItems[i].ToString());
            }

            double searchDataTranmissionRangeMin;
            double searchDataTranmissionRangeMax;

            double searchWorkingHoursMin;
            double searchWorkingHoursMax;

            double searchMinPrice;
            double searchMaxPrice;

            double searchMinWeight;
            double searchMaxWeight;

            if (!double.TryParse(dataTranmissionRangeMin_textBox.Text, out searchDataTranmissionRangeMin))
            {
               searchDataTranmissionRangeMin = double.MinValue;
            }

            if(!double.TryParse(dataTranmissionRangeMax_textBox.Text, out searchDataTranmissionRangeMax))
            {
               searchDataTranmissionRangeMax = double.MaxValue;
            }

            if (!double.TryParse(workingHoursMin_textBox.Text, out searchWorkingHoursMin))
            {
                searchWorkingHoursMin = double.MinValue;
            }

            if (!double.TryParse(workingHoursMax_textBox.Text, out searchWorkingHoursMax))
            {
                searchWorkingHoursMax = double.MaxValue;
            }

            if (!double.TryParse(priceMin_textBox.Text, out searchMinPrice))
            {
                searchMinPrice = double.MinValue;
            }

            if (!double.TryParse(priceMax_textBox.Text, out searchMaxPrice))
            {
                searchMaxPrice = double.MaxValue;
            }

            if (!double.TryParse(weightMin_textBox.Text, out searchMinWeight))
            {
                searchMinWeight = double.MinValue;
            }

            if (!double.TryParse(weightMax_textBox.Text, out searchMaxWeight))
            {
                searchMaxWeight = double.MaxValue;
            }


            List<CommunicationDevice> sortedList = devicesList.FindAll(device =>
                device.Brand.Contains(searchBrand)
                && device.Model.Contains(searchModel)
                && device.DataTransmissionRange >= searchDataTranmissionRangeMin && device.DataTransmissionRange <= searchDataTranmissionRangeMax
                && device.WorkingHours >= searchWorkingHoursMin && device.WorkingHours <= searchWorkingHoursMax
                && device.Price >= searchMinPrice && device.Price <= searchMaxPrice
                && device.Weight >= searchMinWeight && device.Weight <= searchMaxWeight
                && CheckCommunicationType(searchCommunicationTypes, device)
            );

            if(sortedList.Count != 0)
            {
                LoadListViewData(sortedList);
            }
            else
            {
                MessageBox.Show("Не було знайдено відповідних елементів");
            }
            
        }

        private bool CheckCommunicationType(List<string> searchCommunicationTypes, CommunicationDevice device)
        {
            if (searchCommunicationTypes.Count == 0) return true;

            for(int i = 0; i< searchCommunicationTypes.Count; i++)
            {
                string deviceType = device.GetType().ToString().Split('.')[2];
                if (deviceType.Substring(0, deviceType.Length - 6) == searchCommunicationTypes[i])
                {
                    return true;
                }
            }

            return false;
        }

        private void clearFilters_button_Click(object sender, EventArgs e)
        {
            brand_textBox.Text = "";
            model_textBox.Text = "";
            dataTranmissionRangeMin_textBox.Text = "";
            dataTranmissionRangeMax_textBox.Text = "";
            workingHoursMin_textBox.Text = "";
            workingHoursMax_textBox.Text = "";
            for (int i = 0; i < communicationTypes_checkedListBox.Items.Count; i++)
                communicationTypes_checkedListBox.SetItemCheckState(i, CheckState.Unchecked);
            priceMin_textBox.Text = "";
            priceMax_textBox.Text = "";
            weightMin_textBox.Text = "";
            weightMax_textBox.Text = "";
            LoadListViewData(null);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                CommunicationDevice.WriteDevicesToFile("devices.xml", devicesList);
            }
            catch(Exception exception)
            {
                MessageBox.Show("Помилка збереження, спробуйте ще раз", $"{exception.Message}");
                return;
            }
            MessageBox.Show("Дані були успішно збережені!", "Збереження");
            needToSave = false;
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Даний програмний продукт виступає як система обліку пристроїв з безпровідними засобами комунікації\n" +
                "На даному етапі програма підтримує наявність пристроїв із такими типами комунікації:\n" +
                "1. Bluetooth\n" +
                "2. WiFI\n" +
                "3. Радіо(Radio)\n" +
                "4. Satellite(супутниковий)\n" +
                "5. Мобільний(Mobile)\n\n" +
                "Даний програмний продукт підтримує такі функції:\n" +
                "1. Створення(додавання) нового девайс у систему\n" +
                "2. Редагування інформації про створений девайс\n" +
                "3. Видалення девайса із системи\n" +
                "4. Збереження усіх даних у XML файл\n" +
                "Для зручності у використанні на лівій стороні початкової вкладки наявні фільтра для пошуку девайсів за відповідними критеріями",  "Інформація про програму");
        }

        private void dataTranmissionRangeMin_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$|^\d+,\d+$");
            if (!regexGroupFormat.IsMatch(dataTranmissionRangeMin_textBox.Text))
            {
                if(dataTranmissionRangeMin_textBox.Text != "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Ви повинні ввести чисо, вигляду 100 або 100,10");
                }               
            }
        }

        private void dataTranmissionRangeMax_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$|^\d+,\d+$");
            if (!regexGroupFormat.IsMatch(dataTranmissionRangeMax_textBox.Text))
            {
                if(dataTranmissionRangeMin_textBox.Text != "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Ви повинні ввести чисо, вигляду 100 або 100,10");
                }
            }
        }

        private void workingHoursMin_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$|^\d+,\d+$");
            if (!regexGroupFormat.IsMatch(workingHoursMin_textBox.Text))
            {
                if(workingHoursMin_textBox.Text != "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Ви повинні ввести чисо, вигляду 100 або 100,10"); 
                }                
            }
        }

        private void workingHoursMax_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$|^\d+,\d+$");
            if (!regexGroupFormat.IsMatch(workingHoursMax_textBox.Text))
            {
                if(workingHoursMax_textBox.Text != "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Ви повинні ввести чисо, вигляду 100 або 100,10");
                }               
            }
        }

        private void priceMin_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$|^\d+,\d+$");
            if (!regexGroupFormat.IsMatch(priceMin_textBox.Text))
            {
                if (priceMin_textBox.Text != "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Ви повинні ввести чисо, вигляду 100 або 100,10");
                }
            }
        }

        private void priceMax_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$|^\d+,\d+$");
            if (!regexGroupFormat.IsMatch(priceMax_textBox.Text))
            {
                if(priceMax_textBox.Text != "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Ви повинні ввести чисо, вигляду 100 або 100,10");
                }
            }
        }

        private void weightMin_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$|^\d+,\d+$");
            if (!regexGroupFormat.IsMatch(weightMin_textBox.Text))
            {
                if(weightMin_textBox.Text != "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Ви повинні ввести чисо, вигляду 100 або 100,10");
                }
            }
        }

        private void weightMax_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$|^\d+,\d+$");
            if (!regexGroupFormat.IsMatch(weightMax_textBox.Text))
            {
                if(weightMax_textBox.Text != "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Ви повинні ввести чисо, вигляду 100 або 100,10");
                }
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(needToSave)
            {
                DialogResult result = MessageBox.Show("У вас є незбережені зміни, бажаєте зберегти їх?", "Збереження змін", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        CommunicationDevice.WriteDevicesToFile("devices.xml", devicesList);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Помилка збереження, спробуйте ще раз", $"{exception.Message}");
                        return;
                    }
                    MessageBox.Show("Дані були успішно збережені!", "Збереження");
                }
            }
        }
    }
}
