using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UN5_Event_Editor;

namespace UN5_Event_Editor
{
    public class CharData
    {
        public uint charID1, charID2;
        public string charName = "", charDescription = "", charCCS = "", charANM1 = "ANM_", charANM2 = "ANM_", charANM3 = "ANM_", charANM4 = "ANM_", charANM5 = "ANM_";
        public static CharData Read(byte[] Input) => new CharData
        {
            charID1 = Input.ReadUInt(0x0, 32),
            charID2 = Input.ReadUInt(0x4, 32),
            charName = Util.ReadStringFromBuffer(Input.ReadBytes(0x8, 0x20), 0x20, "shift-jis"),
            charDescription = Util.ReadStringFromBuffer(Input.ReadBytes(0x28, 0x40), 0x40, "shift-jis"),
            charCCS = Util.ReadStringFromBuffer(Input.ReadBytes(0x68, 0x20), 0x20, "shift-jis"),
            charANM1 = Util.ReadStringFromBuffer(Input.ReadBytes(0x88, 0x20), 0x20, "shift-jis"),
            charANM2 = Util.ReadStringFromBuffer(Input.ReadBytes(0xA8, 0x20), 0x20, "shift-jis"),
            charANM3 = Util.ReadStringFromBuffer(Input.ReadBytes(0xC8, 0x20), 0x20, "shift-jis"),
            charANM4 = Util.ReadStringFromBuffer(Input.ReadBytes(0xE8, 0x20), 0x20, "shift-jis"),
            charANM5 = Util.ReadStringFromBuffer(Input.ReadBytes(0x108, 0x20), 0x20, "shift-jis"),
        };

        public static byte[] Write(EditCharData form, int index)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(index)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(index)), 0, 4);
            ms.Write(Util.WriteString(Form1.charDataList[index].charName, 0x20, "ISO-8859-1"), 0, 0x20);
            ms.Write(Util.WriteString(Form1.charDataList[index].charDescription, 0x40, "ISO-8859-1"), 0, 0x40);
            ms.Write(Util.WriteString(Form1.charDataList[index].charCCS, 0x20, "ISO-8859-1"), 0, 0x20);
            ms.Write(Util.WriteString(Form1.charDataList[index].charANM1, 0x20, "ISO-8859-1"), 0, 0x20);
            ms.Write(Util.WriteString(Form1.charDataList[index].charANM2, 0x20, "ISO-8859-1"), 0, 0x20);
            ms.Write(Util.WriteString(Form1.charDataList[index].charANM3, 0x20, "ISO-8859-1"), 0, 0x20);
            ms.Write(Util.WriteString(Form1.charDataList[index].charANM4, 0x20, "ISO-8859-1"), 0, 0x20);
            ms.Write(Util.WriteString(Form1.charDataList[index].charANM5, 0x20, "ISO-8859-1"), 0, 0x20);
            return ms.ToArray();
        }
        public static void Update(EditCharData form, int index)
        {
            Form1.charDataList[index].charName = form.txtCharName.Text;
            Form1.charDataList[index].charDescription = form.rchCharDescription.Text;
            Form1.charDataList[index].charCCS = form.txtCharCCS.Text;
            Form1.charDataList[index].charANM1 = form.txtANM1.Text;
            Form1.charDataList[index].charANM2 = form.txtANM2.Text;
            Form1.charDataList[index].charANM3 = form.txtANM3.Text;
            Form1.charDataList[index].charANM4 = form.txtANM4.Text;
            Form1.charDataList[index].charANM5 = form.txtANM5.Text;
        }
    }
}
