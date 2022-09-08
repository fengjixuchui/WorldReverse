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
	public class TalkExec : IAutoAllocRecycle // TypeDefIndex: 15965
	{
		// Fields
		protected TalkExecType _type; // 0x10
		protected string[] _param; // 0x18
	
		// Properties
		public TalkExecType type { /* [XID] */ /* 0x0000000189699300-0x0000000189699320 */ get => default; /* [XID] */ /* 0x00000001896A07B0-0x00000001896A07D0 */ set {} } // 0x0000000186B78EB0-0x0000000186B78F50 0x0000000186B79000-0x0000000186B790B0
		public string[] param { /* [XID] */ /* 0x00000001896A7D00-0x00000001896A7D20 */ get => default; /* [XID] */ /* 0x00000001896AF150-0x00000001896AF170 */ set {} } // 0x0000000186B78E10-0x0000000186B78EB0 0x0000000186B78F50-0x0000000186B79000
	
		// Constructors
		public TalkExec() {} // 0x0000000186B78DB0-0x0000000186B78E10
	
		// Methods
		// [XID] // 0x00000001896B66A0-0x00000001896B66C0
		public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000186B789E0-0x0000000186B78D10
		// [XID] // 0x00000001896BD9C0-0x00000001896BD9E0
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C70 */, bool useObjectPool = false /* Metadata: 0x00AF2C74 */) => default; // 0x0000000186B78530-0x0000000186B788A0
		[BlackList] // 0x00000001896C5150-0x00000001896C5190
		// [XID] // 0x00000001896C5150-0x00000001896C5190
		public virtual void AutoAllocTypeFields() {} // 0x0000000186B783F0-0x0000000186B78490
		[BlackList] // 0x00000001896CF970-0x00000001896CF9B0
		// [XID] // 0x00000001896CF970-0x00000001896CF9B0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000186B78490-0x0000000186B78530
		[BlackList] // 0x00000001896D9EB0-0x00000001896D9EF0
		// [XID] // 0x00000001896D9EB0-0x00000001896D9EF0
		public virtual void ReturnToObjectPool() {} // 0x0000000186B78D10-0x0000000186B78DB0
		[BlackList] // 0x00000001896E4430-0x00000001896E4470
		// [XID] // 0x00000001896E4430-0x00000001896E4470
		public virtual void OnPoolAllocated() {} // 0x0000000186B78940-0x0000000186B789E0
		[BlackList] // 0x00000001896EE6F0-0x00000001896EE730
		// [XID] // 0x00000001896EE6F0-0x00000001896EE730
		public virtual void OnBeforePoolRecycled() {} // 0x0000000186B788A0-0x0000000186B78940
	}
}
