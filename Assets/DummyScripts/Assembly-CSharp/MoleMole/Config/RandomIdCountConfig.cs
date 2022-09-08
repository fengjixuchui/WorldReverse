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
	public class RandomIdCountConfig : IAutoAllocRecycle // TypeDefIndex: 15978
	{
		// Fields
		protected string _id; // 0x10
		protected string _count; // 0x18
	
		// Properties
		public string id { /* [XID] */ /* 0x0000000189AAD280-0x0000000189AAD2A0 */ get => default; /* [XID] */ /* 0x0000000189AB4C70-0x0000000189AB4C90 */ set {} } // 0x0000000188D569A0-0x0000000188D56A40 0x0000000188D56AF0-0x0000000188D56BA0
		public string count { /* [XID] */ /* 0x0000000189ABC900-0x0000000189ABC920 */ get => default; /* [XID] */ /* 0x0000000189AC4240-0x0000000189AC4260 */ set {} } // 0x0000000188D56900-0x0000000188D569A0 0x0000000188D56A40-0x0000000188D56AF0
	
		// Constructors
		public RandomIdCountConfig() {} // 0x0000000188D568A0-0x0000000188D56900
	
		// Methods
		// [XID] // 0x0000000189ACB750-0x0000000189ACB770
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000188D56600-0x0000000188D56800
		// [XID] // 0x0000000189AD31A0-0x0000000189AD31C0
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2CCF */, bool useObjectPool = false /* Metadata: 0x00AF2CD3 */) => default; // 0x0000000188D56150-0x0000000188D564C0
		[BlackList] // 0x0000000189ADABC0-0x0000000189ADAC00
		// [XID] // 0x0000000189ADABC0-0x0000000189ADAC00
		public virtual void AutoAllocTypeFields() {} // 0x0000000188D56010-0x0000000188D560B0
		[BlackList] // 0x0000000189AE58E0-0x0000000189AE5920
		// [XID] // 0x0000000189AE58E0-0x0000000189AE5920
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188D560B0-0x0000000188D56150
		[BlackList] // 0x0000000189AF03F0-0x0000000189AF0430
		// [XID] // 0x0000000189AF03F0-0x0000000189AF0430
		public virtual void ReturnToObjectPool() {} // 0x0000000188D56800-0x0000000188D568A0
		[BlackList] // 0x0000000189AFAA20-0x0000000189AFAA60
		// [XID] // 0x0000000189AFAA20-0x0000000189AFAA60
		public virtual void OnPoolAllocated() {} // 0x0000000188D56560-0x0000000188D56600
		[BlackList] // 0x0000000189B04D80-0x0000000189B04DC0
		// [XID] // 0x0000000189B04D80-0x0000000189B04DC0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188D564C0-0x0000000188D56560
	}
}
