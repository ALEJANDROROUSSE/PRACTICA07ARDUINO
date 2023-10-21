using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA07ARDUINO
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM5";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            this.FormClosing += CerrandoForm1;
            this.btnAPAGAR.Click += btnAPAGAR_Click;
            this.btnENCENDER.Click += btnENCENDER_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAPAGAR_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void CerrandoForm1(object sender, FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }

        private void btnENCENDER_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }
    }
}
