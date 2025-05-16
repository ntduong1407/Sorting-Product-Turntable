using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using SymbolFactoryDotNet;

namespace CSharp_PLC
{
    public partial class Form1 : Form
    {
        Plc PLCSIEMENS;
        byte[] Input = new byte[10]; //mảng tên Input gồm 10 byte, 1 byte = 8 bit

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            PLCSIEMENS = new Plc(CpuType.S71200, NhapSo.Text, 1, 0);
            PLCSIEMENS.Open();
            if (PLCSIEMENS.IsConnected == true) //Kiểm tra trạng thái kết nối
            {
                TrangThai.Text = "Ket noi thanh cong";
                MessageBox.Show("Da ket noi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LedBao.DiscreteValue1 = true; 
                LedBao.DiscreteValue2 = false;
                timer1.Enabled = true; //khởi động timer
                timer1.Interval = 500; //timer1 = 0.5s
            }
            else
            {
                TrangThai.Text = "Ket noi that bai";
                MessageBox.Show("Khong ket noi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LedBao.DiscreteValue2 = true;
                LedBao.DiscreteValue1 = false;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            PLCSIEMENS.Write("I0.0", 1);
            Thread.Sleep(200);
            PLCSIEMENS.Write("I0.0", 0);   // I0.0 lên 1 rồi xuống 0, coi code bên PLC tại sao lại như vậy
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            PLCSIEMENS.Write("I0.1", 0);
            Thread.Sleep(200);

            PLCSIEMENS.Write("I0.1", 1);
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            PLCSIEMENS.Write("I1.4", 1);
            Thread.Sleep(200);

            PLCSIEMENS.Write("I1.4", 0);
        }

        private void ON_OFF(StandardControl sd, bool Value)
        {
            if (Value == true)
            {
                sd.DiscreteValue1 = true;
                sd.DiscreteValue2 = false;
            }
            else if (Value == false)
            {
                sd.DiscreteValue1 = false;
                sd.DiscreteValue2 = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PLCSIEMENS.IsConnected == true)
            {

                Input = PLCSIEMENS.ReadBytes(DataType.Input, 0, 0, 2); //đọc số lượng 2 byte, bắt đầu là byte 0
                /*ON_OFF(led_start, Input[0].SelectBit(0)); //I0.0
                ON_OFF(led_stop, Input[0].SelectBit(1)); //I0.1
                ON_OFF(led_reset, Input[1].SelectBit(4)); //I1.4*/

                ON_OFF(small_sensor, Input[0].SelectBit(2)); //I0.2
                ON_OFF(medium_sensor, Input[0].SelectBit(3)); //I0.3
                ON_OFF(high_sensor, Input[0].SelectBit(4)); //I0.4
            }

            if (PLCSIEMENS.IsConnected == true)
            {
                object objValue1 = PLCSIEMENS.Read("QD34"); //Đọc giá trị số từ địa chỉ %QD34
                int value1 = Convert.ToInt32(objValue1); //Ép kiểu từ object về int
                high_number_product.Text = value1.ToString(); //Gán giá trị số đọc được cho thuộc tính Text của Label

                object objValue2 = PLCSIEMENS.Read("QD38");
                int value2 = Convert.ToInt32(objValue2);
                medium_number_product.Text = value2.ToString();

                object objValue3 = PLCSIEMENS.Read("QD42");
                int value3 = Convert.ToInt32(objValue3);
                small_number_product.Text = value3.ToString();
            }
        }

        private void NhapSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
