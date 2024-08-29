using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class EventFlag
    {
        public uint unk1, eventID, unk2, unk3, unk4;
        public static EventFlag Read(byte[] Input) => new EventFlag
        {
            unk1 = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
            unk2 = Input.ReadUInt(0x4, 16),
            unk3 = Input.ReadUInt(0x6, 8),
            unk4 = Input.ReadUInt(0x7, 8),
        };

        public static byte[] Write(EventFlag eventFlag)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventFlag.unk1)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventFlag.eventID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventFlag.unk2)), 0, 2);
            ms.WriteByte((byte)eventFlag.unk3);
            ms.WriteByte((byte)eventFlag.unk4);
            return ms.ToArray();
        }
    }
}
