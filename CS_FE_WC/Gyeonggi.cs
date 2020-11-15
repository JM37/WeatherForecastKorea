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
    public partial class Gyeonggi : Form
    {
        public Gyeonggi()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gp_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4182025000";
            string gy_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4128159000";
            string gc_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4129052000";
            string gm_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4121051000";
            string gj_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4161051000";
            string gr_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4131051000";
            string gunpo_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4141062000";
            string gimpo_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4157025300";
            string nyj_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4136053000";
            string ddc_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4125055000";
            string bc_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4119082000";
            string sn_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4113566500";
            string sw_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4111369000";
            string sh_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4139062100";
            string as1_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4127352500";
            string ansung_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4155042000";
            string ay_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4117363000";
            string yj_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4163033000";
            string yp_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4183031000";
            string yuju_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4167025000";
            string yc_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4180031000";
            string os_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4137053000";
            string yi_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4146352000";
            string uw_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4143051000";
            string ujb_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4115059500";
            string ic_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4150053000";
            string pj_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4148035000";
            string pt_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4122033000";
            string pc_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=41650330000";
            string hn_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4145058000";
            string hs_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4159056000";

            XmlDocument gp = new XmlDocument();
            XmlDocument gy = new XmlDocument();
            XmlDocument gc = new XmlDocument();
            XmlDocument gm = new XmlDocument();
            XmlDocument gj = new XmlDocument();
            XmlDocument gr = new XmlDocument();
            XmlDocument gunpo = new XmlDocument();
            XmlDocument gimpo = new XmlDocument();
            XmlDocument nyj = new XmlDocument();
            XmlDocument ddc = new XmlDocument();
            XmlDocument bc = new XmlDocument();
            XmlDocument sn = new XmlDocument();
            XmlDocument sw = new XmlDocument();
            XmlDocument sh = new XmlDocument();
            XmlDocument as1 = new XmlDocument();
            XmlDocument ansung = new XmlDocument();
            XmlDocument ay = new XmlDocument();
            XmlDocument yj = new XmlDocument();
            XmlDocument yp = new XmlDocument();
            XmlDocument yuju = new XmlDocument();
            XmlDocument yc = new XmlDocument();
            XmlDocument os = new XmlDocument();
            XmlDocument yi = new XmlDocument();
            XmlDocument uw = new XmlDocument();
            XmlDocument ujb = new XmlDocument();
            XmlDocument ic = new XmlDocument();
            XmlDocument pj = new XmlDocument();
            XmlDocument pt = new XmlDocument();
            XmlDocument pc = new XmlDocument();
            XmlDocument hn = new XmlDocument();
            XmlDocument hs = new XmlDocument();

            gp.Load(gp_Url);
            gy.Load(gy_Url);
            gc.Load(gc_Url);
            gm.Load(gm_Url);
            gj.Load(gj_Url);
            gr.Load(gr_Url);
            gunpo.Load(gunpo_Url);
            gimpo.Load(gimpo_Url);
            nyj.Load(nyj_Url);
            ddc.Load(ddc_Url);
            bc.Load(bc_Url);
            sn.Load(sn_Url);
            sw.Load(sw_Url);
            sh.Load(sh_Url);
            as1.Load(as1_Url);
            ansung.Load(ansung_Url);
            ay.Load(ay_Url);
            yj.Load(yj_Url);
            yp.Load(yp_Url);
            yuju.Load(yuju_Url);
            yc.Load(yc_Url);
            os.Load(os_Url);
            yi.Load(yi_Url);
            uw.Load(uw_Url);
            ujb.Load(ujb_Url);
            ic.Load(ic_Url);
            pj.Load(pj_Url);
            pt.Load(pt_Url);
            pc.Load(pc_Url);
            hn.Load(hn_Url);
            hs.Load(hs_Url);

            XmlNodeList gp_node = gp.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gy_node = gy.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gc_node = gc.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gm_node = gm.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gj_node = gj.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gr_node = gr.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gunpo_node = gunpo.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gimpo_node = gimpo.SelectNodes("//channel/item/description/body/data");
            XmlNodeList nyj_node = nyj.SelectNodes("//channel/item/description/body/data");
            XmlNodeList ddc_node = ddc.SelectNodes("//channel/item/description/body/data");
            XmlNodeList bc_node = bc.SelectNodes("//channel/item/description/body/data");
            XmlNodeList sn_node = sn.SelectNodes("//channel/item/description/body/data");
            XmlNodeList sw_node = sw.SelectNodes("//channel/item/description/body/data");
            XmlNodeList sh_node = sh.SelectNodes("//channel/item/description/body/data");
            XmlNodeList as1_node = as1.SelectNodes("//channel/item/description/body/data");
            XmlNodeList ansung_node = ansung.SelectNodes("//channel/item/description/body/data");
            XmlNodeList ay_node = ay.SelectNodes("//channel/item/description/body/data");
            XmlNodeList yj_node = yj.SelectNodes("//channel/item/description/body/data");
            XmlNodeList yp_node = yp.SelectNodes("//channel/item/description/body/data");
            XmlNodeList yuju_node = yuju.SelectNodes("//channel/item/description/body/data");
            XmlNodeList yc_node = yc.SelectNodes("//channel/item/description/body/data");
            XmlNodeList os_node = os.SelectNodes("//channel/item/description/body/data");
            XmlNodeList yi_node = yi.SelectNodes("//channel/item/description/body/data");
            XmlNodeList uw_node = uw.SelectNodes("//channel/item/description/body/data");
            XmlNodeList ujb_node = ujb.SelectNodes("//channel/item/description/body/data");
            XmlNodeList ic_node = ic.SelectNodes("//channel/item/description/body/data");
            XmlNodeList pj_node = pj.SelectNodes("//channel/item/description/body/data");
            XmlNodeList pt_node = pt.SelectNodes("//channel/item/description/body/data");
            XmlNodeList pc_node = pc.SelectNodes("//channel/item/description/body/data");
            XmlNodeList hn_node = hn.SelectNodes("//channel/item/description/body/data");
            XmlNodeList hs_node = hs.SelectNodes("//channel/item/description/body/data");

            if (comboBox1.SelectedIndex == 0)
                foreach (XmlNode node in gp_node)
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
                foreach (XmlNode node in gy_node)
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
                foreach (XmlNode node in gc_node)
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
                foreach (XmlNode node in gm_node)
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
                foreach (XmlNode node in gj_node)
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
                foreach (XmlNode node in gr_node)
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
                foreach (XmlNode node in gunpo_node)
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
                foreach (XmlNode node in gimpo_node)
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
                foreach (XmlNode node in nyj_node)
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
                foreach (XmlNode node in ddc_node)
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
                foreach (XmlNode node in bc_node)
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
                foreach (XmlNode node in sn_node)
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
                foreach (XmlNode node in sw_node)
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
                foreach (XmlNode node in sh_node)
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
                foreach (XmlNode node in as1_node)
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
            if (comboBox1.SelectedIndex == 15)
                foreach (XmlNode node in ansung_node)
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
            if (comboBox1.SelectedIndex == 16)
                foreach (XmlNode node in ay_node)
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
            if (comboBox1.SelectedIndex == 17)
                foreach (XmlNode node in yj_node)
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
            if (comboBox1.SelectedIndex == 18)
                foreach (XmlNode node in yp_node)
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
            if (comboBox1.SelectedIndex == 19)
                foreach (XmlNode node in yuju_node)
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
            if (comboBox1.SelectedIndex == 20)
                foreach (XmlNode node in yc_node)
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
            if (comboBox1.SelectedIndex == 21)
                foreach (XmlNode node in os_node)
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
            if (comboBox1.SelectedIndex == 22)
                foreach (XmlNode node in yi_node)
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
            if (comboBox1.SelectedIndex == 23)
                foreach (XmlNode node in uw_node)
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
            if (comboBox1.SelectedIndex == 24)
                foreach (XmlNode node in ujb_node)
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
            if (comboBox1.SelectedIndex == 25)
                foreach (XmlNode node in ic_node)
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
            if (comboBox1.SelectedIndex == 26)
                foreach (XmlNode node in pj_node)
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
            if (comboBox1.SelectedIndex == 27)
                foreach (XmlNode node in pt_node)
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
            if (comboBox1.SelectedIndex == 28)
                foreach (XmlNode node in pc_node)
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
            if (comboBox1.SelectedIndex == 29)
                foreach (XmlNode node in hn_node)
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
            if (comboBox1.SelectedIndex == 30)
                foreach (XmlNode node in hs_node)
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
