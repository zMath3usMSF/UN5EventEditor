using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class EventKind
    {
        public uint unk1, eventID, unk2, unk3;
        public static EventKind Read(byte[] Input) => new EventKind
        {
            unk1 = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
            unk2 = Input.ReadUInt(0x4, 16),
            unk3 = Input.ReadUInt(0x6, 16),
        };

        public static byte[] Write(EventKind eventKind)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventKind.unk1)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventKind.eventID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventKind.unk2)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventKind.unk3)), 0, 2);
            return ms.ToArray();
        }
    }
}
