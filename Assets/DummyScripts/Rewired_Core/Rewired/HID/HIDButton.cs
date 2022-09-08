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
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal class HIDButton : HIDControllerElement // TypeDefIndex: 4029
	{
		// Fields
		public bool rawValue; // 0x20
		public float timestamp; // 0x24
	
		// Constructors
		public HIDButton() {} // Dummy constructor
		public HIDButton(byte reportId, HIDInfo hidInfo) {} // 0x000000018582CB10-0x000000018582CBA0
	
		// Methods
		public void SetValue(bool rawValue, float timestamp) {} // 0x000000018582CA00-0x000000018582CA80
		public override void UpdateValue(NativeBuffer inputReport, float timestamp) {} // 0x000000018582CA80-0x000000018582CB10
	}
}
