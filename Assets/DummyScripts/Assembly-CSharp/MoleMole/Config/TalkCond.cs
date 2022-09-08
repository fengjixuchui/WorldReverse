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
	public class TalkCond : IAutoAllocRecycle // TypeDefIndex: 14895
	{
		// Fields
		protected QuestCondType _type; // 0x10
		protected string[] _param; // 0x18
	
		// Properties
		public QuestCondType type { /* [XID] */ /* 0x00000001899FA330-0x00000001899FA350 */ get => default; /* [XID] */ /* 0x0000000189A016B0-0x0000000189A016D0 */ set {} } // 0x0000000186B71700-0x0000000186B717A0 0x0000000186B71850-0x0000000186B71900
		public string[] param { /* [XID] */ /* 0x0000000189A09130-0x0000000189A09150 */ get => default; /* [XID] */ /* 0x0000000189A10610-0x0000000189A10630 */ set {} } // 0x0000000186B71660-0x0000000186B71700 0x0000000186B717A0-0x0000000186B71850
	
		// Constructors
		public TalkCond() {} // 0x0000000186B71600-0x0000000186B71660
	
		// Methods
		// [XID] // 0x00000001899DC450-0x00000001899DC470
		public bool IsValid(uint mainQuestId, uint npcConfigId, uint talkId) => default; // 0x0000000186B70A60-0x0000000186B70E50
		// [XID] // 0x00000001899E3C70-0x00000001899E3C90
		public uint GetGivingId() => default; // 0x0000000186B70970-0x0000000186B70A60
		// [XID] // 0x00000001899EB080-0x00000001899EB0A0
		public TalkCondEx ToEx() => default; // 0x0000000186B71510-0x0000000186B71600
		// [XID] // 0x00000001899F2CE0-0x00000001899F2D00
		public static TalkCondEx[] ToExList(TalkCond[] srcList, TalkCondEx[] tarList = null) => default; // 0x0000000186B71360-0x0000000186B71510
		// [XID] // 0x0000000189A17C50-0x0000000189A17C70
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000186B70F90-0x0000000186B712C0
		// [XID] // 0x0000000189A1F210-0x0000000189A1F230
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF936 */, bool useObjectPool = false /* Metadata: 0x00AEF93A */) => default; // 0x0000000186B70600-0x0000000186B70970
		[BlackList] // 0x0000000189A267C0-0x0000000189A26800
		// [XID] // 0x0000000189A267C0-0x0000000189A26800
		public virtual void AutoAllocTypeFields() {} // 0x0000000186B704C0-0x0000000186B70560
		[BlackList] // 0x0000000189A30BF0-0x0000000189A30C30
		// [XID] // 0x0000000189A30BF0-0x0000000189A30C30
		public virtual void AutoRecycleTypeFields() {} // 0x0000000186B70560-0x0000000186B70600
		[BlackList] // 0x0000000189A3B3C0-0x0000000189A3B400
		// [XID] // 0x0000000189A3B3C0-0x0000000189A3B400
		public virtual void ReturnToObjectPool() {} // 0x0000000186B712C0-0x0000000186B71360
		[BlackList] // 0x0000000189A45C20-0x0000000189A45C60
		// [XID] // 0x0000000189A45C20-0x0000000189A45C60
		public virtual void OnPoolAllocated() {} // 0x0000000186B70EF0-0x0000000186B70F90
		[BlackList] // 0x0000000189A50440-0x0000000189A50480
		// [XID] // 0x0000000189A50440-0x0000000189A50480
		public virtual void OnBeforePoolRecycled() {} // 0x0000000186B70E50-0x0000000186B70EF0
	}
}
