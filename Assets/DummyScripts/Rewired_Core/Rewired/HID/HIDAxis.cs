/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Classes.Data;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal class HIDAxis : HIDControllerElement // TypeDefIndex: 4028
	{
		// Fields
		public int rawValue; // 0x20
		public float timestamp; // 0x24
		public readonly int byteLength; // 0x28
		public readonly int startIndex; // 0x2C
		public readonly bool isSigned; // 0x30
		public readonly int minValue; // 0x34
		public readonly int maxValue; // 0x38
		public readonly int zeroValue; // 0x3C
	
		// Constructors
		public HIDAxis() {} // Dummy constructor
		public HIDAxis(byte reportId, HIDInfo hidInfo, bool isSigned, int zeroValue) {} // 0x000000018582C920-0x000000018582CA00
	
		// Methods
		public override void UpdateValue(NativeBuffer inputReport, float timestamp) {} // 0x000000018582C780-0x000000018582C920
	}
}
