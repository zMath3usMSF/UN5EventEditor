using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UN5_Event_Editor;

namespace UN5_Event_Editor
{
    public class ScriptList
    {
        public static List<string> ccs_tbl = new List<string>();
        public static List<string> event_id = new List<string>();
        public static void Read(byte[] ccs_tblData, byte[] event_idData)
        {
            MemoryStream ms = new MemoryStream(ccs_tblData);
            int count = int.Parse(Util.ReadStringFromMemory(ms, 0x23, (int)ms.Length, "UTF-8"));
            for(int i = 0; i < count; i++)
            {
                string ccs_tblS = Util.ReadStringFromMemory(ms, 0x23, (int)ms.Length, "UTF-8");
                ccs_tbl.Add(ccs_tblS.ToUpper() + ".CCS");
            }
            ms = new MemoryStream(event_idData);
            count = int.Parse(Util.ReadStringFromMemory(ms, 0x23, (int)ms.Length, "UTF-8"));
            for (int i = 0; i < count; i++)
            {
                string event_idS = Util.ReadStringFromMemory(ms, 0x23, (int)ms.Length, "UTF-8");
                string[] event_idSParts = event_idS.Split('_');
                event_id.Add(event_idS.Replace("BIN_", "").Replace($"{event_idSParts[1]}", $"{event_idSParts[1].ToUpper()}").Replace($"{event_idSParts[2]}", $"{event_idSParts[2].ToUpper()}"));
            }
        }

        public static byte[] WriteCCS_TBL(string ccs_tbl)
        {
            MemoryStream ms = new MemoryStream();
            ccs_tbl = ccs_tbl.Replace(".CCS", "").ToLower();
            byte[] ccs_tblBytes = Encoding.UTF8.GetBytes(ccs_tbl);
            ms.Write(ccs_tblBytes, 0, ccs_tblBytes.Length);
            ms.WriteByte(0x23);
            return ms.ToArray();
        }
        public static byte[] WriteEvent_ID(string event_id)
        {
            MemoryStream ms = new MemoryStream();
            string[] event_idSParts = event_id.Split('_');
            event_id = "BIN_" + event_id.Replace(event_idSParts[0], event_idSParts[0].ToLower()).Replace(event_idSParts[1], event_idSParts[1].ToLower());
            byte[] event_idBytes = Encoding.UTF8.GetBytes(event_id);
            ms.Write(event_idBytes, 0, event_idBytes.Length);
            ms.WriteByte(0x23);
            return ms.ToArray();
        }
    }
}
