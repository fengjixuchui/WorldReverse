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
	internal abstract class HIDControllerElement // TypeDefIndex: 4025
	{
		// Fields
		public readonly byte reportId; // 0x10
		public readonly HIDInfo hidInfo; // 0x18
	
		// Nested types
		[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
		[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
		internal class HIDInfo // TypeDefIndex: 4026
		{
			// Fields
			public ushort usagePage; // 0x10
			public ushort usage; // 0x12
			public int dataIndex; // 0x14
			public int bitSize; // 0x18
			public int logicalMin; // 0x1C
			public int logicalMax; // 0x20
			public int physicalMin; // 0x24
			public int physicalMax; // 0x28
			public uint units; // 0x2C
			public uint unitsExp; // 0x30
	
			// Constructors
			public HIDInfo() {} // 0x000000018582DDD0-0x000000018582DE30
		}
	
		// Constructors
		protected HIDControllerElement() {} // Dummy constructor
		public HIDControllerElement(byte reportId, HIDInfo hidInfo) {} // 0x000000018582CCE0-0x000000018582CD70
	
		// Methods
		public abstract void UpdateValue(NativeBuffer inputReport, float timestamp);
	}
}
