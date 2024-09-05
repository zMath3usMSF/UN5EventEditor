using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class FieldItem
    {
        public uint objID, ID, itemID, stageID, disarm, verify;
        public int posX, posY, posZ, rotX;
        public static FieldItem Read(byte[] Input) => new FieldItem
        {
            objID = Input.ReadUInt(0x0, 16),
            ID = Input.ReadUInt(0x2, 16),
            itemID = Input.ReadUInt(0x4, 16),
            stageID = Input.ReadUInt(0x6, 16),
            posX = (int)Input.ReadUInt(0x8, 32),
            posY = (int)Input.ReadUInt(0xC, 32),
            posZ = (int)Input.ReadUInt(0x10, 32),
            rotX = (int)Input.ReadUInt(0x14, 32),
            verify = Input.ReadUInt(0x18, 16),
            disarm = Input.ReadUInt(0x1A, 16)
        };

        public static byte[] Write(FieldItem item)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(item.objID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(item.ID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(item.itemID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(item.stageID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToInt32(item.posX)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToInt32(item.posY)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToInt32(item.posZ)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToInt32(item.rotX)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(item.verify)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(item.disarm)), 0, 2);
            return ms.ToArray();
        }
    }
}
