using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Media;

namespace CS_FE_WC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Now now = new Now();
            now.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Long log = new Long();
            log.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 제작자ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("원재문 & 김성준");
        }

        private void 기상API주소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("http://www.weather.go.kr/weather/main.jsp" + "\n" + "http://www.weather.go.kr/weather/lifenindustry/sevice_rss.jsp");
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SoundPlayer S = new SoundPlayer(@"YTN세계날씨 BGM.wav");
            S.Play();
        }
    }
}
