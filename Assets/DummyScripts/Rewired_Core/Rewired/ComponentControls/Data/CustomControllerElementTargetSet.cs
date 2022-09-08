/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000189990060-0x00000001899900B0
	public abstract class CustomControllerElementTargetSet // TypeDefIndex: 3536
	{
		// Properties
		internal abstract int targetCount { get; }
		internal abstract CustomControllerElementTarget this[int index] { get => default; }
	
		// Constructors
		protected CustomControllerElementTargetSet() {} // 0x0000000185AA1DF0-0x0000000185AA1E50
	
		// Methods
		internal abstract void ClearElementCaches();
	}
}
