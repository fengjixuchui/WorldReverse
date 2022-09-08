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
	public abstract class AmortizedUpateHelper : IReusable // TypeDefIndex: 10453
	{
		// Fields
		protected SliceFrameWatch _sliceFrameWatch; // 0x10
		protected int _currentBatchCount; // 0x18
		protected int _targetBatchCount; // 0x1C
	
		// Constructors
		protected AmortizedUpateHelper() {} // 0x00000001853EAA60-0x00000001853EAAD0
	
		// Methods
		// [XID] // 0x00000001899BBA30-0x00000001899BBA50
		public void SetTickMillisecondThreshold(float inMS) {} // 0x00000001853EA970-0x00000001853EAA60
		// [XID] // 0x00000001899D2130-0x00000001899D2150
		public void SetBatchCount(int inCount) {} // 0x00000001853EA8C0-0x00000001853EA970
		// [XID] // 0x00000001899D9820-0x00000001899D9840
		public virtual void BeforeRecycle() {} // 0x00000001853EA810-0x00000001853EA8C0
		public abstract void AmortizedTick(float globalTime, float deltaTime);
	}
}
