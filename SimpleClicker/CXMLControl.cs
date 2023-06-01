using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace SimpleClicker
{
    class CXMLControl
    {
        public static string _TICK = "TICK";
        public static string _TOTAL = "TOTAL";
        public static string _LEVEL_1 = "LEVEL_1";
        public static string _LEVEL_3 = "LEVEL_3";
        public static string _LEVEL_20 = "LEVEL_20";
        public static string _1_ADD = "ADD_1";
        public static string _3_ADD = "ADD_3";
        public static string _20_ADD = "ADD_20";


        public Dictionary<string, string> XML_Reader(string strXMLPath)
        {
            Dictionary<string, string> DXMLConfig = new Dictionary<string, string>();

            using (XmlReader rd = XmlReader.Create(strXMLPath))  // using 벗어나면 메모리 자동 해제
            {
                while (rd.Read()) // XML Node를 읽는다
                {
                    if(rd.IsStartElement())
                    {
                        if(rd.Name.Equals("SETTING"))
                        {
                            string strID = rd["ID"];
                            rd.Read();

                            string strTick = rd.ReadElementContentAsString(_TICK, "");
                            DXMLConfig.Add(_TICK, strTick);

                            string strTotal = rd.ReadElementContentAsString(_TOTAL, "");
                            DXMLConfig.Add(_TOTAL, strTotal);

                            string strLEVEL_1 = rd.ReadElementContentAsString(_LEVEL_1, "");
                            DXMLConfig.Add(_LEVEL_1, strLEVEL_1);

                            string str1_ADD = rd.ReadElementContentAsString(_1_ADD, "");
                            DXMLConfig.Add(_1_ADD, str1_ADD);

                            string strLEVEL_3 = rd.ReadElementContentAsString(_LEVEL_3, "");
                            DXMLConfig.Add(_LEVEL_3, strLEVEL_3);

                            string str3_ADD = rd.ReadElementContentAsString(_3_ADD, "");
                            DXMLConfig.Add(_3_ADD, str3_ADD);

                            string strLEVEL_20 = rd.ReadElementContentAsString(_LEVEL_20, "");
                            DXMLConfig.Add(_LEVEL_20, strLEVEL_20);

                            string str20_ADD = rd.ReadElementContentAsString(_20_ADD, "");
                            DXMLConfig.Add(_20_ADD, str20_ADD);
                        }
                    }
                }
            }

                return DXMLConfig;
        }


        public void XML_Write(string strXMLPath, Dictionary<string, string> DXMLConfig)
        {
            using (XmlWriter wr = XmlWriter.Create(strXMLPath))
            {
                wr.WriteStartDocument();

                // SETTING
                wr.WriteStartElement("SETTING");

                wr.WriteAttributeString("ID", "0001");
                wr.WriteElementString(_TICK, DXMLConfig[_TICK]);
                wr.WriteElementString(_TOTAL, DXMLConfig[_TOTAL]);
                wr.WriteElementString(_LEVEL_1, DXMLConfig[_LEVEL_1]);
                wr.WriteElementString(_1_ADD, DXMLConfig[_1_ADD]);

                wr.WriteElementString(_LEVEL_3, DXMLConfig[_LEVEL_3]);
                wr.WriteElementString(_3_ADD, DXMLConfig[_3_ADD]);

                wr.WriteElementString(_LEVEL_20, DXMLConfig[_LEVEL_20]);
                wr.WriteElementString(_20_ADD, DXMLConfig[_20_ADD]);

                wr.WriteEndElement();

                wr.WriteEndDocument();
            }
        }

    }
}
