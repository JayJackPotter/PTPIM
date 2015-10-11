using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace PTPIM
{
    public partial class ConnetcionForm : Form
    {
        private UdpClient sendClient;
        private UdpClient recvClient;
        public ConnetcionForm()
        {
            InitializeComponent();
        }

        private void point2_Click(object sender, EventArgs e)
        {

        }

        private void point1_Click(object sender, EventArgs e)
        {

        }

        private void IP1_TextChanged(object sender, EventArgs e)
        {

            if (255 >= Int32.Parse(IP1.Text) && Int32.Parse(IP1.Text )<= 0)
            {
                IP.Address.ipAddress1 = Convert.ToByte(IP1.Text);
            }
            

        }
        public static class IP
        {   public  static bool numberOnly
            {
            //我还是不会怎么建一个方法然后在别的textbox里调用= =
            //需要一个方法限制ip Textbox里只能输入数字= =
            //private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
            //{
            //  if(e.KeyChar!='\b')//这是允许输入退格键
            //  {
            //      if((e.KeyChar<'0')||(e.KeyChar>'9'))//这是允许输入0-9数字
            //      {
            //      e.Handled = true;
            //      }
            //  }
            //}
            //我就是不喜欢用多行注释你打我啊= =

            }
            public static class Address
            {
                public static byte ipAddress1 = new byte();
                public static byte ipAddress2 = new byte();
                public static byte ipAddress3 = new byte();
                public static byte ipAddress4 = new byte();
            
            }

        }

        private void IP2_TextChanged(object sender, EventArgs e)
        {
            IP.Address.ipAddress2 = Convert.ToByte(IP2.Text);
        }

        private void IP3_TextChanged(object sender, EventArgs e)
        {
            IP.Address.ipAddress3 = Convert.ToByte(IP3.Text);
        }

        private void IP4_TextChanged(object sender, EventArgs e)
        {
            IP.Address.ipAddress4 = Convert.ToByte(IP4.Text);
        }

        private void nickname_TextChanged(object sender, EventArgs e)
        {

        }
    
    }
}
