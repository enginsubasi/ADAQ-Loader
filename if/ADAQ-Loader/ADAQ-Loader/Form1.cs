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

            if (!serialPortLoader.IsOpen) {
                MessageBox.Show("Select serial port!");
                return;
            }

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Srec or Mot file|*.srec;*.mot";

            if (file.ShowDialog() == DialogResult.OK) {
                
            } else {
                MessageBox.Show("Select valid file!");
                return;
            }

            /* Erase program */
            serialPortLoader.Write("AT+ERASEAPP\r\n");

            do {
                if (serialPortLoader.BytesToRead > 0) {
                    Console.WriteLine(serialPortLoader.ReadExisting());
                    loopCtrlFlag = false;
                }
            } while (loopCtrlFlag);

            /* Flash update */
            string[] lines = File.ReadAllLines(file.FileName, Encoding.UTF8);
            int lineCount = 0;
            foreach (string line in lines) {

                ++lineCount;

                Console.WriteLine(line);
                serialPortLoader.Write("AT+WR=" + line + "\r\n");

                loopCtrlFlag = true;

                do {
                    if (serialPortLoader.BytesToRead > 0) {
                        string readedStringFromSerialPort = serialPortLoader.ReadExisting();
                        Console.WriteLine(readedStringFromSerialPort);
                        loopCtrlFlag = false;

                        if (readedStringFromSerialPort!="OK\r\n") {
                            MessageBox.Show("File write problem!");
                            return;
                        }
                    }
                } while (loopCtrlFlag);

                progressBarLoad.Value = 100 * lineCount / lines.Count();
                
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

                    bool loopCtrlFlag = true;

                    if (serialPortLoader.IsOpen) {
                        serialPortLoader.Write("AT+WHOAMI\r\n");

                        do {
                            if (serialPortLoader.BytesToRead > 0) {
                                if(serialPortLoader.ReadExisting()== "ADAQ Bootloader\r\n") {

                                } else {
                                    serialPortLoader.Close();
                                    MessageBox.Show("ADAQ-Bootloader is not connected to "+serialPortLoader.PortName);
                                }
                                loopCtrlFlag = false;
                            }
                        } while (loopCtrlFlag);
                    }
                }
            }
        }

        private void timer100ms_Tick(object sender, EventArgs e) {
            if (serialPortLoader.IsOpen) {
                comboBoxSerialPortList.BackColor = Color.LightGreen;

                buttonProgram.Enabled = true;
                progressBarLoad.Enabled = true;
                buttonJTA.Enabled = true;
                buttonBtlFlagClear.Enabled = true;
                buttonEnterBtl.Enabled = true;
                buttonInfo.Enabled = true;
                buttonVer.Enabled = true;
                buttonWho.Enabled = true;
                buttonRepo.Enabled = true;
               
            }
            else {
                comboBoxSerialPortList.BackColor = Color.LightPink;

                buttonProgram.Enabled = false;
                progressBarLoad.Enabled = false;
                buttonJTA.Enabled = false;
                buttonBtlFlagClear.Enabled = false;
                buttonEnterBtl.Enabled = false;
                buttonInfo.Enabled = false;
                buttonVer.Enabled = false;
                buttonWho.Enabled = false;
                buttonRepo.Enabled = false;
            }
        }

        private void buttonJTA_Click(object sender, EventArgs e) {

            if (serialPortLoader.IsOpen) {
                serialPortLoader.Write("AT+JTA\r\n");
            }
        }

        private void FormADAQLoaderPanel_Load(object sender, EventArgs e) {

        }

        private void buttonBtlFlagClear_Click(object sender, EventArgs e) {
            bool loopCtrlFlag = true;

            if (serialPortLoader.IsOpen) {
                serialPortLoader.Write("AT+BFCLR\r\n");
            
                do {
                    if (serialPortLoader.BytesToRead > 0) {
                        Console.WriteLine(serialPortLoader.ReadExisting());
                        loopCtrlFlag = false;
                    }
                } while (loopCtrlFlag);
            }
        }

        private void buttonEnterBtl_Click(object sender, EventArgs e) {
            bool loopCtrlFlag = true;

            if (serialPortLoader.IsOpen) {
                serialPortLoader.Write("AT+BFSET\r\n");
            
                do {
                    if (serialPortLoader.BytesToRead > 0) {
                        Console.WriteLine(serialPortLoader.ReadExisting());
                        loopCtrlFlag = false;
                    }
                } while (loopCtrlFlag);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e) {
            bool loopCtrlFlag = true;
            string readResponse = "";
            if (serialPortLoader.IsOpen) {
                serialPortLoader.Write("AT+INFO\r\n");

                do {
                    if (serialPortLoader.BytesToRead > 0) {
                        readResponse = serialPortLoader.ReadExisting();
                        Console.WriteLine(readResponse);
                        loopCtrlFlag = false;
                    }
                } while (loopCtrlFlag);

                MessageBox.Show(readResponse);
            }
        }

        private void buttonWho_Click(object sender, EventArgs e) {
            bool loopCtrlFlag = true;
            string readResponse = "";
            if (serialPortLoader.IsOpen) {
                serialPortLoader.Write("AT+WHOAMI\r\n");

                do {
                    if (serialPortLoader.BytesToRead > 0) {
                        readResponse = serialPortLoader.ReadExisting();
                        Console.WriteLine(readResponse);
                        loopCtrlFlag = false;
                    }
                } while (loopCtrlFlag);

                MessageBox.Show(readResponse);
            }
        }

        private void buttonVer_Click(object sender, EventArgs e) {
            bool loopCtrlFlag = true;
            string readResponse = "";
            if (serialPortLoader.IsOpen) {
                serialPortLoader.Write("AT+VER\r\n");

                do {
                    if (serialPortLoader.BytesToRead > 0) {
                        readResponse = serialPortLoader.ReadExisting();
                        Console.WriteLine(readResponse);
                        loopCtrlFlag = false;
                    }
                } while (loopCtrlFlag);

                MessageBox.Show(readResponse);
            }
        }

        private void buttonRepo_Click(object sender, EventArgs e) {
            bool loopCtrlFlag = true;
            string readResponse = "";
            if (serialPortLoader.IsOpen) {
                serialPortLoader.Write("AT+REPO\r\n");

                do {
                    if (serialPortLoader.BytesToRead > 0) {
                        readResponse = serialPortLoader.ReadExisting();
                        Console.WriteLine(readResponse);
                        loopCtrlFlag = false;
                    }
                } while (loopCtrlFlag);

                MessageBox.Show(readResponse);
            }
        }
    }
}
