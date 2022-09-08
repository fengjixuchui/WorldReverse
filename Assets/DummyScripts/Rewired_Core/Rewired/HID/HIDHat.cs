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
	internal class HIDHat : HIDControllerElement // TypeDefIndex: 4047
	{
		// Fields
		public int rawValue; // 0x20
		public float timestamp; // 0x24
		public readonly int byteLength; // 0x28
		public readonly int startIndex; // 0x2C
		public readonly Type type; // 0x30
		private Func<int, int> LpQqRQdQRXwpWRSAKJEFyQEozHE; // 0x38
	
		// Nested types
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public enum Type // TypeDefIndex: 4048
		{
			ArjUpFKKDkOtOldZpRLmmMUFaxP = 0,
			djmWmEhmVdfksZwGfNzZHFuqaoh = 1
		}
	
		// Constructors
		public HIDHat() {} // Dummy constructor
		public HIDHat(byte reportId, HIDInfo hidInfo, Type type) {} // 0x000000018582DD20-0x000000018582DDD0
		public HIDHat(byte reportId, HIDInfo hidInfo, Func<int, int> calcValueDelegate) {} // 0x000000018582DC60-0x000000018582DD20
	
		// Methods
		public override void UpdateValue(NativeBuffer inputReport, float timestamp) {} // 0x000000018582DA40-0x000000018582DC60
	}
}
