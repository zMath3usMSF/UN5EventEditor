using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class BinaryBlob : Block
    {
        public BinaryBlob(MemoryStream ms, CCSF ccs)
        {
            Type = Util.ReadUInt16(ms);
            ms.Seek(2, SeekOrigin.Current);
            Size = Util.ReadInt32(ms);
            ID = Util.ReadUInt32(ms);
            Name = ccs.toc.objectNameList[(int)ID];
            Data = new byte[Size * 4 - 4];
            ms.Read(Data, 0, Data.Length);
        }

        public static byte[] Write(byte[] data, int index)
        {
            MemoryStream ms = new MemoryStream();
            MemoryStream dataS = new MemoryStream();
            dataS.Write(data, 0, data.Length);
            while (dataS.Length % 4 != 0)
            {
                dataS.WriteByte(0x0);
            }
            data = dataS.ToArray();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(0xCCCC2400)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(data.Length + 4) / 4), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(index)), 0, 4);
            ms.Write(dataS.ToArray(), 0, dataS.ToArray().Length);
            return ms.ToArray();
        }
    }
}
