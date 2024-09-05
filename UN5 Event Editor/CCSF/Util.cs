using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UN5_Event_Editor
{
    public class Util
    {
        public static UInt16 ReadUInt16(MemoryStream ms)
        {
            byte[] buffer = new byte[2];
            ms.Read(buffer, 0, 2);
            return BitConverter.ToUInt16(buffer, 0);
        }
        public static UInt32 ReadUInt32(MemoryStream ms)
        {
            byte[] buffer = new byte[4];
            ms.Read(buffer, 0, 4);
            return BitConverter.ToUInt32(buffer, 0);
        }
        public static Int32 ReadInt32(MemoryStream ms)
        {
            byte[] buffer = new byte[4];
            ms.Read(buffer, 0, 4);
            return BitConverter.ToInt32(buffer, 0);
        }

        public static string ReadStringFromBuffer(byte[] buff, int len, string encoding)
        {
            List<byte> fileStrBytes = new List<byte>();
            MemoryStream ms = new MemoryStream(buff);
            for(int i = 0; i != len; i++)
            {
                byte byteValue = (byte)ms.ReadByte();
                if (byteValue == 0)
                {
                    break;
                }
                fileStrBytes.Add(byteValue);
            }
            return Encoding.GetEncoding(encoding).GetString(fileStrBytes.ToArray());
        }
        
        public static byte[] WriteString(string stringValue, int len, string encoding)
        {
            MemoryStream ms = new MemoryStream();
            byte[] stringBytes = Encoding.GetEncoding(encoding).GetBytes(stringValue);
            ms.Write(stringBytes, 0, stringBytes.Length < len ? stringBytes.Length : len);
            while(ms.Length != len)
            {
                ms.WriteByte(0x0);
            }
            return ms.ToArray();
        }

        public static int HexToDec(string stringValue)
        {
            if (stringValue.StartsWith("0x"))
            {
                stringValue = stringValue.Substring(2);
            }
            return Convert.ToInt32(stringValue, 16);
        }
        public static string CropString(string stringValue, char charValue)
        {
            int init = stringValue.IndexOf('"') + 1;
            int end = stringValue.LastIndexOf('"');
            return stringValue.Substring(init, end - init);
        }
        public static string CropString2(string texto, int index)
        {
            Regex regex = new Regex("\"([^\"]*)\"");
            MatchCollection matches = regex.Matches(texto);

            if (index >= 0 && index < matches.Count)
            {
                return matches[index].Groups[1].Value;
            }
            else
            {
                return null;
            }
        }
        public static void WriteString(MemoryStream ms, string stringValue, int length)
        {
            byte[] stringBytes = Encoding.GetEncoding("shift-jis").GetBytes(stringValue);
            ms.Write(stringBytes, 0, stringBytes.Length);
            for (int i = stringBytes.Length; i < length; i++)
            {
                ms.WriteByte(0x0);
            }
        }
        public static List<string> RemoveSpacesExceptInQuotes(string input)
        {
            List<string> result = new List<string>();
            StringBuilder currentPart = new StringBuilder();
            bool insideQuotes = false;

            foreach (char c in input)
            {
                if (c == '"')
                {
                    insideQuotes = !insideQuotes;
                    currentPart.Append(c);
                }
                else if (char.IsWhiteSpace(c) && !insideQuotes)
                {
                    if (currentPart.Length > 0)
                    {
                        result.Add(currentPart.ToString().Trim());
                        currentPart.Clear();
                    }
                }
                else
                {
                    if (currentPart.Length == 0 && char.IsWhiteSpace(c) && !insideQuotes)
                    {
                        continue;
                    }

                    currentPart.Append(c);
                }
            }

            if (currentPart.Length > 0)
            {
                result.Add(currentPart.ToString().Trim());
            }

            return result;
        }
        public static string RemoveQuotes(string part)
        {
            if (part.Length > 1 && part[0] == '"' && part[part.Length - 1] == '"')
            {
                return part.Substring(1, part.Length - 2);
            }
            return part;
        }
        public static string ReadStringFromMemory(MemoryStream ms, byte separator, int len, string encoding)
        {
            List<byte> stringBytes = new List<byte>();
            for(int i = 0; i < len; i++)
            {
                byte currentByte = (byte)ms.ReadByte();
                if (currentByte == separator)
                {
                    break;
                }
                stringBytes.Add(currentByte);
            }
            return Encoding.GetEncoding(encoding).GetString(stringBytes.ToArray(), 0, stringBytes.ToArray().Length);

        }
        public static long GetCurrentTimestampUNIX()
        {
            DateTimeOffset now = DateTimeOffset.UtcNow;
            DateTimeOffset unixEpoch = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);
            return (long)(now - unixEpoch).TotalSeconds;
        }
    }
}
