using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UN5_Event_Editor
{
    public class TOC : Block
    {
        public int fileCount;
        public int objectCount;
        public List<string> fileNameList;
        public List<string> objectNameList;
        public List<int> indexesList;

        public TOC(MemoryStream ms)
        {
            byte[] buffer = new byte[0x20];
            Type = Util.ReadUInt16(ms);
            ms.Seek(2, SeekOrigin.Current);
            Size = Util.ReadInt32(ms);
            Data = new byte[Size * 4];
            ms.Read(Data, 0, Data.Length);

            MemoryStream tocS = new MemoryStream(Data);
            tocS.Read(buffer, 0, 8);
            fileCount = BitConverter.ToInt32(buffer, 0);
            objectCount = BitConverter.ToInt32(buffer, 4);

            fileNameList = new List<string>();
            for (int i = 0; i < fileCount; i++)
            {
                tocS.Read(buffer, 0, 0x20);
                fileNameList.Add(Util.ReadStringFromBuffer(buffer, 0, 0x20, "shift-jis"));
            }

            objectNameList = new List<string>();
            indexesList = new List<int>();
            for (int i = 0; i < objectCount * 0x20; i+=0x20)
            {
                tocS.Read(buffer, 0, 0x20);
                objectNameList.Add(Util.ReadStringFromBuffer(buffer, 0, 0x1E, "shift-jis"));
                indexesList.Add(BitConverter.ToInt16(buffer, 2));
            }
        }

        public static byte[] Write(List<Block> blocks, CCSF ccs)
        {
            MemoryStream toc = new MemoryStream();
            toc.Write(BitConverter.GetBytes(Convert.ToUInt32(ccs.toc.fileCount)), 0, 4);
            toc.Write(BitConverter.GetBytes(Convert.ToUInt32(ccs.toc.objectCount)), 0, 4);
            for(int i = 0; i < ccs.toc.fileNameList.Count; i++)
            {
                Util.WriteString(toc, ccs.toc.fileNameList[i], 0x20);
            }
            for (int i = 2; i < blocks.Count; i++)
            {
                Util.WriteString(toc, blocks[i].Name, 0x1E);
                toc.Write(BitConverter.GetBytes((ushort)0x0), 0, 2);
            }
            MemoryStream tocHeader = new MemoryStream();
            tocHeader.Write(BitConverter.GetBytes(Convert.ToUInt32(0xCCCC0002)), 0, 4);
            tocHeader.Write(BitConverter.GetBytes(Convert.ToUInt32(toc.Length / 4)), 0, 4);
            tocHeader.Write(toc.ToArray(), 0, toc.ToArray().Length);
            return tocHeader.ToArray();
        }
    }
}

