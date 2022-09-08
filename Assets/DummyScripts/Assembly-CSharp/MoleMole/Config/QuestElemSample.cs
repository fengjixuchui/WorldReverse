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
	public class QuestElemSample : IAutoAllocRecycle // TypeDefIndex: 15985
	{
		// Fields
		protected string _type; // 0x10
		protected string _content; // 0x18
	
		// Properties
		public string type { /* [XID] */ /* 0x000000018981D8B0-0x000000018981D8D0 */ get => default; /* [XID] */ /* 0x0000000189824DC0-0x0000000189824DE0 */ set {} } // 0x0000000188D54EF0-0x0000000188D54F90 0x0000000188D55040-0x0000000188D550F0
		public string content { /* [XID] */ /* 0x000000018982C7B0-0x000000018982C7D0 */ get => default; /* [XID] */ /* 0x0000000189833CC0-0x0000000189833CE0 */ set {} } // 0x0000000188D54E50-0x0000000188D54EF0 0x0000000188D54F90-0x0000000188D55040
	
		// Constructors
		public QuestElemSample() {} // 0x0000000188D54DF0-0x0000000188D54E50
	
		// Methods
		// [XID] // 0x000000018983B280-0x000000018983B2A0
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000188D54B50-0x0000000188D54D50
		// [XID] // 0x0000000189842B00-0x0000000189842B20
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CFC */, bool useObjectPool = false /* Metadata: 0x00AF2D00 */) => default; // 0x0000000188D546A0-0x0000000188D54A10
		[BlackList] // 0x0000000189849E90-0x0000000189849ED0
		// [XID] // 0x0000000189849E90-0x0000000189849ED0
		public virtual void AutoAllocTypeFields() {} // 0x0000000188D54560-0x0000000188D54600
		[BlackList] // 0x0000000189853F20-0x0000000189853F60
		// [XID] // 0x0000000189853F20-0x0000000189853F60
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188D54600-0x0000000188D546A0
		[BlackList] // 0x000000018985E0D0-0x000000018985E110
		// [XID] // 0x000000018985E0D0-0x000000018985E110
		public virtual void ReturnToObjectPool() {} // 0x0000000188D54D50-0x0000000188D54DF0
		[BlackList] // 0x0000000189868B50-0x0000000189868B90
		// [XID] // 0x0000000189868B50-0x0000000189868B90
		public virtual void OnPoolAllocated() {} // 0x0000000188D54AB0-0x0000000188D54B50
		[BlackList] // 0x0000000189872E90-0x0000000189872ED0
		// [XID] // 0x0000000189872E90-0x0000000189872ED0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188D54A10-0x0000000188D54AB0
	}
}
