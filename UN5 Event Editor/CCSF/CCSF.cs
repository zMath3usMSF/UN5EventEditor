using ICSharpCode.SharpZipLib.GZip;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UN5_Event_Editor
{
    public class CCSF
    {
        public List<Block> blocks = new List<Block>();
        public Header header;
        public TOC toc;
        
        public void OpenCCS(string filePath)
        {
            MemoryStream ms = new MemoryStream(File.ReadAllBytes(filePath));
            
            byte[] buffer = new byte[4];
            ms.Read(buffer, 0, 4);
            int magic = BitConverter.ToInt32(buffer, 0);
            ms.Position = 0;
            if (magic == 0x08088B1F)
            {
                GZipStream gzipStream = new GZipStream(new MemoryStream(File.ReadAllBytes(filePath)), CompressionMode.Decompress);
                ms = new MemoryStream();
                gzipStream.CopyTo(ms);
                ms.Position = 0;
            }
            Block.ReadAllBlocks(ms, this);
        }

        public static void WriteCCS(CCSF ccs, string pathSFD)
        {
            MemoryStream ms = new MemoryStream();
            ms = Block.WriteAllBlocks(ms, ccs);
            byte[] ccsGzip = CompressToGZip(ms.ToArray(), ccs.header.Name.Replace("CCSF", ""));
            File.WriteAllBytes(pathSFD, ccsGzip);
        }

        public static byte[] CompressToGZip(byte[] data, string Name)
        {
            MemoryStream ms = new MemoryStream();
            GZipOutputStream gs = new GZipOutputStream(ms);
            gs.SetLevel(8);
            gs.FileName = Name + ".tmp";
            gs.Write(data, 0, data.Length);
            gs.Close();
            return ms.ToArray();
        }

        public static byte[] GetBlockByName(List<Block> blocks, string bName)
        {
            bName = "BIN_" + bName;
            byte[] bData = new byte[0];
            for (int i = 0; i < blocks.Count; i++)
            {
                if (blocks[i].Name == bName)
                {
                    bData = blocks[i].Data;
                }
            }
            return bData;
        }
    }
}
