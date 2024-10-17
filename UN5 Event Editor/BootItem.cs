using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class BootItem
    {
        public uint treeIndex, eventID, itemID, stockCount;
        public static BootItem Read(byte[] Input) => new BootItem
        {
            treeIndex = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
            itemID = Input.ReadUInt(0x4, 16),
            stockCount = Input.ReadUInt(0x7, 8),
        };

        public static byte[] Write(BootItem bootTalk)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.treeIndex)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.eventID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.itemID)), 0, 2);
            ms.WriteByte(0x3);
            ms.WriteByte((byte)bootTalk.stockCount);
            return ms.ToArray();
        }
    }
}
