using System;
using System.Management;
using UFilesCopy.Base;

namespace UFilesCopy.Code;

public class UsbListener
{
    public static void Start()
    {
        ManagementEventWatcher watcher = new ManagementEventWatcher();
        WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");

        watcher.EventArrived += new EventArrivedEventHandler(USBInserted);
        watcher.Query = query;
        watcher.Start();
    }

    private static void USBInserted(object sender, EventArrivedEventArgs e)
    {
        string driveName = e.NewEvent.Properties["DriveName"].Value.ToString();
        //MessageBox.Show("发现新U盘: " + driveName);
        EventCenter.instance.EventTrigger("USBin",driveName);
    }
}