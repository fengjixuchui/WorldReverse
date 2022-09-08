/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public abstract class SliceFrameJobHandler : ISliceFrameJobHandler // TypeDefIndex: 10631
	{
		// Fields
		protected int _currentIdx; // 0x10
		protected int _totalCount; // 0x14
	
		// Properties
		public int currentHandleIdx { /* [XID] */ /* 0x0000000189A06A30-0x0000000189A06A50 */ get; } // 0x00000001868A5470-0x00000001868A5510 
		public bool bFinished { /* [XID] */ /* 0x0000000189A92BC0-0x0000000189A92BE0 */ get; } // 0x00000001868A53C0-0x00000001868A5470 
		public int totalCount { /* [XID] */ /* 0x00000001895EE5D0-0x00000001895EE5F0 */ get; } // 0x00000001868A5510-0x00000001868A55B0 
	
		// Constructors
		protected SliceFrameJobHandler() {} // 0x00000001868A5360-0x00000001868A53C0
	
		// Methods
		// [XID] // 0x00000001895F5D80-0x00000001895F5DA0
		public void IncreaseHandledCount() {} // 0x00000001868A52C0-0x00000001868A5360
		public abstract void Handle(int i);
		// [XID] // 0x00000001895FD2B0-0x00000001895FD2D0
		public virtual void Dispose() {} // 0x00000001868A5220-0x00000001868A52C0
	}
}
