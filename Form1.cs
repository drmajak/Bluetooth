using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net.Sockets;
BluetoothClient bc = new BluetoothClient(); 

namespace Bluetooth_Connect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Populate_Available_Devices()
        { }
        private void AvailableDevices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            List<Device> devices = new List<Device>();
            BluetoothClient bc = new BluetoothClient();
            BluetoothDeviceInfo[] array = bc.DiscoverDevices();
            int count = array.Length;
            for (int i = 0; i < count; i++)
            {
                Device device = new Device(array[i]);
                devices.Add(device);
                AvailableDevices.Items.Add(device); //Add Devices to List
            }

        }
        public class Device
{
    public string DeviceName { get; set; }
    public bool Authenticated { get; set; }
    public bool Connected { get; set; }
    public ushort Nap { get; set; }
    public uint Sap { get; set; }
    public DateTime LastSeen { get; set; }
    public DateTime LastUsed { get; set; }
    public bool Remembered { get; set; }
 
    public Device(BluetoothDeviceInfo device_info)
    {
        this.Authenticated = device_info.Authenticated;
        this.Connected = device_info.Connected;
        this.DeviceName = device_info.DeviceName;
        this.LastSeen = device_info.LastSeen;
        this.LastUsed = device_info.LastUsed;
        this.Nap = device_info.DeviceAddress.Nap;
        this.Sap = device_info.DeviceAddress.Sap;
        this.Remembered = device_info.Remembered;
    }
 
    public override string ToString()
    {
        return this.DeviceName;
    }
}

        private void Connect_Click(object sender, EventArgs e)
        {
            if(AvailableDevices.SelectedIndex==-1)
            {
                DialogResult DB=MessageBox.Show("Please select a device from the list","Select a Device",MessageBoxButtons.OK);
            }
            else
            {

            }
        }
    }
}
