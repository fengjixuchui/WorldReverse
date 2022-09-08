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
	public abstract class SFJH_SingleJobBase : ISliceFrameJobHandler // TypeDefIndex: 10630
	{
		// Properties
		public int currentHandleIdx { /* [XID] */ /* 0x00000001898F5A30-0x00000001898F5A50 */ get; } // 0x00000001868A00A0-0x00000001868A0140 
		public int totalCount { /* [XID] */ /* 0x0000000189BBBD90-0x0000000189BBBDB0 */ get; } // 0x00000001868A0140-0x00000001868A0300 
		public bool bFinished { /* [XID] */ /* 0x0000000189A65980-0x0000000189A659A0 */ get; } // 0x00000001868A0000-0x00000001868A00A0 
	
		// Constructors
		protected SFJH_SingleJobBase() {} // 0x000000018689FFA0-0x00000001868A0000
	
		// Methods
		// [XID] // 0x0000000189BC3C30-0x0000000189BC3C50
		public void IncreaseHandledCount() {} // 0x000000018689FF00-0x000000018689FFA0
		public abstract void Handle(int i);
		// [XID] // 0x00000001899F7C20-0x00000001899F7C40
		public virtual void Dispose() {} // 0x000000018689FE60-0x000000018689FF00
	}
}
