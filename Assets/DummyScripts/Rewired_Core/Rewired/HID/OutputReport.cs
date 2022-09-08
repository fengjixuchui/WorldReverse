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

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal struct OutputReport // TypeDefIndex: 4030
	{
		// Fields
		public int reportId; // 0x00
		public IntPtr buffer; // 0x08
		public int bufferLength; // 0x10
		public int reportLength; // 0x14
		public OutputReportOptions options; // 0x18
	
		// Properties
		public bool IsValid { get => default; } // 0x000000018583F370-0x000000018583F380 
	
		// Constructors
		public OutputReport(IntPtr buffer, int bufferLength, int reportLength) : this() {
			reportId = default;
			this.buffer = default;
			this.bufferLength = default;
			this.reportLength = default;
			options = default;
		} // 0x000000018583F2E0-0x000000018583F370
	
		// Methods
		public void Clear() {} // 0x000000018583E620-0x000000018583F240
		public override string ToString() => default; // 0x000000018583F240-0x000000018583F2E0
	}
}
