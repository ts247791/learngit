using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedestrianSensingRadar
{
    public partial class MessageCenter : Form
    {
       
        private ConcurrentQueue<string> cq;
        public MessageCenter(ConcurrentQueue<string> cq_message)
        {
            InitializeComponent();
            cq = cq_message;
        }

        public MessageCenter()
        {
            InitializeComponent();
                       
        }

        private void timer_rec_Tick(object sender, EventArgs e)
        {
            while (cq.Count > 0)
            {
                string data = null;
                cq.TryDequeue(out data);
                listBox_showmessage.Items.Add(data);
                listBox_showmessage.SelectedIndex = listBox_showmessage.Items.Count - 1;
            }


        }
    }
}
