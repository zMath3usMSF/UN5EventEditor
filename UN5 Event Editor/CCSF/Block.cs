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
                        break;
                    case 0x0002:
                        ccs.toc = new TOC(ms);
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
        public static MemoryStream WriteAllBlocks(MemoryStream ms, CCSF ccs)
        {
            byte[] headerBlock = Header.Write(ccs.header.Name.Replace("CCSF", ""));
            ms.Write(headerBlock, 0, headerBlock.Length);
            byte[] tocBlock = TOC.Write(ccs.blocks, ccs);
            ms.Write(tocBlock, 0, tocBlock.Length);
            for (int i = 0; i < ccs.blocks.Count; i++)
            {
                switch (ccs.blocks[i].Type)
                {
                    case 0x0003:
                        byte[] setupBlock = Setup.Write(i);
                        ms.Write(setupBlock, 0, setupBlock.Length);
                        break;
                    case 0x2400:
                        byte[] binaryBlock = BinaryBlob.Write(ccs.blocks[i].Data, i);
                        ms.Write(binaryBlock, 0, binaryBlock.Length);
                        break;
                    default:
                        byte[] defaultBlock = DefaultBlock.Write(ccs.blocks[i].Data, i);
                        ms.Write(defaultBlock, 0, defaultBlock.Length);
                        break;
                }
            }
            byte[] endSetupBlock = Setup.WriteEnd();
            ms.Write(endSetupBlock, 0, endSetupBlock.Length);
            return ms;
        }
    }
}
