//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.8784
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace XTable {
    
    
    public class FashionSuit : CSVReader {
        
        public class RowData :BaseRow {
			public uint SuitID;
			public string SuitName;
			public int SuitQuality;
			public string SuitAtlas;
			public string SuitIcon;
			public int[] FashionID;
			public string Effect2;
			public string Effect3;
			public string Effect4;
			public string Effect5;
			public string Effect6;
			public string Effect7;
			public int All1;
			public int All2;
			public int All3;
			public int All4;
			public int All0SP;
			public int All1SP;
			public int All2SP;
			public int All3SP;
			public int All4SP;
			public bool NoSale;
			public int ShowLevel;
			public int OverAll;
		}


		private RowData[] Table;

		public override int length { get { return Table.Length; } }

		public RowData this[int index] { get { return Table[index]; } }

		public override string bytePath { get { return "Table/FashionSuit"; } }
        
        // 二分法查找
        public virtual RowData GetByUID(int id) {
			return BinarySearch(Table, 0, Table.Length - 1, id) as RowData;
        }
        
        public override void OnClear(int lineCount) {
			if (lineCount > 0) Table = new RowData[lineCount];
			else Table = null;
        }
        
        public override void ReadLine(System.IO.BinaryReader reader) {
			RowData row = new RowData();
			Read<uint>(reader, ref row.SuitID, uintParse); columnno = 0;
			Read<string>(reader, ref row.SuitName, stringParse); columnno = 1;
			Read<int>(reader, ref row.SuitQuality, intParse); columnno = 2;
			Read<string>(reader, ref row.SuitAtlas, stringParse); columnno = 3;
			Read<string>(reader, ref row.SuitIcon, stringParse); columnno = 4;
			ReadArray<int>(reader, ref row.FashionID, intParse); columnno = 5;
			Read<string>(reader, ref row.Effect2, stringParse); columnno = 6;
			Read<string>(reader, ref row.Effect3, stringParse); columnno = 7;
			Read<string>(reader, ref row.Effect4, stringParse); columnno = 8;
			Read<string>(reader, ref row.Effect5, stringParse); columnno = 9;
			Read<string>(reader, ref row.Effect6, stringParse); columnno = 10;
			Read<string>(reader, ref row.Effect7, stringParse); columnno = 11;
			Read<int>(reader, ref row.All1, intParse); columnno = 12;
			Read<int>(reader, ref row.All2, intParse); columnno = 13;
			Read<int>(reader, ref row.All3, intParse); columnno = 14;
			Read<int>(reader, ref row.All4, intParse); columnno = 15;
			Read<int>(reader, ref row.All0SP, intParse); columnno = 16;
			Read<int>(reader, ref row.All1SP, intParse); columnno = 17;
			Read<int>(reader, ref row.All2SP, intParse); columnno = 18;
			Read<int>(reader, ref row.All3SP, intParse); columnno = 19;
			Read<int>(reader, ref row.All4SP, intParse); columnno = 20;
			Read<bool>(reader, ref row.NoSale, boolParse); columnno = 21;
			Read<int>(reader, ref row.ShowLevel, intParse); columnno = 22;
			Read<int>(reader, ref row.OverAll, intParse); columnno = 23;
			row.sortID = (int)row.SuitID;
			Table[lineno] = row;
			columnno = -1;
        }
    }
}
