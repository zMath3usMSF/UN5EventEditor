using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class BootTime
    {
        public uint treeIndex, eventID;
        public int unk2;
        public static BootTime Read(byte[] Input) => new BootTime
        {
            treeIndex = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
            unk2 = (int)Input.ReadUInt(0x4, 32),
        };

        public static byte[] Write(BootTime bootTime)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTime.treeIndex)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTime.eventID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToInt32(bootTime.unk2)), 0, 4);
            return ms.ToArray();
        }
    }
}
