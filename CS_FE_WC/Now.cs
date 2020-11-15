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
    public partial class Now : Form
    {
        public Now()
        {
            InitializeComponent();
        }

        private void Now_Load(object sender, EventArgs e)
        {
            string seoul_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1159068000";
            string incheon_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4211070500";
            string daejeon_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=3020054000";
            string gwangju_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2917060200";
            string daegu_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2714059000";
            string ulsan_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=3111058500";
            string busan_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2611053000";
            string gangwon_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4211070500";
            string gyeonggi_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4111356000";
            string gyeongnam_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4812552000";
            string gyeongbuk_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4717062000";
            string jeonnam_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4611055400";
            string jeonbuk_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4511357000";
            string chungnam_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4480025600";
            string chungbuk_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4311374100";
            string jeju_Url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=5011059000";

            XmlDocument seoul = new XmlDocument();
            XmlDocument incheon = new XmlDocument();
            XmlDocument daejeon = new XmlDocument();
            XmlDocument gwangju = new XmlDocument();
            XmlDocument daegu = new XmlDocument();
            XmlDocument ulsan = new XmlDocument();
            XmlDocument busan = new XmlDocument();
            XmlDocument gangwon = new XmlDocument();
            XmlDocument gyeonggi = new XmlDocument();
            XmlDocument gyeongnam = new XmlDocument();
            XmlDocument gyeongbuk = new XmlDocument();
            XmlDocument jeonnam = new XmlDocument();
            XmlDocument jeonbuk = new XmlDocument();
            XmlDocument chungnam = new XmlDocument();
            XmlDocument chungbuk = new XmlDocument();
            XmlDocument jeju = new XmlDocument();

            seoul.Load(seoul_Url);
            incheon.Load(incheon_Url);
            daejeon.Load(daejeon_Url);
            gwangju.Load(gwangju_Url);
            daegu.Load(daegu_Url);
            ulsan.Load(ulsan_Url);
            busan.Load(busan_Url);
            gangwon.Load(gangwon_Url);
            gyeonggi.Load(gyeonggi_Url);
            gyeongnam.Load(gyeongnam_Url);
            gyeongbuk.Load(gyeongbuk_Url);
            jeonnam.Load(jeonnam_Url);
            jeonbuk.Load(jeonbuk_Url);
            chungnam.Load(chungnam_Url);
            chungbuk.Load(chungbuk_Url);
            jeju.Load(jeju_Url);

            XmlNodeList seoul_node = seoul.SelectNodes("//channel/item/description/body/data");
            XmlNodeList incheon_node = incheon.SelectNodes("//channel/item/description/body/data");
            XmlNodeList daejeon_node = daejeon.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gwangju_node = gwangju.SelectNodes("//channel/item/description/body/data");
            XmlNodeList daegu_node = daegu.SelectNodes("//channel/item/description/body/data");
            XmlNodeList ulsan_node = ulsan.SelectNodes("//channel/item/description/body/data");
            XmlNodeList busan_node = busan.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gangwon_node = gangwon.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gyeonggi_node = gyeonggi.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gyeongnam_node = gyeongnam.SelectNodes("//channel/item/description/body/data");
            XmlNodeList gyeongbuk_node = gyeongbuk.SelectNodes("//channel/item/description/body/data");
            XmlNodeList jeonnam_node = jeonnam.SelectNodes("//channel/item/description/body/data");
            XmlNodeList jeonbuk_node = jeonbuk.SelectNodes("//channel/item/description/body/data");
            XmlNodeList chungnam_node = chungnam.SelectNodes("//channel/item/description/body/data");
            XmlNodeList chungbuk_node = chungbuk.SelectNodes("//channel/item/description/body/data");
            XmlNodeList jeju_node = jeju.SelectNodes("//channel/item/description/body/data");

            foreach (XmlNode node in seoul_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    서울.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    서울.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    서울.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    서울.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    서울.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    서울.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    서울.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in incheon_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    인천.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    인천.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    인천.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    인천.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    인천.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    인천.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    인천.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in daejeon_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    대전.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    대전.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    대전.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    대전.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    대전.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    대전.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    대전.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in gwangju_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    광주.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    광주.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    광주.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    광주.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    광주.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    광주.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    광주.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in daegu_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    대구.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    대구.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    대구.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    대구.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    대구.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    대구.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    대구.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in ulsan_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    울산.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    울산.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    울산.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    울산.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    울산.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    울산.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    울산.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in busan_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    부산.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    부산.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    부산.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    부산.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    부산.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    부산.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    부산.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in gangwon_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    강원.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    강원.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    강원.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    강원.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    강원.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    강원.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    강원.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in gyeonggi_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    경기.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    경기.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    경기.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    경기.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    경기.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    경기.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    경기.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in gyeongnam_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    경남.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    경남.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    경남.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    경남.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    경남.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    경남.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    경남.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in gyeongbuk_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    경북.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    경북.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    경북.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    경북.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    경북.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    경북.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    경북.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in jeonnam_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    전남.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    전남.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    전남.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    전남.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    전남.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    전남.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    전남.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in jeonbuk_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    전북.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    전북.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    전북.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    전북.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    전북.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    전북.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    전북.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in chungnam_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    충남.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    충남.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    충남.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    충남.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    충남.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    충남.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    충남.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in chungbuk_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    충북.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    충북.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    충북.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    충북.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    충북.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    충북.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    충북.Image = Properties.Resources.황사;
                }
            }
            foreach (XmlNode node in jeju_node)
            {
                XmlNode wfKor = node.SelectSingleNode("wfKor");
                if (wfKor.InnerText == "맑음" || wfKor.InnerText == "구름 조금")
                {
                    제주.Image = Properties.Resources.맑음;
                }
                else if (wfKor.InnerText == "흐림" || wfKor.InnerText == "구름 많음")
                {
                    제주.Image = Properties.Resources.흐림;
                }
                else if (wfKor.InnerText == "소나기" || wfKor.InnerText == "천둥번개")
                {
                    제주.Image = Properties.Resources.소나기;
                }
                else if (wfKor.InnerText == "비" || wfKor.InnerText == "비 또는 눈" || wfKor.InnerText == "가끔 비" || wfKor.InnerText == "가끔 비 또는 눈")
                {
                    제주.Image = Properties.Resources.비;
                }
                else if (wfKor.InnerText == "눈" || wfKor.InnerText == "눈 또는 비" || wfKor.InnerText == "가끔 눈" || wfKor.InnerText == "가끔 눈 또는 비")
                {
                    제주.Image = Properties.Resources.눈;
                }
                else if (wfKor.InnerText == "안개" || wfKor.InnerText == "연무" || wfKor.InnerText == "박무")
                {
                    제주.Image = Properties.Resources.안개;
                }
                else if (wfKor.InnerText == "황사")
                {
                    제주.Image = Properties.Resources.황사;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 서울_Click(object sender, EventArgs e)
        {
            Seoul seo = new Seoul();
            seo.ShowDialog();
        }

        private void 인천_Click(object sender, EventArgs e)
        {
            InCheon ich = new InCheon();
            ich.ShowDialog();
        }

        private void 대전_Click(object sender, EventArgs e)
        {
            Daejeon dae = new Daejeon();
            dae.ShowDialog();
        }

        private void 광주_Click(object sender, EventArgs e)
        {
            Gwangju gwa = new Gwangju();
            gwa.ShowDialog();
        }

        private void 대구_Click(object sender, EventArgs e)
        {
            Daegu daeg = new Daegu();
            daeg.ShowDialog();
        }

        private void 울산_Click(object sender, EventArgs e)
        {
            Ulsan uls = new Ulsan();
            uls.ShowDialog();
        }

        private void 부산_Click(object sender, EventArgs e)
        {
            Busan bus = new Busan();
            bus.ShowDialog();
        }

        private void 경기_Click(object sender, EventArgs e)
        {
            Gyeonggi ggi = new Gyeonggi();
            ggi.ShowDialog();
        }

        private void 경남_Click(object sender, EventArgs e)
        {
            Gyeongnam gnam = new Gyeongnam();
            gnam.ShowDialog();
        }

        private void 경북_Click(object sender, EventArgs e)
        {
            Gyeongbuk gbuk = new Gyeongbuk();
            gbuk.ShowDialog();
        }

        private void 전남_Click(object sender, EventArgs e)
        {
            Jeonnam jnam = new Jeonnam();
            jnam.ShowDialog();
        }

        private void 전북_Click(object sender, EventArgs e)
        {
            Jeonbuk jbuk = new Jeonbuk();
            jbuk.ShowDialog();
        }

        private void 충남_Click(object sender, EventArgs e)
        {
            Chungnam cnam = new Chungnam();
            cnam.ShowDialog();
        }

        private void 충북_Click(object sender, EventArgs e)
        {
            Chungbuk cbuk = new Chungbuk();
            cbuk.ShowDialog();
        }

        private void 제주_Click(object sender, EventArgs e)
        {
            Jeju je = new Jeju();
            je.ShowDialog();
        }
    }
}
