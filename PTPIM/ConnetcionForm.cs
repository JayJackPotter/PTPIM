﻿using System;
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
    }
}