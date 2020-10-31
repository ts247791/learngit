using PedestrianSensingRadar.Utility;
using setRadar;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PedestrianSensingRadar
{
    public partial class Frm_main : Form
    {
        //private MessageCenter center;
        private Thread canrec_thread;//CAN数据接收线程
        public ConcurrentQueue<string> cq = new ConcurrentQueue<string>();//存储can数据的队列

        static UInt32 m_devtype = 4;//USBCAN2

        UInt32 m_bOpen = 0;
       

        UInt32[] m_arrdevtype = new UInt32[20];
        public Frm_main()
        {
            InitializeComponent();
            //center.SendMsg+=new MessageCenter.SendMesg()
        }

        private void btn_opencan_Click(object sender, EventArgs e)
        {
            
            if (m_bOpen == 1)
            {
                CanToolsHelper.CloseCan();
                canrec_thread.Abort();
                m_bOpen = 0;
            }
            else
            {
                int ret = CanToolsHelper.OpenCan();
                if (ret == -1)
                {

                    MessageBox.Show("Open USBCAN Failed!", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (ret == -2)
                {
                    MessageBox.Show("USBCAN Init Failed!!", "ERROR"
                        , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (ret == -3)
                {
                    MessageBox.Show("USBCAN Start Failed!", "ERROR"
                        , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                m_bOpen = 1;
                //启动一个CAN数据接收线程
                canrec_thread = new Thread(Rec_data);
                canrec_thread.Start();              
            }  
            btn_opencan.Text = m_bOpen == 1 ? "关闭CAN" : "打开CAN";
            timer_rec.Enabled = m_bOpen == 1 ? true : false;           
        }

        /// <summary>
        /// 摘要：每隔30ms读取一次can数据，并将数据存储到队列中
        /// </summary>
        public void Rec_data()
        {
            string str = "";
            
            while(m_bOpen==1)
            {
                str=CanToolsHelper.CanReceive();
                cq.Enqueue(str);
                Thread.Sleep(30);               
            }         
        }

        private void timer_rec_Tick(object sender, EventArgs e)
        {
            /*
            while (cq.Count > 0)
            {
                string data=null;
                cq.TryDequeue(out data);
                listBox_show.Items.Add(data);
                listBox_show.SelectedIndex = listBox_show.Items.Count - 1;
            }
            */
        }

        private void btn_message_Click(object sender, EventArgs e)
        {
            MessageCenter center = new MessageCenter(cq);
            center.Show();           
        }

        private void pb_area_Paint_1(object sender, PaintEventArgs e)
        {
            CreateCoordinateSystem coordinate = new CreateCoordinateSystem();

            try
            {
                coordinate.drawCoordinate(e.Graphics);
                /*
                if (lane != null)
                    lane.DrawLane(e.Graphics);
                    */
            }
            catch (Exception exp)
            {
                System.Console.WriteLine(exp.Message);
            }

        }

        private void pb_area_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
