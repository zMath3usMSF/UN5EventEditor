using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class Plch
    {
        public uint unk1, eventID;
        public static Plch Read(byte[] Input) => new Plch
        {
            unk1 = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
        };

        public static byte[] Write(Plch eventKind)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventKind.unk1)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventKind.eventID)), 0, 2);
            return ms.ToArray();
        }
    }
}
