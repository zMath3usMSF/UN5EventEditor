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
        public uint treeIndex, eventID, kind;
        public static EventKind Read(byte[] Input) => new EventKind
        {
            treeIndex = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
            kind = Input.ReadUInt(0x4, 16)
        };

        public static byte[] Write(EventKind eventKind)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventKind.treeIndex)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventKind.eventID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventKind.kind)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(0)), 0, 2);
            return ms.ToArray();
        }
    }
}
