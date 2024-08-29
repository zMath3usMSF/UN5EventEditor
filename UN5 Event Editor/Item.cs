using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class Item
    {
        public uint ID, iconID, unk1, category, normalPurchasePrice, sunaPurchasePrice, sellingPrice, inventoryLimit, enabled;
        public static Item Read(byte[] Input) => new Item
        {
            ID = Input.ReadUInt(0x0, 16),
            iconID = Input.ReadUInt(0x2, 16),
            unk1 = Input.ReadUInt(0x4, 16),
            category = Input.ReadUInt(0x6, 8),
            normalPurchasePrice = Input.ReadUInt(0x8, 16),
            sunaPurchasePrice = Input.ReadUInt(0xC, 16),
            sellingPrice = Input.ReadUInt(0x10, 16),
            inventoryLimit = Input.ReadUInt(0x14, 16),
            enabled = Input.ReadUInt(0x18, 16)
        };

        public static byte[] Write(Item item)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(item.ID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(item.iconID)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(item.unk1)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(item.category)), 0, 2);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(item.normalPurchasePrice)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(item.sunaPurchasePrice)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(item.sellingPrice)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(item.inventoryLimit)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(item.enabled)), 0, 4);
            return ms.ToArray();
        }
    }
}
