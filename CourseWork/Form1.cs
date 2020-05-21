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
        List<CommunicationDevice> testList = new List<CommunicationDevice>();
        public Form1()
        {
            InitializeComponent();
            delete_button.Enabled = false;
            edit_button.Enabled = false;
            MobileDevice test1 = new MobileDevice();
            test1.Brand = "test1";
            test1.Model = "test1";
            test1.Description = "nahuy";
            RadioDevice test2 = new RadioDevice();
            test2.Brand = "test2";
            test2.Model = "test2";
            test2.Description = "nahuy";
            SatelliteDevice test3 = new SatelliteDevice();
            test3.Brand = "test3";
            test3.Model = "test3";
            test3.Description = "nahuy";
            BluetoothDevice test4 = new BluetoothDevice();
            test4.Brand = "test4";
            test4.Model = "test4";
            test4.Description = "nahuy";
            WifiDevice test5 = new WifiDevice();
            test5.Brand = "test5";
            test5.Model = "test5";
            test5.Description = "nahuy";
            WifiDevice test6 = new WifiDevice();
            test6.Brand = "test6";
            test6.Model = "test6";
            test6.Description = "nahuy";

            testList.Add(test1);
            testList.Add(test2);
            //testList.Add(test3);
            //testList.Add(test4);
            //testList.Add(test5);
            //testList.Add(test6);

            LoadListViewData(null);
        }

        private void LoadListViewData(List<CommunicationDevice> data)
        {
            devices_listView.Clear();
           
            ImageList imageList = new ImageList();

            imageList.ImageSize = new Size(60, 60);

            devices_listView.LargeImageList = imageList;

            if(data == null)
            {
                for (int i = 0; i < testList.Count; i++)
                {
                    //MessageBox.Show(testList[i].GetType().ToString().Split('.')[2]);
                    imageList.Images.Add(i.ToString(), new Bitmap(testList[i].IconPath != null ? testList[i].IconPath : testList[i].DefaultImagePath));
                    devices_listView.Items.Add(new ListViewItem(testList[i].ToString(), i.ToString()));
                }
            }
            else
            {
                for (int i = 0; i < data.Count; i++)
                {
                    //MessageBox.Show(testList[i].GetType().ToString().Split('.')[2]);
                    imageList.Images.Add(i.ToString(), new Bitmap(data[i].IconPath != null ? data[i].IconPath : data[i].DefaultImagePath));
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
            DeviceForm deviceEditForm = new DeviceForm(null);
            deviceEditForm.saveNewDeviceInfo = new DeviceForm.SaveDevice(saveNewDevice);
            if (deviceEditForm.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Дані не були збережені");
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = devices_listView.FocusedItem.Index;

            DeviceForm deviceEditForm = new DeviceForm(testList[selectedIndex]);
            if(deviceEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadListViewData(null);
                devices_listView.Items[selectedIndex] = new ListViewItem(testList[selectedIndex].ToString(), selectedIndex.ToString());
            }
            else
            {
                MessageBox.Show("Дані не були збережені");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = devices_listView.FocusedItem.Index;
            DialogResult result = MessageBox.Show("Дійсно бажаєте видалити информацію про девайc?\n\nІнформацію буде не можливо відновити", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {               
                testList.RemoveAt(selectedIndex);
                LoadListViewData(null);
                MessageBox.Show("Успішо видалено!");
            }
        }

        private void saveNewDevice(CommunicationDevice deviceInfo)
        {
            testList.Add(deviceInfo);
            LoadListViewData(null);           
        }

        private void bluetoothDevice_button_Click(object sender, EventArgs e)
        {

        }

        private void mobileDevices_button_Click(object sender, EventArgs e)
        {

        }

        private void radioDevices_button_Click(object sender, EventArgs e)
        {

        }

        private void satelliteDevices_button_Click(object sender, EventArgs e)
        {

        }

        private void wifiDevices_button_Click(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {   
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


            List<CommunicationDevice> sortedList = testList.FindAll(device =>
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
    }
}
