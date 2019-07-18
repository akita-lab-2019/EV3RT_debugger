using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< Updated upstream
=======
using System.IO.Ports;
>>>>>>> Stashed changes
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV3RT_debugger
{
    public partial class Form1 : Form
    {
<<<<<<< Updated upstream
=======
        void CONSOLE_INFO(string str)
        {
            Console.WriteLine("[INFO]  " + str);
        }

        void CONSOLE_ERROR(string str)
        {
            Console.WriteLine("[ERROR] " + str);
        }

>>>>>>> Stashed changes
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // ポートオープン
                serialPort1.Write("1");
                CONSOLE_INFO("Sent start signal.");
            }
            catch (Exception ex)
            {
                CONSOLE_ERROR(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //! 利用可能なシリアルポート名の配列を取得する.
            string[] PortList = SerialPort.GetPortNames();

            cmbPortName.Items.Clear();

            //! シリアルポート名をコンボボックスにセットする.
            foreach (string PortName in PortList)
            {
                cmbPortName.Items.Add(PortName);
            }
            if (cmbPortName.Items.Count > 0)
            {
                cmbPortName.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // ポート名を取得
            var port = cmbPortName.Text.ToString();

            CONSOLE_INFO("Try Conect to " + port + "...");
            
            // serialPortの設定
            serialPort1 = new SerialPort();
            serialPort1.PortName = port;
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Encoding = Encoding.UTF8;
            serialPort1.WriteTimeout = 100000;

            // シリアルポートに接続
            try
            {
                // ポートオープン
                serialPort1.Open();
                CONSOLE_INFO("Connected to " + port + ".");
            }
            catch (Exception ex)
            { 
                CONSOLE_ERROR(ex.Message);
            }
            
        }
>>>>>>> Stashed changes
    }
}
