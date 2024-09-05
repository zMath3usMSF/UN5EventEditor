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
        public uint unk1, eventID, unk2, unk3, unk4;
        public static BootOtherFlag Read(byte[] Input) => new BootOtherFlag
        {
            unk1 = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
            unk2 = Input.ReadUInt(0x4, 8),
            unk3 = Input.ReadUInt(0x5, 8),
            unk4 = Input.ReadUInt(0x6, 8)
        };

        public static byte[] Write(BootOtherFlag bootTalk)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.unk1)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.eventID)), 0, 2);
            ms.WriteByte((byte)bootTalk.unk2);
            ms.WriteByte((byte)bootTalk.unk3);
            ms.WriteByte((byte)bootTalk.unk4);
            ms.WriteByte(0x0);
            return ms.ToArray();
        }
    }
}
