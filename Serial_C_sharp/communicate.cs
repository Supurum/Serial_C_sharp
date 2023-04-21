using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Serial_C_sharp
{
    public partial class communicate : Form
    {
        //시리얼 통신 기능 클래스
        Serial serial = Serial.getInstance();
        
        public communicate()
        {
            InitializeComponent();
            Port_Load();
        }
        // 연결포트 리스트 바인드
        public void Port_Load()
        {
            port_sel_comboBox.DataSource = serial.Port_Load();

        }

    }
}
