using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace ADAQ_Loader {
    public partial class FormADAQLoaderPanel : Form {
        public FormADAQLoaderPanel() {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports) {
                comboBoxSerialPortList.Items.Add(port);
            }

            comboBoxSerialPortList.Items.Add("Refresh");
            comboBoxSerialPortList.BackColor = Color.LightPink;
        }

        private void buttonProgram_Click(object sender, EventArgs e) {

            bool loopCtrlFlag = true;

            progressBarLoad.Value = 0;

            serialPortLoader.Write("AT+ERASEAPP\r\n");

            do {
                if (serialPortLoader.BytesToRead > 0) {
                    Console.WriteLine(serialPortLoader.ReadExisting());
                    loopCtrlFlag = false;
                }
            } while (loopCtrlFlag);

            string[] lines = File.ReadAllLines(textBoxFile.Text, Encoding.UTF8);
            int lineCount = 0;
            foreach (string line in lines) {

                ++lineCount;

                Console.WriteLine(line);
                serialPortLoader.Write("AT+WR=" + line + "\r\n");

                loopCtrlFlag = true;

                do {
                    if (serialPortLoader.BytesToRead > 0) {
                        Console.WriteLine(serialPortLoader.ReadExisting());
                        loopCtrlFlag = false;
                    }
                } while (loopCtrlFlag);

                progressBarLoad.Value = 100 * lineCount / lines.Count();
                
            }

            if ( serialPortLoader.IsOpen ) {
                serialPortLoader.Write(textBoxTemp.Text + "\r\n");
            }

            /* Erase program */

            /* Flash update */

            /* Clear bootloader flag */
        }

        private void textBoxFile_Click(object sender, EventArgs e) {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Srec or Mot file|*.srec;*.mot";
            
            if ( file.ShowDialog() == DialogResult.OK ) {
                textBoxFile.Text = file.FileName;
            }
        }

        private void comboBoxSerialPortList_TextChanged(object sender, EventArgs e) {
            if (comboBoxSerialPortList.SelectedItem.ToString() == "Refresh") {

                // Close active serial port
                serialPortLoader.Close();

                // Clear serial port combo box items
                comboBoxSerialPortList.Items.Clear();

                // Refill serial port combo box with active serial port names
                string[] ports = SerialPort.GetPortNames();

                foreach (string port in ports) {
                    comboBoxSerialPortList.Items.Add(port);
                }

                comboBoxSerialPortList.Items.Add("Refresh");
            }
            else if ( comboBoxSerialPortList.SelectedIndex.ToString() != "Select Com Port...") { 
                if ( serialPortLoader.IsOpen ) {

                } else {
                    serialPortLoader.PortName = comboBoxSerialPortList.SelectedItem.ToString();
                    serialPortLoader.Open();
                }
            }
        }

        private void timer100ms_Tick(object sender, EventArgs e) {
            if (serialPortLoader.IsOpen) {
                comboBoxSerialPortList.BackColor = Color.LightGreen;
            }
            else {
                comboBoxSerialPortList.BackColor = Color.LightPink;
            }
        }

        private void buttonJTA_Click(object sender, EventArgs e) {
            bool loopCtrlFlag = true;

            if (serialPortLoader.IsOpen) {
                serialPortLoader.Write("AT+JTA\r\n");
            }

            do {
                if (serialPortLoader.BytesToRead > 0) {
                    Console.WriteLine(serialPortLoader.ReadExisting());
                    loopCtrlFlag = false;
                }
            } while (loopCtrlFlag);
        }

        private void FormADAQLoaderPanel_Load(object sender, EventArgs e) {

        }

        private void buttonBtlFlagClear_Click(object sender, EventArgs e) {
            bool loopCtrlFlag = true;

            if (serialPortLoader.IsOpen) {
                serialPortLoader.Write("AT+BFCLR\r\n");
            }

            do {
                if (serialPortLoader.BytesToRead > 0) {
                    Console.WriteLine(serialPortLoader.ReadExisting());
                    loopCtrlFlag = false;
                }
            } while (loopCtrlFlag);
        }
    }
}
