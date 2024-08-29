using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class Block
    {
        public string Name;
        public uint Type;
        public int Size;
        public uint ID;
        public byte[] Data;

        public static void ReadAllBlocks(MemoryStream ms, CCSF ccs)
        {
            while(ms.Position != ms.Length)
            {
                byte[] buffer = new byte[4];
                ms.Read(buffer, 0, 4);
                uint currentType = BitConverter.ToUInt16(buffer, 0);
                ms.Seek(-4, SeekOrigin.Current);

                Block block;
                switch (currentType)
                {
                    case 0x0001:
                        ccs.header = new Header(ms);
                        ccs.blocks.Add(ccs.header);
                        break;
                    case 0x0002:
                        ccs.toc = new TOC(ms);
                        ccs.blocks.Add(ccs.toc);
                        break;
                    case 0x0003:
                        block = new Setup(ms, ccs);
                        ccs.blocks.Add(block);
                        break;
                    case 0x2400:
                        block = new BinaryBlob(ms, ccs);
                        ccs.blocks.Add(block);
                        break;
                    default:
                        block = new DefaultBlock(ms);
                        break;
                }
            }
        }
    }
}
