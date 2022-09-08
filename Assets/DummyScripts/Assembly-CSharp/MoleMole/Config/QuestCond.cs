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
	public class QuestCond : IAutoAllocRecycle // TypeDefIndex: 14894
	{
		// Fields
		protected QuestCondType _type; // 0x10
		protected int[] _param; // 0x18
	
		// Properties
		public QuestCondType type { /* [XID] */ /* 0x000000018996FBE0-0x000000018996FC00 */ get => default; /* [XID] */ /* 0x0000000189977A60-0x0000000189977A80 */ set {} } // 0x0000000188D53180-0x0000000188D53220 0x0000000188D532D0-0x0000000188D53380
		public int[] param { /* [XID] */ /* 0x000000018997EC20-0x000000018997EC40 */ get => default; /* [XID] */ /* 0x0000000189986510-0x0000000189986530 */ set {} } // 0x0000000188D530E0-0x0000000188D53180 0x0000000188D53220-0x0000000188D532D0
	
		// Constructors
		public QuestCond() {} // 0x0000000188D53080-0x0000000188D530E0
	
		// Methods
		// [XID] // 0x0000000189960F80-0x0000000189960FA0
		public bool IsValid(uint mainQuestId) => default; // 0x0000000188D528E0-0x0000000188D52A30
		// [XID] // 0x0000000189968700-0x0000000189968720
		public QuestCondEx ToEx() => default; // 0x0000000188D52F90-0x0000000188D53080
		// [XID] // 0x000000018998E1A0-0x000000018998E1C0
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000188D52B70-0x0000000188D52EF0
		// [XID] // 0x0000000189995BD0-0x0000000189995BF0
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF931 */, bool useObjectPool = false /* Metadata: 0x00AEF935 */) => default; // 0x0000000188D52570-0x0000000188D528E0
		[BlackList] // 0x000000018999D670-0x000000018999D6B0
		// [XID] // 0x000000018999D670-0x000000018999D6B0
		public virtual void AutoAllocTypeFields() {} // 0x0000000188D52430-0x0000000188D524D0
		[BlackList] // 0x00000001899A81A0-0x00000001899A81E0
		// [XID] // 0x00000001899A81A0-0x00000001899A81E0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188D524D0-0x0000000188D52570
		[BlackList] // 0x00000001899B2C50-0x00000001899B2C90
		// [XID] // 0x00000001899B2C50-0x00000001899B2C90
		public virtual void ReturnToObjectPool() {} // 0x0000000188D52EF0-0x0000000188D52F90
		[BlackList] // 0x00000001899BCFF0-0x00000001899BD030
		// [XID] // 0x00000001899BCFF0-0x00000001899BD030
		public virtual void OnPoolAllocated() {} // 0x0000000188D52AD0-0x0000000188D52B70
		[BlackList] // 0x00000001899C77D0-0x00000001899C7810
		// [XID] // 0x00000001899C77D0-0x00000001899C7810
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188D52A30-0x0000000188D52AD0
	}
}
