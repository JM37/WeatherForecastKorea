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
    public partial class Chungnam : Form
    {
        public Chungnam()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gyeryong_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4425051000";
            string gongju_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4415033000";
            string geumsan_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4471034000";
            string nonsan_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4423040000";
            string dangjin_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4427031000";
            string brcn_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4418036000";
            string buyeo_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4476035000";
            string seosan_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4421040000";
            string seocheon_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4477033000";
            string asan_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4420040000";
            string yesan_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4481038000";
            string cheonan_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4413132000";
            string chungyang_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4479037000";
            string taean_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4482531000";
            string hongsung_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4480038000"; 

            XmlDocument gyeryong = new XmlDocument();
            XmlDocument gongju = new XmlDocument();
            XmlDocument geumsan = new XmlDocument();
            XmlDocument nonsan = new XmlDocument();
            XmlDocument dangjin = new XmlDocument();
            XmlDocument brcn = new XmlDocument();
            XmlDocument buyeo = new XmlDocument();
            XmlDocument seosan = new XmlDocument();
            XmlDocument seocheon = new XmlDocument();
            XmlDocument asan = new XmlDocument();
            XmlDocument yesan = new XmlDocument();
            XmlDocument cheonan = new XmlDocument();
            XmlDocument chungyang = new XmlDocument();
            XmlDocument taean = new XmlDocument();
            XmlDocument hongsung = new XmlDocument();

            gyeryong.Load(gyeryong_Url);
            gongju.Load(gongju_Url);
            geumsan.Load(geumsan_Url);
            nonsan.Load(nonsan_Url);
            dangjin.Load(dangjin_Url);
            brcn.Load(brcn_Url);
            buyeo.Load(buyeo_Url);
            seosan.Load(seosan_Url);
            seocheon.Load(seocheon_Url);
            asan.Load(asan_Url);
            yesan.Load(yesan_Url);
            cheonan.Load(cheonan_Url);
            chungyang.Load(chungyang_Url);
            taean.Load(taean_Url);
            hongsung.Load(hongsung_Url);

            XmlNodeList gyeryong_node = gyeryong.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gongju_node = gongju.SelectNodes("//channel/item/description/body/data");
            XmlNodeList geumsan_node = geumsan.SelectNodes("//channel/item/description/body/data");
            XmlNodeList nonsan_node = nonsan.SelectNodes("//channel/item/description/body/data");
            XmlNodeList dangjin_node = dangjin.SelectNodes("//channel/item/description/body/data");
            XmlNodeList brcn_node = brcn.SelectNodes("//channel/item/description/body/data");
            XmlNodeList buyeo_node = buyeo.SelectNodes("//channel/item/description/body/data");
            XmlNodeList seosan_node = seosan.SelectNodes("//channel/item/description/body/data");
            XmlNodeList seocheon_node = seocheon.SelectNodes("//channel/item/description/body/data");
            XmlNodeList asan_node = asan.SelectNodes("//channel/item/description/body/data");
            XmlNodeList yesan_node = yesan.SelectNodes("//channel/item/description/body/data");
            XmlNodeList cheonan_node = cheonan.SelectNodes("//channel/item/description/body/data");
            XmlNodeList chungyang_node = chungyang.SelectNodes("//channel/item/description/body/data");
            XmlNodeList taean_node = taean.SelectNodes("//channel/item/description/body/data");
            XmlNodeList hongsung_node = hongsung.SelectNodes("//channel/item/description/body/data");

            if (comboBox1.SelectedIndex == 0)
                foreach (XmlNode node in gyeryong_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 1)
                foreach (XmlNode node in gongju_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 2)
                foreach (XmlNode node in geumsan_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 3)
                foreach (XmlNode node in nonsan_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 4)
                foreach (XmlNode node in dangjin_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 5)
                foreach (XmlNode node in brcn_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 6)
                foreach (XmlNode node in buyeo_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 7)
                foreach (XmlNode node in seosan_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";
                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 8)
                foreach (XmlNode node in seocheon_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 9)
                foreach (XmlNode node in asan_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 10)
                foreach (XmlNode node in yesan_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 11)
                foreach (XmlNode node in cheonan_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 12)
                foreach (XmlNode node in chungyang_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 13)
                foreach (XmlNode node in taean_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
            if (comboBox1.SelectedIndex == 14)
                foreach (XmlNode node in hongsung_node)
                {
                    XmlNode wfKor = node.SelectSingleNode("wfKor");
                    XmlNode temp = node.SelectSingleNode("temp");
                    XmlNode wd = node.SelectSingleNode("wd");
                    XmlNode wdKor = node.SelectSingleNode("wdKor");
                    XmlNode reh = node.SelectSingleNode("reh");

                    label5.Text = wfKor.InnerText;
                    label6.Text = temp.InnerText;
                    label7.Text = wdKor.InnerText + "/" + wd.InnerText;
                    label8.Text = reh.InnerText + "%";

                    if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                    {
                        pictureBox1.Image = Properties.Resources.맑음;
                    }
                    else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                    {
                        pictureBox1.Image = Properties.Resources.흐림;
                    }
                    else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                    {
                        pictureBox1.Image = Properties.Resources.소나기;
                    }
                    else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                    {
                        pictureBox1.Image = Properties.Resources.비;
                    }
                    else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                    {
                        pictureBox1.Image = Properties.Resources.눈;
                    }
                    else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                    {
                        pictureBox1.Image = Properties.Resources.안개;
                    }
                    else if (wfKor.InnerText == "황사")
                    {
                        pictureBox1.Image = Properties.Resources.황사;
                    }
                }
        }
    }
}
