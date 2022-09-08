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
	internal class HIDAccelerometer : HIDControllerElement // TypeDefIndex: 4027
	{
		// Fields
		public readonly float[] rawValue; // 0x20
		public float timestamp; // 0x28
		public readonly int valueLength; // 0x2C
		private readonly byte[] gFAMGFphEQAPPIsOqIUOiYImMxyK; // 0x30
		private readonly int bzosNyaAYkqqmjdsmYcZCYXPqkG; // 0x38
		private readonly int bKUWnIefrIOAGALIeelSjbpyaaDm; // 0x3C
		private readonly Action<byte[], float[]> LpQqRQdQRXwpWRSAKJEFyQEozHE; // 0x40
	
		// Constructors
		public HIDAccelerometer() {} // Dummy constructor
		public HIDAccelerometer(byte reportId, HIDInfo hidInfo, int valueLength, Action<byte[], float[]> calcValueDelegate) {} // 0x000000018582C680-0x000000018582C780
	
		// Methods
		public override void UpdateValue(NativeBuffer inputReport, float timestamp) {} // 0x000000018582C510-0x000000018582C680
	}
}
