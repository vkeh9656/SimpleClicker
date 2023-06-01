using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClicker
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> _dData = new Dictionary<string, string>();
        string strPath = Application.StartupPath + "\\Save.xml";
        CXMLControl _xml = new CXMLControl();

        private double dTick = 0;
        private double dTotal = 0;

        private int i1Add = 1;
        private int i1Level = 1;

        private int i3Add = 0;
        private int i3Level = 0;

        private int i20Add = 0;
        private int i20Level = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists(strPath))
            {
                // Save File이 있을 경우 File Loading
                _dData = _xml.XML_Reader(strPath);

                dTick = double.Parse(_dData[CXMLControl._TICK]);
                dTotal = double.Parse(_dData[CXMLControl._TOTAL]);
                i1Level = int.Parse(_dData[CXMLControl._LEVEL_1]);
                i3Level = int.Parse(_dData[CXMLControl._LEVEL_3]);
                i20Level = int.Parse(_dData[CXMLControl._LEVEL_20]);
                i1Add = int.Parse(_dData[CXMLControl._1_ADD]);
                i3Add = int.Parse(_dData[CXMLControl._3_ADD]);
                i20Add = int.Parse(_dData[CXMLControl._20_ADD]);
            }

            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 100; // 0.1 sec
            timer.Tick += TimerTick;
            timer.Start();
        }



        private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            _dData.Clear();

            _dData.Add(CXMLControl._TICK, dTick.ToString());
            _dData.Add(CXMLControl._TOTAL, dTotal.ToString());
            _dData.Add(CXMLControl._LEVEL_1, i1Level.ToString());
            _dData.Add(CXMLControl._1_ADD, i1Add.ToString());
            
            _dData.Add(CXMLControl._LEVEL_3, i3Level.ToString());
            _dData.Add(CXMLControl._3_ADD, i3Add.ToString());
            
            _dData.Add(CXMLControl._LEVEL_20, i20Level.ToString());
            _dData.Add(CXMLControl._20_ADD, i20Add.ToString());

            _xml.XML_Write(strPath, _dData);
        }

        // 타이머에서 호출 할 Event (Interval 간격마다)
        private void TimerTick(object sender, EventArgs e)
        {
            // Form Thread를 같이 공유하다보니 싱글 스레드로 동작.
            dTick = i1Add + i3Add + i20Add;
            dTotal = dTotal + dTick;

            lblTickPoint.Text = string.Format("{0} (1-{1}), (3-{2}), (20-{3})", dTick.ToString(), i1Level.ToString(), i3Level.ToString(), i20Level.ToString());
            lblTotal.Text = dTotal.ToString();
        }


        // 클릭 이벤트를 이 이벤트 메서드 하나로 몰아줌. Designer.cs 에서 같은 메서드로 통일시켜줌.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button oBtn = sender as Button; // sender 를 Button class로 형 변환

            switch (oBtn.Name)
            {
                case "btn1Add":
                    if(dTotal > 100)
                    {
                        dTotal -= 100;

                        i1Level++;
                        i1Add = 1 * i1Level;
                    }
                    
                    break;
                case "btn3Add":
                    if (dTotal > 500)
                    {
                        dTotal -= 500;

                        i3Level++;
                        i3Add = 3 * i3Level;
                    }
                    break;
                case "btn20Add":
                    if (dTotal > 5000)
                    {
                        dTotal -= 5000;

                        i20Level++;
                        i20Add = 20 * i20Level;
                    }
                    break;
                default:
                    break;
            }
            
        }
    }
}
