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
    public partial class Daejeon : Form
    {
        public Daejeon()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string daeduk_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=3023052000"; 
            string dong_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=3011062000";
            string seo_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=3017059000";
            string yuseong_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=3020060000";
            string jung_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=3014063000";

            XmlDocument daeduk = new XmlDocument();    
            XmlDocument dong = new XmlDocument();
            XmlDocument seo = new XmlDocument();
            XmlDocument yuseong = new XmlDocument();
            XmlDocument jung = new XmlDocument();

            daeduk.Load(daeduk_Url);
            dong.Load(dong_Url); 
            seo.Load(seo_Url);
            yuseong.Load(yuseong_Url);
            jung.Load(jung_Url);

            XmlNodeList daeduk_node = daeduk.SelectNodes("//channel/item/description/body/data"); 
            XmlNodeList dong_node = dong.SelectNodes("//channel/item/description/body/data");      
            XmlNodeList seo_node = seo.SelectNodes("//channel/item/description/body/data");
            XmlNodeList yuseong_node = yuseong.SelectNodes("//channel/item/description/body/data");
            XmlNodeList jung_node = jung.SelectNodes("//channel/item/description/body/data");

            if (comboBox1.SelectedIndex == 0)
                foreach (XmlNode node in daeduk_node)
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
                foreach (XmlNode node in dong_node)
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
                foreach (XmlNode node in seo_node)
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
                foreach (XmlNode node in yuseong_node)
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
                foreach (XmlNode node in jung_node)
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
