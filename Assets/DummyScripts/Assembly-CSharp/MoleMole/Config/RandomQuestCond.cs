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
	public class RandomQuestCond : IAutoAllocRecycle // TypeDefIndex: 15963
	{
		// Fields
		protected QuestCondType _type; // 0x10
		protected string[] _param; // 0x18
	
		// Properties
		public QuestCondType type { /* [XID] */ /* 0x0000000189B9DC60-0x0000000189B9DC80 */ get => default; /* [XID] */ /* 0x0000000189BA55D0-0x0000000189BA55F0 */ set {} } // 0x0000000188D5ABA0-0x0000000188D5AC40 0x0000000188D5ACF0-0x0000000188D5ADA0
		public string[] param { /* [XID] */ /* 0x0000000189BAC7B0-0x0000000189BAC7D0 */ get => default; /* [XID] */ /* 0x0000000189BB4050-0x0000000189BB4070 */ set {} } // 0x0000000188D5AB00-0x0000000188D5ABA0 0x0000000188D5AC40-0x0000000188D5ACF0
	
		// Constructors
		public RandomQuestCond() {} // 0x0000000188D5AAA0-0x0000000188D5AB00
	
		// Methods
		// [XID] // 0x0000000189BBB6F0-0x0000000189BBB710
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000188D5A6D0-0x0000000188D5AA00
		// [XID] // 0x0000000189BC3570-0x0000000189BC3590
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C66 */, bool useObjectPool = false /* Metadata: 0x00AF2C6A */) => default; // 0x0000000188D5A220-0x0000000188D5A590
		[BlackList] // 0x0000000189BCACF0-0x0000000189BCAD30
		// [XID] // 0x0000000189BCACF0-0x0000000189BCAD30
		public virtual void AutoAllocTypeFields() {} // 0x0000000188D5A0E0-0x0000000188D5A180
		[BlackList] // 0x0000000189BD5210-0x0000000189BD5250
		// [XID] // 0x0000000189BD5210-0x0000000189BD5250
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188D5A180-0x0000000188D5A220
		[BlackList] // 0x0000000189BDFBC0-0x0000000189BDFC00
		// [XID] // 0x0000000189BDFBC0-0x0000000189BDFC00
		public virtual void ReturnToObjectPool() {} // 0x0000000188D5AA00-0x0000000188D5AAA0
		[BlackList] // 0x00000001895EF660-0x00000001895EF6A0
		// [XID] // 0x00000001895EF660-0x00000001895EF6A0
		public virtual void OnPoolAllocated() {} // 0x0000000188D5A630-0x0000000188D5A6D0
		[BlackList] // 0x00000001895F9D40-0x00000001895F9D80
		// [XID] // 0x00000001895F9D40-0x00000001895F9D80
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188D5A590-0x0000000188D5A630
	}
}
