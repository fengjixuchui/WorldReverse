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

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal abstract class StopwatchBase // TypeDefIndex: 4400
	{
		// Properties
		public abstract double offsetSeconds { get; }
		public abstract long offsetTicks { get; }
		public abstract double elapsedSeconds { get; }
		public abstract double elapsedSecondsRaw { get; }
		public abstract long elapsedMillisecondsRaw { get; }
		public abstract long elapsedTicksRaw { get; }
	
		// Constructors
		protected StopwatchBase() {} // 0x00000001862F6760-0x00000001862F67C0
	
		// Methods
		public abstract void Start();
	}
}
