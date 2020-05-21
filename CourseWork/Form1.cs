﻿using CourseWork.Models;
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
                for (int i = 0; i < devicesList.Count; i++)
                {
                    imageList.Images.Add(i.ToString(), new Bitmap(devicesList[i].IconPath != null ? devicesList[i].IconPath : devicesList[i].DefaultImagePath));
                    devices_listView.Items.Add(new ListViewItem(devicesList[i].ToString(), i.ToString()));
                }
            }
            else
            {
                for (int i = 0; i < data.Count; i++)
                {
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
            if(devices_listView.FocusedItem == null)
            {
                MessageBox.Show("Жоден з елементів не було вибрано");
                return;
            }
            int selectedIndex = devices_listView.FocusedItem.Index;

            DeviceForm deviceEditForm = new DeviceForm(devicesList[selectedIndex]);
            if(deviceEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadListViewData(null);
                devices_listView.Items[selectedIndex] = new ListViewItem(devicesList[selectedIndex].ToString(), selectedIndex.ToString());
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
                devicesList.RemoveAt(selectedIndex);
                LoadListViewData(null);
                MessageBox.Show("Успішо видалено!");
            }
        }

        private void saveNewDevice(CommunicationDevice deviceInfo)
        {
            devicesList.Add(deviceInfo);
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
            CommunicationDevice.WriteDevicesToFile("devices.xml", devicesList);
        }
    }
}
