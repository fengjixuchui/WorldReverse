/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	internal class HIDTouchpad : HIDControllerElement // TypeDefIndex: 4055
	{
		// Fields
		private TouchpadInfo YrINEQzKlfFBbUSiOJDTprrZsWe; // 0x20
		private Queue<TouchData> KSfAqSqKULLUOnebTLQOitlZurF; // 0x28
		private TouchData[] nYDFhaKzpXphFXTOJIPMyXzgvfc; // 0x30
		private Action<NativeBuffer, TouchData[]> LpQqRQdQRXwpWRSAKJEFyQEozHE; // 0x38
		public TouchData[] values; // 0x40
	
		// Nested types
		[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
		[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
		internal class TouchpadInfo // TypeDefIndex: 4056
		{
			// Fields
			public int maxTouches; // 0x10
			public int minX; // 0x14
			public int maxX; // 0x18
			public int minY; // 0x1C
			public int maxY; // 0x20
			public bool invertY; // 0x24
			public bool reverseY; // 0x25
	
			// Constructors
			public TouchpadInfo() {} // Dummy constructor
			public TouchpadInfo(int maxTouches, int minX, int maxX, int minY, int maxY, bool invertY, bool reverseY) {} // 0x0000000185841A50-0x0000000185841B00
	
			// Methods
			public void CalculateTouch(ref TouchData data) {} // 0x0000000185841830-0x0000000185841A50
		}
	
		[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
		[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
		internal struct TouchData // TypeDefIndex: 4057
		{
			// Fields
			public int touchId; // 0x00
			public float timeStamp; // 0x04
			public bool isTouching; // 0x08
			public int positionRawX; // 0x0C
			public int positionRawY; // 0x10
			public float positionX; // 0x14
			public float positionY; // 0x18
			public int positionAbsX; // 0x1C
			public int positionAbsY; // 0x20
	
			// Methods
			public void Clear() {} // 0x00000001858417A0-0x0000000185841830
		}
	
		// Constructors
		public HIDTouchpad() {} // Dummy constructor
		public HIDTouchpad(byte reportId, TouchpadInfo info, HIDInfo hidInfo, Action<NativeBuffer, TouchData[]> calcValueDelegate) {} // 0x000000018582EB80-0x000000018582EE10
	
		// Methods
		public override void UpdateValue(NativeBuffer inputReport, float timestamp) {} // 0x000000018582E960-0x000000018582EB80
		public void ProcessQueue() {} // 0x000000018582E670-0x000000018582E960
		public bool IsTouching(int touchId) => default; // 0x000000018582E560-0x000000018582E670
	}
}
