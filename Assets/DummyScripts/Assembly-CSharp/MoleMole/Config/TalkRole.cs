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
	[LuaCallCSharp] // 0x00000001895F3770-0x00000001895F37B0
	[RecycleType] // 0x00000001895F3770-0x00000001895F37B0
	public class TalkRole : IAutoAllocRecycle // TypeDefIndex: 14899
	{
		// Fields
		private uint _roleId; // 0x10
		protected TalkRoleType _type; // 0x14
		protected string _id; // 0x18
	
		// Properties
		public TalkRoleType type { /* [XID] */ /* 0x0000000189793DC0-0x0000000189793DE0 */ get => default; /* [XID] */ /* 0x000000018979C1F0-0x000000018979C210 */ set {} } // 0x0000000186B7B5E0-0x0000000186B7B680 0x0000000186B7B730-0x0000000186B7B7E0
		public string id { /* [XID] */ /* 0x00000001897A3720-0x00000001897A3740 */ get => default; /* [XID] */ /* 0x00000001897AABA0-0x00000001897AABC0 */ set {} } // 0x0000000186B7B540-0x0000000186B7B5E0 0x0000000186B7B680-0x0000000186B7B730
	
		// Constructors
		public TalkRole() {} // 0x0000000186B7B4E0-0x0000000186B7B540
	
		// Methods
		// [XID] // 0x000000018978C8F0-0x000000018978C910
		public uint GetID(uint mainQuestId = 0 /* Metadata: 0x00AEF94A */) => default; // 0x0000000186B7AF60-0x0000000186B7B0C0
		// [XID] // 0x00000001897B2770-0x00000001897B2790
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000186B7B200-0x0000000186B7B440
		// [XID] // 0x00000001897BA030-0x00000001897BA050
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF94E */, bool useObjectPool = false /* Metadata: 0x00AEF952 */) => default; // 0x0000000186B7ABF0-0x0000000186B7AF60
		[BlackList] // 0x00000001897C2130-0x00000001897C2170
		// [XID] // 0x00000001897C2130-0x00000001897C2170
		public virtual void AutoAllocTypeFields() {} // 0x0000000186B7AAB0-0x0000000186B7AB50
		[BlackList] // 0x00000001897CC8B0-0x00000001897CC8F0
		// [XID] // 0x00000001897CC8B0-0x00000001897CC8F0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000186B7AB50-0x0000000186B7ABF0
		[BlackList] // 0x00000001897D7240-0x00000001897D7280
		// [XID] // 0x00000001897D7240-0x00000001897D7280
		public virtual void ReturnToObjectPool() {} // 0x0000000186B7B440-0x0000000186B7B4E0
		[BlackList] // 0x00000001897E1A40-0x00000001897E1A80
		// [XID] // 0x00000001897E1A40-0x00000001897E1A80
		public virtual void OnPoolAllocated() {} // 0x0000000186B7B160-0x0000000186B7B200
		[BlackList] // 0x00000001897EC5A0-0x00000001897EC5E0
		// [XID] // 0x00000001897EC5A0-0x00000001897EC5E0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000186B7B0C0-0x0000000186B7B160
	}
}
