using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using streeplijst_library;

namespace streeplijst
{
    public class ArduinoSerialReader : IDisposable
    {
        private SerialPort _serialPort;
        public String a;
        public String name;
        
        public ArduinoSerialReader(string portName)
        {
            FormList.form1.dBConnect.nameslist();
            _serialPort = new SerialPort(portName);
            _serialPort.Open();
            _serialPort.DataReceived += serialPort_DataReceived;
        }

        public ArduinoSerialReader()
        {
            foreach (string item in System.IO.Ports.SerialPort.GetPortNames())
            {
                Console.WriteLine(item);
                if (item == "COM4" )
                {
                    
                    FormList.form1.dBConnect.nameslist();
                    _serialPort = new SerialPort(item);
                    _serialPort.Open();
                    _serialPort.DataReceived += serialPort_DataReceived;
                    break;
                }
                
            }

        }

        void serialPort_DataReceived(object s, SerialDataReceivedEventArgs e)
        {
            
            a = _serialPort.ReadLine();
            String b = a.Substring(a.Length -2);
            String d = a.Substring(4, 1);
            Console.WriteLine(b);
            try
            {



                if (b == ": " && d == ":")
                {
                    a = a.Substring(a.IndexOf(":") + 1);
                    a = a.Substring(0, a.IndexOf(":"));
                    string[] tag_data = a.Split(' ');
                    Console.WriteLine(tag_data[1]);

                    foreach (Lid lid in FormList.form1.dBConnect.Names.Leden)
                    {
                        if (tag_data[2] == Convert.ToString(lid.Number) && tag_data[2] != "346" && tag_data[2] != "99")
                        {
                            name = lid.Firstname + "\t" + lid.Lastname;
                            FormList.form4.Invoke((MethodInvoker)(() => FormList.form4.Hide()));
                            FormList.form4.Invoke((MethodInvoker)(() => FormList.form2.Hide()));
                            FormList.form4.Invoke((MethodInvoker)(() => FormList.form1.Show()));
                            FormList.form4.Invoke((MethodInvoker)(() => FormList.form1.fullName = name));
                            FormList.form4.Invoke((MethodInvoker)(() => FormList.form1.UpdateText()));
                            FormList.form4.Invoke((MethodInvoker)(() => FormList.form1.timer1.Start()));
                        }
                        else if (tag_data[2] == "99")
                        {
                            FormList.form4.Invoke((MethodInvoker)(() => FormList.form4.Hide()));
                            FormList.form4.Invoke((MethodInvoker)(() => FormList.form2.Hide()));
                            FormList.form4.Invoke((MethodInvoker)(() => FormList.form3.Show()));
                        }
                        else
                        {
                            //Console.WriteLine("no");
                        }
                    }
                }
                else
                {
                    Console.WriteLine(a);
                    d = " ";
                    b = " ";
                }
            }
            catch (Exception)
            {

                Console.WriteLine("An error occurred: '{0}'", e);
            }
            //Console.WriteLine(_serialPort.ReadLine());
        }
        public void Dispose()
        {
            if (_serialPort != null)
            {
                _serialPort.Dispose();
            }
        }
    }
}
