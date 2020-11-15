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

namespace CS_FE_WC
{
    public partial class Long : Form
    {
        public Long()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Long_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Url = "http://www.kma.go.kr/weather/forecast/mid-term-rss3.jsp?stnId=108";
            XmlDocument longcast = new XmlDocument();
            longcast.Load(Url);
            if (comboBox1.SelectedIndex == 0)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[1]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[1]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[1]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[1]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[2]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[2]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[2]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[2]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[8]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[8]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[8]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[8]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[12]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[12]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[12]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[12]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[20]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[20]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[20]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[20]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 5)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[18]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[18]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[18]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[18]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 6)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[17]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[17]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[17]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[17]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 7)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[5]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[5]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[5]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[5]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 8)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[3]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[3]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[3]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[3]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 9)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[19]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[19]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[19]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[19]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 10)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[21]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[21]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[21]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[21]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 11)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[13]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[13]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[13]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[13]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 12)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[15]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[15]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[15]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[15]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 13)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[10]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[10]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[10]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[10]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 14)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[11]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[11]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[11]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[11]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
            if (comboBox1.SelectedIndex == 15)
            {
                XmlNodeList long_node1 = longcast.SelectNodes("//channel/item/description/body/location[23]/data[1]");
                foreach (XmlNode node in long_node1)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox1.Text = tmEf.InnerText;
                    label1.Text = wf.InnerText;
                    label2.Text = tmn.InnerText;
                    label3.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }

                XmlNodeList long_node2 = longcast.SelectNodes("//channel/item/description/body/location[23]/data[3]");
                foreach (XmlNode node in long_node2)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox2.Text = tmEf.InnerText;
                    label4.Text = wf.InnerText;
                    label5.Text = tmn.InnerText;
                    label6.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox2.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox2.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox2.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox2.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox2.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox2.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox2.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node3 = longcast.SelectNodes("//channel/item/description/body/location[23]/data[5]");
                foreach (XmlNode node in long_node3)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox3.Text = tmEf.InnerText;
                    label8.Text = wf.InnerText;
                    label11.Text = tmn.InnerText;
                    label13.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox3.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox3.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox3.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox3.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox3.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox3.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox3.Image = Properties.Resources.황사;
                    }
                }
                XmlNodeList long_node4 = longcast.SelectNodes("//channel/item/description/body/location[23]/data[7]");
                foreach (XmlNode node in long_node4)
                {
                    XmlNode tmEf = node.SelectSingleNode("tmEf");
                    XmlNode wf = node.SelectSingleNode("wf");
                    XmlNode tmn = node.SelectSingleNode("tmn");
                    XmlNode tmx = node.SelectSingleNode("tmx");

                    groupBox4.Text = tmEf.InnerText;
                    label16.Text = wf.InnerText;
                    label17.Text = tmn.InnerText;
                    label19.Text = tmx.InnerText;

                    if (wf.InnerText == "맑음" || wf.InnerText == "구름조금")
                    {
                        pictureBox4.Image = Properties.Resources.맑음;
                    }
                    else if (wf.InnerText == "흐림" || wf.InnerText == "구름많음")
                    {
                        pictureBox4.Image = Properties.Resources.흐림;
                    }
                    else if (wf.InnerText == "소나기" || wf.InnerText == "천둥번개")
                    {
                        pictureBox4.Image = Properties.Resources.소나기;
                    }
                    else if (wf.InnerText == "비" || wf.InnerText == "구름많고 비" || wf.InnerText == "구름많고 비/눈" || wf.InnerText == "흐리고 비")
                    {
                        pictureBox4.Image = Properties.Resources.비;
                    }
                    else if (wf.InnerText == "눈" || wf.InnerText == "구름많고 눈" || wf.InnerText == "흐리고 눈")
                    {
                        pictureBox4.Image = Properties.Resources.눈;
                    }
                    else if (wf.InnerText == "구름많고 눈/비" || wf.InnerText == "흐리고 눈/비" || wf.InnerText == "흐리고 비/눈" || wf.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox4.Image = Properties.Resources.가끔_눈_또는_비;
                    }
                    else if (wf.InnerText == "황사")
                    {
                        pictureBox4.Image = Properties.Resources.황사;
                    }
                }
            }
        }
    }
}
