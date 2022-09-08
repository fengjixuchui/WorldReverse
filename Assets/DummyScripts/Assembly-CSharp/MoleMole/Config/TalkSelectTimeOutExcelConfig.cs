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
	public class TalkSelectTimeOutExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15972
	{
		// Fields
		protected uint _id; // 0x10
		protected float _timeLimit; // 0x14
		protected uint _nextTalkID; // 0x18
	
		// Properties
		public uint id { /* [XID] */ /* 0x000000018979EF90-0x000000018979EFB0 */ get => default; /* [XID] */ /* 0x00000001897A65C0-0x00000001897A65E0 */ set {} } // 0x0000000186B7C4F0-0x0000000186B7C590 0x0000000186B7C6E0-0x0000000186B7C790
		public float timeLimit { /* [XID] */ /* 0x00000001897ADB50-0x00000001897ADB70 */ get => default; /* [XID] */ /* 0x00000001897B5D10-0x00000001897B5D30 */ set {} } // 0x0000000186B7C630-0x0000000186B7C6E0 0x0000000186B7C840-0x0000000186B7CA20
		public uint nextTalkID { /* [XID] */ /* 0x00000001897BDAE0-0x00000001897BDB00 */ get => default; /* [XID] */ /* 0x00000001897C4E60-0x00000001897C4E80 */ set {} } // 0x0000000186B7C590-0x0000000186B7C630 0x0000000186B7C790-0x0000000186B7C840
	
		// Constructors
		public TalkSelectTimeOutExcelConfig() {} // 0x0000000186B7C490-0x0000000186B7C4F0
	
		// Methods
		// [IDTag] // 0x00000001897CC690-0x00000001897CC6D0
		// [XID] // 0x00000001897CC690-0x00000001897CC6D0
		public virtual bool ParseFromLine(string line) => default; // 0x0000000186B7C110-0x0000000186B7C3F0
		// [IDTag] // 0x00000001897D7000-0x00000001897D7040
		// [XID] // 0x00000001897D7000-0x00000001897D7040
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000186B7BE70-0x0000000186B7C110
		// [XID] // 0x00000001897E1820-0x00000001897E1840
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CA2 */, bool useObjectPool = false /* Metadata: 0x00AF2CA6 */) => default; // 0x0000000186B7B920-0x0000000186B7BD30
		[BlackList] // 0x00000001897E9070-0x00000001897E90B0
		// [XID] // 0x00000001897E9070-0x00000001897E90B0
		public virtual void AutoAllocTypeFields() {} // 0x0000000186B7B7E0-0x0000000186B7B880
		[BlackList] // 0x00000001897F3C70-0x00000001897F3CB0
		// [XID] // 0x00000001897F3C70-0x00000001897F3CB0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000186B7B880-0x0000000186B7B920
		[BlackList] // 0x00000001897FDFA0-0x00000001897FDFE0
		// [XID] // 0x00000001897FDFA0-0x00000001897FDFE0
		public virtual void ReturnToObjectPool() {} // 0x0000000186B7C3F0-0x0000000186B7C490
		[BlackList] // 0x00000001898086C0-0x0000000189808700
		// [XID] // 0x00000001898086C0-0x0000000189808700
		public virtual void OnPoolAllocated() {} // 0x0000000186B7BDD0-0x0000000186B7BE70
		[BlackList] // 0x0000000189812DC0-0x0000000189812E00
		// [XID] // 0x0000000189812DC0-0x0000000189812E00
		public virtual void OnBeforePoolRecycled() {} // 0x0000000186B7BD30-0x0000000186B7BDD0
	}
}
