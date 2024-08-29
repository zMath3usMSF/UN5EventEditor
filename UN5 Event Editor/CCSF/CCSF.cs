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

        public static void WriteCCS(CCSF ccs)
        {
            MemoryStream ms = new MemoryStream();
            byte[] headerData = Header.Write(ccs.header.Name.Replace("CCSF", ""));
            ms.Write(headerData, 0, headerData.Length);
            byte[] tocData = TOC.Write(ccs.blocks, ccs);
            ms.Write(tocData, 0, tocData.Length);
            byte[] setupData = Setup.Write();
            ms.Write(setupData, 0, setupData.Length);
            for (int i = 3; i < ccs.blocks.Count; i++)
            {
                byte[] binaryData = BinaryBlob.Write(ccs.blocks[i].Data, i);
                ms.Write(binaryData, 0, binaryData.Length);
            }
            byte[] endSetupBytes = Setup.WriteEnd();
            ms.Write(endSetupBytes, 0, endSetupBytes.Length);
            byte[] ok = ms.ToArray();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{ccs.header.Name.Replace("CCSF", "")}.ccs".ToUpper());
            byte[] ccsGzip = Compress(ok, ccs.header.Name.Replace("CCSF", ""));
            File.WriteAllBytes(path, ccsGzip);
        }

        public static byte[] Compress(byte[] data, string Name)
        {
            MemoryStream ms = new MemoryStream();
            GZipOutputStream gs = new GZipOutputStream(ms);
            gs.SetLevel(8);
            gs.FileName = Name + ".tmp";
            gs.Write(data, 0, data.Length);
            gs.Close();
            return ms.ToArray();
        }
    }
}
