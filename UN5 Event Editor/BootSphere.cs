using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class BootSphere
    {
        public uint treeIndex, eventID, scale, stageID, activationMode, confirmationMode;
        public int posX, posY, posZ;
        public static BootSphere Read(byte[] Input) => new BootSphere
        {
            treeIndex = Input.ReadUInt(0x0, 16),
            eventID = Input.ReadUInt(0x2, 16),
            posX = (int)Input.ReadUInt(0x4, 32),
            posY = (int)Input.ReadUInt(0x8, 32),
            posZ = (int)Input.ReadUInt(0xC, 32),
            scale = Input.ReadUInt(0x10, 16),
            stageID = Input.ReadUInt(0x13, 8),
            activationMode = Input.ReadUInt(0x14, 8),
            confirmationMode = Input.ReadUInt(0x15, 8),
        };

        public static byte[] Write(BootSphere bootTalk)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.treeIndex)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.eventID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToInt32(bootTalk.posX)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToInt32(bootTalk.posY)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToInt32(bootTalk.posZ)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(bootTalk.scale)), 0, 2);
            ms.WriteByte(0);
            ms.WriteByte((byte)bootTalk.stageID);
            ms.WriteByte((byte)bootTalk.activationMode);
            ms.WriteByte((byte)bootTalk.confirmationMode);
            ms.WriteByte((byte)bootTalk.confirmationMode);
            ms.WriteByte((byte)bootTalk.confirmationMode);
            return ms.ToArray();
        }
    }
}
