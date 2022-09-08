/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public abstract class InputDeviceManager // TypeDefIndex: 7637
	{
		// Fields
		protected List<InputDevice> devices; // 0x10
	
		// Constructors
		protected InputDeviceManager() {} // 0x00000001870CAF50-0x00000001870CAFE0
	
		// Methods
		public abstract void Update(ulong updateTick, float deltaTime);
		// [XID] // 0x0000000189B2EAB0-0x0000000189B2EAD0
		public virtual void Destroy() {} // 0x00000001870CAEB0-0x00000001870CAF50
	}
}
