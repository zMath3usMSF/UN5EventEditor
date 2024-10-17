using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class BootStage
    {
        public uint treeIndex, eventID, stageID, activation;
        public static BootStage Read(byte[] Input) => new BootStage
        {
            treeIndex = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
            stageID = Input.ReadUInt(0x5, 8),
            activation = Input.ReadUInt(0x6, 8)
        };

        public static byte[] Write(BootStage bootTalk)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.treeIndex)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.eventID)), 0, 2);
            ms.WriteByte(0x0);
            ms.WriteByte((byte)bootTalk.stageID);
            ms.WriteByte((byte)bootTalk.activation);
            ms.WriteByte(0x0);
            return ms.ToArray();
        }
    }
}
