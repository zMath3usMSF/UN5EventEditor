﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class Setup : Block
    {
        public Setup(MemoryStream ms, CCSF ccs)
        {
            Type = Util.ReadUInt16(ms);
            ms.Seek(2, SeekOrigin.Current);
            Size = Util.ReadInt32(ms);
            ID = 0;
            Data = new byte[Size * 4];
            Name = ccs.toc.objectNameList[(int)ID];
            ms.Read(Data, 0, Data.Length);
        }

        public static byte[] Write(int index)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(0xCCCC0003)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(index)), 0, 4);
            return ms.ToArray();
        }
        public static byte[] WriteEnd()
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(0xCCCC0005)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(1)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(1)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(0xCCCCFF01)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(1)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToInt32(-1)), 0, 4);
            return ms.ToArray();
        }
    }
}
