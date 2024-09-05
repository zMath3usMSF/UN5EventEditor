using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class BootSpc
    {
        public uint unk1, eventID, charID, isTeam;
        public static BootSpc Read(byte[] Input) => new BootSpc
        {
            unk1 = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
            charID = Input.ReadUInt(0x4, 16),
            isTeam = Input.ReadUInt(0x6, 16),
        };

        public static byte[] Write(BootSpc bootTalk)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.unk1)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.eventID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.charID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.isTeam)), 0, 2);
            return ms.ToArray();
        }
    }
}
