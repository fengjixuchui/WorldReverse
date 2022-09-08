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
	public class RandomQuestEntranceExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15980
	{
		// Fields
		protected uint _id; // 0x10
		protected uint _weight; // 0x14
		protected uint _templateId; // 0x18
		protected LogicType _filterLogicType; // 0x1C
		// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
		protected RandomQuestFilterConfig[] _filterList; // 0x20
	
		// Properties
		public uint id { /* [XID] */ /* 0x0000000189B97FC0-0x0000000189B97FE0 */ get => default; /* [XID] */ /* 0x0000000189B9F430-0x0000000189B9F450 */ set {} } // 0x0000000186B626E0-0x0000000186B62780 0x0000000186B62A20-0x0000000186B62AD0
		public uint weight { /* [XID] */ /* 0x0000000189BA6C80-0x0000000189BA6CA0 */ get => default; /* [XID] */ /* 0x0000000189BADE20-0x0000000189BADE40 */ set {} } // 0x0000000186B62820-0x0000000186B628C0 0x0000000186B62B80-0x0000000186B62C30
		public uint templateId { /* [XID] */ /* 0x0000000189BB55F0-0x0000000189BB5610 */ get => default; /* [XID] */ /* 0x0000000189BBCD40-0x0000000189BBCD60 */ set {} } // 0x0000000186B62780-0x0000000186B62820 0x0000000186B62AD0-0x0000000186B62B80
		public LogicType filterLogicType { /* [XID] */ /* 0x0000000189BC4980-0x0000000189BC49A0 */ get => default; /* [XID] */ /* 0x0000000189BCC3E0-0x0000000189BCC400 */ set {} } // 0x0000000186B62640-0x0000000186B626E0 0x0000000186B62970-0x0000000186B62A20
		public RandomQuestFilterConfig[] filterList { /* [XID] */ /* 0x0000000189BD3AD0-0x0000000189BD3AF0 */ get => default; /* [XID] */ /* 0x0000000189BDB3E0-0x0000000189BDB400 */ set {} } // 0x0000000186B625A0-0x0000000186B62640 0x0000000186B628C0-0x0000000186B62970
	
		// Constructors
		public RandomQuestEntranceExcelConfig() {} // 0x0000000186B62540-0x0000000186B625A0
	
		// Methods
		// [IDTag] // 0x00000001895E7D10-0x00000001895E7D50
		// [XID] // 0x00000001895E7D10-0x00000001895E7D50
		public virtual bool ParseFromLine(string line) => default; // 0x0000000186B61F70-0x0000000186B624A0
		// [IDTag] // 0x00000001895F2370-0x00000001895F23B0
		// [XID] // 0x00000001895F2370-0x00000001895F23B0
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000186B61AF0-0x0000000186B61F70
		// [XID] // 0x00000001895FCBD0-0x00000001895FCBF0
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CD9 */, bool useObjectPool = false /* Metadata: 0x00AF2CDD */) => default; // 0x0000000186B61460-0x0000000186B619B0
		[BlackList] // 0x0000000189604590-0x00000001896045D0
		// [XID] // 0x0000000189604590-0x00000001896045D0
		public virtual void AutoAllocTypeFields() {} // 0x0000000186B61310-0x0000000186B613B0
		[BlackList] // 0x000000018960ED80-0x000000018960EDC0
		// [XID] // 0x000000018960ED80-0x000000018960EDC0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000186B613B0-0x0000000186B61460
		[BlackList] // 0x00000001896196E0-0x0000000189619720
		// [XID] // 0x00000001896196E0-0x0000000189619720
		public virtual void ReturnToObjectPool() {} // 0x0000000186B624A0-0x0000000186B62540
		[BlackList] // 0x0000000189623A60-0x0000000189623AA0
		// [XID] // 0x0000000189623A60-0x0000000189623AA0
		public virtual void OnPoolAllocated() {} // 0x0000000186B61A50-0x0000000186B61AF0
		[BlackList] // 0x000000018962E2B0-0x000000018962E2F0
		// [XID] // 0x000000018962E2B0-0x000000018962E2F0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000186B619B0-0x0000000186B61A50
	}
}
