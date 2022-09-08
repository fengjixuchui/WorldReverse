/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal class UnknownControllerHat // TypeDefIndex: 3499
	{
		// Fields
		private HatButtons USQZpFcFQqBJUckpyitMKctsvSza; // 0x10
	
		// Nested types
		[CustomClassObfuscation] // 0x000000018966ABA0-0x000000018966AC10
		[CustomObfuscation] // 0x000000018966ABA0-0x000000018966AC10
		// [DefaultMember] // 0x000000018966ABA0-0x000000018966AC10
		public class HatButtons // TypeDefIndex: 3500
		{
			// Fields
			private int[] USQZpFcFQqBJUckpyitMKctsvSza; // 0x10
	
			// Constructors
			public HatButtons() {} // Dummy constructor
			public HatButtons(int[] buttons) {} // 0x0000000185552780-0x00000001855527F0
	
			// Methods
			public void GetNeighbors(int button, out int neighbor1, out int neighbor2) {
				neighbor1 = default;
				neighbor2 = default;
			} // 0x00000001855523B0-0x0000000185552560
			public bool IsCardinal(int button) => default; // 0x0000000185552660-0x00000001855526F0
			public bool IsCorner(int button) => default; // 0x00000001855526F0-0x0000000185552780
			public int IndexOf(int button) => default; // 0x0000000185552560-0x0000000185552660
			public bool Contains(int button) => default; // 0x0000000185552330-0x00000001855523B0
		}
	
		// Constructors
		public UnknownControllerHat() {} // Dummy constructor
		public UnknownControllerHat(HatButtons buttons) {} // 0x0000000185576D70-0x0000000185576DE0
	
		// Methods
		public bool ContainsButtonIndex(int index) => default; // 0x0000000185576B90-0x0000000185576C50
		public bool IsButtonIndexCardinal(int index) => default; // 0x0000000185576CB0-0x0000000185576D70
		public HatButtons GetButtons() => default; // 0x0000000185576C50-0x0000000185576CB0
	}
}
