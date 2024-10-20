﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UN5_Event_Editor;

namespace UN5_Event_Editor
{
    public class BootTalk
    {
        public uint treeIndex, eventID, charID, stageID, autoTalk;
        public static BootTalk Read(byte[] Input) => new BootTalk
        {
            treeIndex = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
            charID = Input.ReadUInt(0x4, 16),
            stageID = Input.ReadUInt(0x7, 8),
            autoTalk = Input.ReadUInt(0x8, 8)
        };

        public static byte[] Write(BootTalk bootTalk)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.treeIndex)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.eventID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.charID)), 0, 2);
            ms.WriteByte(0x0);
            ms.WriteByte((byte)bootTalk.stageID);
            ms.WriteByte((byte)bootTalk.autoTalk);
            ms.WriteByte(0x7);
            return ms.ToArray();
        }
    }
}
