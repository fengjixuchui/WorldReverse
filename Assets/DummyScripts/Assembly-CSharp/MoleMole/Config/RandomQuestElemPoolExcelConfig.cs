/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Config
{
	[LuaCallCSharp] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	[RecycleType] // 0x0000000189A1D3A0-0x0000000189A1D3E0
	public class RandomQuestElemPoolExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15986
	{
		// Fields
		protected uint _id; // 0x10
		protected uint _poolId; // 0x14
		protected uint _weight; // 0x18
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected QuestElemSample[] _sampleList; // 0x20
	
		// Properties
		public uint id { /* [XID] */ /* 0x000000018988EF20-0x000000018988EF40 */ get => default; /* [XID] */ /* 0x0000000189896480-0x00000001898964A0 */ set {} } // 0x0000000188D5CFE0-0x0000000188D5D080 0x0000000188D5D260-0x0000000188D5D310
		public uint poolId { /* [XID] */ /* 0x000000018989DA80-0x000000018989DAA0 */ get => default; /* [XID] */ /* 0x00000001898A5340-0x00000001898A5360 */ set {} } // 0x0000000188D5D080-0x0000000188D5D120 0x0000000188D5D310-0x0000000188D5D3C0
		public uint weight { /* [XID] */ /* 0x00000001898AC940-0x00000001898AC960 */ get => default; /* [XID] */ /* 0x00000001898B3DE0-0x00000001898B3E00 */ set {} } // 0x0000000188D5D1C0-0x0000000188D5D260 0x0000000188D5D470-0x0000000188D5D520
		public QuestElemSample[] sampleList { /* [XID] */ /* 0x0000000189673C90-0x0000000189673CB0 */ get => default; /* [XID] */ /* 0x00000001898C2FE0-0x00000001898C3000 */ set {} } // 0x0000000188D5D120-0x0000000188D5D1C0 0x0000000188D5D3C0-0x0000000188D5D470
	
		// Constructors
		public RandomQuestElemPoolExcelConfig() {} // 0x0000000188D5CF80-0x0000000188D5CFE0
	
		// Methods
		// [IDTag] // 0x00000001898CA920-0x00000001898CA960
		// [XID] // 0x00000001898CA920-0x00000001898CA960
		public virtual bool ParseFromLine(string line) => default; // 0x0000000188D5CA50-0x0000000188D5CEE0
		// [IDTag] // 0x00000001898D5190-0x00000001898D51D0
		// [XID] // 0x00000001898D5190-0x00000001898D51D0
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000188D5C650-0x0000000188D5CA50
		// [XID] // 0x00000001898DFEE0-0x00000001898DFF00
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2D01 */, bool useObjectPool = false /* Metadata: 0x00AF2D05 */) => default; // 0x0000000188D5C060-0x0000000188D5C510
		[BlackList] // 0x00000001898E7970-0x00000001898E79B0
		// [XID] // 0x00000001898E7970-0x00000001898E79B0
		public virtual void AutoAllocTypeFields() {} // 0x0000000188D5BF10-0x0000000188D5BFB0
		[BlackList] // 0x00000001898F2030-0x00000001898F2070
		// [XID] // 0x00000001898F2030-0x00000001898F2070
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188D5BFB0-0x0000000188D5C060
		[BlackList] // 0x00000001898FC6F0-0x00000001898FC730
		// [XID] // 0x00000001898FC6F0-0x00000001898FC730
		public virtual void ReturnToObjectPool() {} // 0x0000000188D5CEE0-0x0000000188D5CF80
		[BlackList] // 0x0000000189907030-0x0000000189907070
		// [XID] // 0x0000000189907030-0x0000000189907070
		public virtual void OnPoolAllocated() {} // 0x0000000188D5C5B0-0x0000000188D5C650
		[BlackList] // 0x0000000189911840-0x0000000189911880
		// [XID] // 0x0000000189911840-0x0000000189911880
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188D5C510-0x0000000188D5C5B0
	}
}
