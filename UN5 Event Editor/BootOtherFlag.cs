using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class BootOtherFlag
    {
        public uint treeIndex, eventID, progressFlag, value, conditional;
        public static BootOtherFlag Read(byte[] Input) => new BootOtherFlag
        {
            treeIndex = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
            progressFlag = Input.ReadUInt(0x4, 8),
            value = Input.ReadUInt(0x5, 8),
            conditional = Input.ReadUInt(0x6, 8)
        };

        public static byte[] Write(BootOtherFlag bootTalk)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.treeIndex)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.eventID)), 0, 2);
            ms.WriteByte((byte)bootTalk.progressFlag);
            ms.WriteByte((byte)bootTalk.value);
            ms.WriteByte((byte)bootTalk.conditional);
            ms.WriteByte(0x0);
            return ms.ToArray();
        }
    }
}
