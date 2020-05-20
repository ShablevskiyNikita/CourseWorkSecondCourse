using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            test1.Description = "nahuy";
            RadioDevice test2 = new RadioDevice();
            test2.Brand = "test2";
            test2.Description = "nahuy";
            SatelliteDevice test3 = new SatelliteDevice();
            test3.Brand = "test3";
            test3.Description = "nahuy";
            BluetoothDevice test4 = new BluetoothDevice();
            test4.Brand = "test4";
            test4.Description = "nahuy";
            WifiDevice test5 = new WifiDevice();
            test5.Brand = "test5";
            test5.Description = "nahuy";
            WifiDevice test6 = new WifiDevice();
            test6.Brand = "test6";
            test6.Description = "nahuy";

            testList.Add(test1);
            testList.Add(test2);
            testList.Add(test3);
            testList.Add(test4);
            testList.Add(test5);
            testList.Add(test6);

            LoadListViewData();
        }

        private void LoadListViewData()
        {
            devices_listView.Clear();
           
            ImageList imageList = new ImageList();

            imageList.ImageSize = new Size(60, 60);

            devices_listView.LargeImageList = imageList;

            for (int i = 0; i < testList.Count;i++)
            {
                imageList.Images.Add(i.ToString(), new Bitmap(testList[i].IconPath));
                devices_listView.Items.Add(new ListViewItem(testList[i].ToShortString(), i.ToString()));              
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
                LoadListViewData();
                devices_listView.Items[selectedIndex] = new ListViewItem(testList[selectedIndex].ToShortString(), selectedIndex.ToString());
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
                LoadListViewData();
                MessageBox.Show("Успішо видалено!");
            }
        }

        private void saveNewDevice(CommunicationDevice deviceInfo)
        {
            testList.Add(deviceInfo);
            LoadListViewData();           
        }
    }
}
