/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal class ButtonLoopSet : UpdateLoopDataSet<Rewired.ButtonLoopSet.ButtonData> // TypeDefIndex: 3513
	{
		// Fields
		public readonly int buttonCount; // 0x38
	
		// Nested types
		[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
		[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
		public class ButtonData // TypeDefIndex: 3514
		{
			// Fields
			public readonly UpdateLoopType updateLoop; // 0x10
			public readonly bool[] values; // 0x18
			public readonly bool[] wasTrueThisFrame; // 0x20
			private bool[] yLcKyplATDtKpQJbbiiakCnWHNWK; // 0x28
			private int xiHhuAwNmZupzBiSwIQaUwPddBu; // 0x30
	
			// Properties
			public bool[] effectiveValue { get => default; } // 0x0000000185A9A420-0x0000000185A9A490 
	
			// Constructors
			public ButtonData() {} // Dummy constructor
			public ButtonData(int count, UpdateLoopType updateLoop) {} // 0x0000000185A9A320-0x0000000185A9A420
	
			// Methods
			public void SetValue(int index, bool value) {} // 0x0000000185A9A1A0-0x0000000185A9A320
			public void ClearWasTrueThisFrame() {} // 0x0000000185A99BF0-0x0000000185A99D30
			public void Clear() {} // 0x0000000185A99D30-0x0000000185A99E50
			public void Import(ButtonData source) {} // 0x0000000185A99E50-0x0000000185A9A0C0
			private void RMIeREvbpeqeiLrGQwrVlkuuGFx() {} // 0x0000000185A9A0C0-0x0000000185A9A1A0
		}
	
		// Constructors
		public ButtonLoopSet() {} // Dummy constructor
		public ButtonLoopSet(UpdateLoopSetting updateLoops, int buttonCount) {} // 0x0000000185A9A7E0-0x0000000185A9A8F0
	
		// Methods
		public void SetValue(int index, bool value, float timestamp) {} // 0x0000000185A9A6E0-0x0000000185A9A7E0
		public void Clear() {} // 0x0000000185A9A490-0x0000000185A9A570
		public void Import(ButtonLoopSet set) {} // 0x0000000185A9A570-0x0000000185A9A6E0
	}
}
