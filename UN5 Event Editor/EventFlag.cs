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
        public uint treeIndex, eventID, eventIDCheck, value, conditional;
        public static EventFlag Read(byte[] Input) => new EventFlag
        {
            treeIndex = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
            eventIDCheck = Input.ReadUInt(0x4, 16),
            value = Input.ReadUInt(0x6, 8),
            conditional = Input.ReadUInt(0x7, 8),
        };

        public static byte[] Write(EventFlag eventFlag)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventFlag.treeIndex)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventFlag.eventID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(eventFlag.eventIDCheck)), 0, 2);
            ms.WriteByte((byte)eventFlag.value);
            ms.WriteByte((byte)eventFlag.conditional);
            return ms.ToArray();
        }

        public Dictionary<uint, int> valueState = new Dictionary<uint, int>()
        {
            {0, 0 },
            {1, 1 },
            {2, 2 },
            {4, 3 },
            {8, 4 },
            {16, 5 },
            {32, 6 },
            {64, 7 },
            {128, 8 },
        };
        
    }
}
