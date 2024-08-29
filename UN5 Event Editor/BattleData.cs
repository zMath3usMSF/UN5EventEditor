using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UN5_Event_Editor;

namespace UN5_Event_Editor
{
    public class BattleData
    {
        public string battleName;
        public uint RyoLose, RyoWin, Difficulty, AllowRetry, GameOver, Time, Player1ID, Player2ID, Suporte1ID, Suporte2ID,
                    Condition1, Condition2, Condition3, Condition4, Jutsu1Player1, Jutsu2Player1, Jutsu1Player2,
                    Jutsu2Player2, Ultimate1Player1, Ultimate2Player1, Ultimate3Player1, Ultimate1Player2, Ultimate2Player2,
                    Ultimate3Player2, Stage, SelectionMode;
        public static BattleData Read(byte[] Input) => new BattleData
        {
            battleName = Util.ReadStringFromBuffer(Input.ReadBytes(0x0, 0x80), 0, 0x80, "ISO-8859-1"),
            RyoLose = Input.ReadUInt(0x80, 32),
            RyoWin = Input.ReadUInt(0x84, 32),
            Difficulty = Input.ReadUInt(0x88, 8),
            AllowRetry = Input.ReadUInt(0x89, 8),
            GameOver = Input.ReadUInt(0x8A, 8),
            Time = Input.ReadUInt(0x8B, 8),
            Player1ID = Input.ReadUInt(0x8C, 8),
            Player2ID = Input.ReadUInt(0x8D, 8),
            Suporte1ID = Input.ReadUInt(0x8E, 8),
            Suporte2ID = Input.ReadUInt(0x8F, 8),
            Condition1 = Input.ReadUInt(0x90, 8),
            Condition2 = Input.ReadUInt(0x91, 8),
            Condition3 = Input.ReadUInt(0x92, 8),
            Condition4 = Input.ReadUInt(0x93, 8),
            Jutsu1Player1 = Input.ReadUInt(0x94, 8),
            Jutsu2Player1 = Input.ReadUInt(0x95, 8),
            Jutsu1Player2 = Input.ReadUInt(0x96, 8),
            Jutsu2Player2 = Input.ReadUInt(0x97, 8),
            Ultimate1Player1 = Input.ReadUInt(0x98, 8),
            Ultimate2Player1 = Input.ReadUInt(0x99, 8),
            Ultimate3Player1 = Input.ReadUInt(0x9A, 8),
            Ultimate1Player2 = Input.ReadUInt(0x9B, 8),
            Ultimate2Player2 = Input.ReadUInt(0x9C, 8),
            Ultimate3Player2 = Input.ReadUInt(0x9D, 8),
            Stage = Input.ReadUInt(0x9E, 16),
            SelectionMode = Input.ReadUInt(0xA0, 16)
        };

        public static byte[] Write(EditBattleData form)
        {
            int index = form.listBox1.SelectedIndex;
            var currentBattleData = form.battleDataList[index];
            MemoryStream ms = new MemoryStream();

            form.listBox1.Items[index] = $"{index}: {form.txtBattleName.Text}";
            currentBattleData.battleName = form.txtBattleName.Text;
            byte[] battleDataNameBytes = Encoding.GetEncoding("ISO-8859-1").GetBytes(form.txtBattleName.Text);
            ms.Write(battleDataNameBytes, 0, battleDataNameBytes.Length);
            while(ms.Length != 0x80)
            {
                ms.WriteByte(0x0);
            }
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(form.numRyoLose.Value)), 0, 4);
            currentBattleData.RyoLose = (uint)form.numRyoLose.Value;
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(form.numRyoWin.Value)), 0, 4);
            currentBattleData.RyoWin = (uint)form.numRyoWin.Value;
            ms.WriteByte((byte)form.cmbDifficulty.SelectedIndex);
            currentBattleData.Difficulty = (uint)form.cmbDifficulty.SelectedIndex;
            ms.WriteByte((byte)form.cmbAllowRetry.SelectedIndex);
            currentBattleData.AllowRetry = (uint)form.cmbAllowRetry.SelectedIndex;
            ms.WriteByte((byte)form.cmbGameOver.SelectedIndex);
            currentBattleData.GameOver = (uint)form.cmbGameOver.SelectedIndex;
            ms.WriteByte((byte)form.numTime.Value);
            currentBattleData.Time = (uint)form.numTime.Value;
            ms.WriteByte((byte)form.cmbPlayer1.SelectedIndex);
            currentBattleData.Player1ID = (uint)form.cmbPlayer1.SelectedIndex;
            ms.WriteByte((byte)form.cmbPlayer2.SelectedIndex);
            currentBattleData.Player2ID = (uint)form.cmbPlayer2.SelectedIndex;
            ms.WriteByte((byte)form.cmbSuport1.SelectedIndex);
            currentBattleData.Suporte1ID = (uint)form.cmbSuport1.SelectedIndex;
            ms.WriteByte((byte)form.cmbSuport2.SelectedIndex);
            currentBattleData.Suporte2ID = (uint)form.cmbSuport2.SelectedIndex;
            ms.WriteByte((byte)form.cmbCondition1.SelectedIndex);
            currentBattleData.Condition1 = (uint)form.cmbCondition1.SelectedIndex;
            ms.WriteByte((byte)form.cmbCondition2.SelectedIndex);
            currentBattleData.Condition2 = (uint)form.cmbCondition2.SelectedIndex;
            ms.WriteByte((byte)form.cmbCondition3.SelectedIndex);
            currentBattleData.Condition3 = (uint)form.cmbCondition3.SelectedIndex;
            ms.WriteByte((byte)form.cmbCondition4.SelectedIndex);
            currentBattleData.Condition4 = (uint)form.cmbCondition4.SelectedIndex;
            ms.WriteByte((byte)form.cmbJutsu1Player1.SelectedIndex);
            currentBattleData.Jutsu1Player1 = (uint)form.cmbJutsu1Player1.SelectedIndex;
            ms.WriteByte((byte)form.cmbJutsu2Player1.SelectedIndex);
            currentBattleData.Jutsu2Player1 = (uint)form.cmbJutsu2Player1.SelectedIndex;
            ms.WriteByte((byte)form.cmbJutsu1Player2.SelectedIndex);
            currentBattleData.Jutsu1Player2 = (uint)form.cmbJutsu1Player2.SelectedIndex;
            ms.WriteByte((byte)form.cmbJutsu2Player2.SelectedIndex);
            currentBattleData.Jutsu2Player2 = (uint)form.cmbJutsu2Player2.SelectedIndex;
            ms.WriteByte((byte)form.cmbPlayer1UltimateJutsu1.SelectedIndex);
            currentBattleData.Ultimate1Player1 = (uint)form.cmbPlayer1UltimateJutsu1.SelectedIndex;
            ms.WriteByte((byte)form.cmbPlayer1UltimateJutsu2.SelectedIndex);
            currentBattleData.Ultimate2Player1 = (uint)form.cmbPlayer1UltimateJutsu2.SelectedIndex;
            ms.WriteByte((byte)form.cmbPlayer1UltimateJutsu3.SelectedIndex);
            currentBattleData.Ultimate3Player1 = (uint)form.cmbPlayer1UltimateJutsu3.SelectedIndex;
            ms.WriteByte((byte)form.cmbPlayer2UltimateJutsu1.SelectedIndex);
            currentBattleData.Ultimate1Player2 = (uint)form.cmbPlayer2UltimateJutsu1.SelectedIndex;
            ms.WriteByte((byte)form.cmbPlayer2UltimateJutsu2.SelectedIndex);
            currentBattleData.Ultimate2Player2 = (uint)form.cmbPlayer2UltimateJutsu2.SelectedIndex;
            ms.WriteByte((byte)form.cmbPlayer2UltimateJutsu3.SelectedIndex);
            currentBattleData.Ultimate3Player2 = (uint)form.cmbPlayer2UltimateJutsu3.SelectedIndex;
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(form.cmbStage.SelectedIndex)), 0, 2);
            currentBattleData.Stage = (uint)form.cmbStage.SelectedIndex;
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(form.cmbSelectMode.SelectedIndex)), 0, 2);
            currentBattleData.SelectionMode = (uint)form.cmbSelectMode.SelectedIndex;
            ms.Write(BitConverter.GetBytes(Convert.ToUInt16(0)), 0, 2);
            return ms.ToArray();
        }
    }
}
