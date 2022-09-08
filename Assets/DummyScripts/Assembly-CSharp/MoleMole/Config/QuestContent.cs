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
	public class QuestContent : IAutoAllocRecycle // TypeDefIndex: 15964
	{
		// Fields
		protected QuestContentType _type; // 0x10
		protected int[] _param; // 0x18
		protected string _param_str; // 0x20
		protected uint _count; // 0x28
	
		// Properties
		public QuestContentType type { /* [XID] */ /* 0x000000018960EDC0-0x000000018960EDE0 */ get => default; /* [XID] */ /* 0x00000001896163C0-0x00000001896163E0 */ set {} } // 0x0000000188D54200-0x0000000188D542A0 0x0000000188D544B0-0x0000000188D54560
		public int[] param { /* [XID] */ /* 0x000000018961DBF0-0x000000018961DC10 */ get => default; /* [XID] */ /* 0x0000000189625050-0x0000000189625070 */ set {} } // 0x0000000188D540C0-0x0000000188D54160 0x0000000188D54350-0x0000000188D54400
		public string param_str { /* [XID] */ /* 0x000000018962C890-0x000000018962C8B0 */ get => default; /* [XID] */ /* 0x00000001896345F0-0x0000000189634610 */ set {} } // 0x0000000188D54160-0x0000000188D54200 0x0000000188D54400-0x0000000188D544B0
		public uint count { /* [XID] */ /* 0x000000018963BCE0-0x000000018963BD00 */ get => default; /* [XID] */ /* 0x0000000189643440-0x0000000189643460 */ set {} } // 0x0000000188D54020-0x0000000188D540C0 0x0000000188D542A0-0x0000000188D54350
	
		// Constructors
		public QuestContent() {} // 0x0000000188D53FC0-0x0000000188D54020
	
		// Methods
		// [XID] // 0x000000018964AA00-0x000000018964AA20
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000188D53AC0-0x0000000188D53F20
		// [XID] // 0x00000001896522A0-0x00000001896522C0
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C6B */, bool useObjectPool = false /* Metadata: 0x00AF2C6F */) => default; // 0x0000000188D534D0-0x0000000188D53980
		[BlackList] // 0x0000000189659970-0x00000001896599B0
		// [XID] // 0x0000000189659970-0x00000001896599B0
		public virtual void AutoAllocTypeFields() {} // 0x0000000188D53380-0x0000000188D53420
		[BlackList] // 0x0000000189664080-0x00000001896640C0
		// [XID] // 0x0000000189664080-0x00000001896640C0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188D53420-0x0000000188D534D0
		[BlackList] // 0x000000018966EB60-0x000000018966EBA0
		// [XID] // 0x000000018966EB60-0x000000018966EBA0
		public virtual void ReturnToObjectPool() {} // 0x0000000188D53F20-0x0000000188D53FC0
		[BlackList] // 0x00000001896798B0-0x00000001896798F0
		// [XID] // 0x00000001896798B0-0x00000001896798F0
		public virtual void OnPoolAllocated() {} // 0x0000000188D53A20-0x0000000188D53AC0
		[BlackList] // 0x0000000189683D50-0x0000000189683D90
		// [XID] // 0x0000000189683D50-0x0000000189683D90
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188D53980-0x0000000188D53A20
	}
}
