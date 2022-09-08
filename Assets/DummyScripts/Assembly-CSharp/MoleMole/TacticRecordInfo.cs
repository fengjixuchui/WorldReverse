/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
	public class TacticRecordInfo : IAutoAllocRecycle // TypeDefIndex: 20337
	{
		// Fields
		private static readonly int RECORD_MASK; // 0x00
		private int record; // 0x10
	
		// Constructors
		public TacticRecordInfo() {} // 0x0000000182B1C9F0-0x0000000182B1CA50
		static TacticRecordInfo() {} // 0x0000000182B1C990-0x0000000182B1C9F0
	
		// Methods
		[BlackList] // 0x0000000189BAC190-0x0000000189BAC1D0
		// [XID] // 0x0000000189BAC190-0x0000000189BAC1D0
		public virtual void AutoAllocTypeFields() {} // 0x0000000182B1C300-0x0000000182B1C3A0
		[BlackList] // 0x0000000189BB67B0-0x0000000189BB67F0
		// [XID] // 0x0000000189BB67B0-0x0000000189BB67F0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000182B1C3A0-0x0000000182B1C440
		[BlackList] // 0x0000000189BC13E0-0x0000000189BC1420
		// [XID] // 0x0000000189BC13E0-0x0000000189BC1420
		public virtual void ReturnToObjectPool() {} // 0x0000000182B1C740-0x0000000182B1C7E0
		[BlackList] // 0x0000000189BCBD20-0x0000000189BCBD60
		// [XID] // 0x0000000189BCBD20-0x0000000189BCBD60
		public virtual void OnPoolAllocated() {} // 0x0000000182B1C6A0-0x0000000182B1C740
		[BlackList] // 0x0000000189BD6180-0x0000000189BD61C0
		// [XID] // 0x0000000189BD6180-0x0000000189BD61C0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000182B1C600-0x0000000182B1C6A0
		// [XID] // 0x00000001895E5E90-0x00000001895E5EB0
		public void PushTactic(AITactic tactic) {} // 0x0000000182B1C4B0-0x0000000182B1C560
		// [XID] // 0x00000001897D93A0-0x00000001897D93C0
		public void Reset() {} // 0x0000000182B1C560-0x0000000182B1C600
		// [XID] // 0x00000001895F4EF0-0x00000001895F4F10
		public override string ToString() => default; // 0x0000000182B1C7E0-0x0000000182B1C990
	}
}
