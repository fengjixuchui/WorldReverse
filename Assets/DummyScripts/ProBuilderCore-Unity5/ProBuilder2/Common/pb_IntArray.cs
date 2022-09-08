/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	[Serializable]
	public class pb_IntArray // TypeDefIndex: 3401
	{
		// Fields
		public int[] array; // 0x10
	
		// Properties
		public int this[int i] { get => default; set {} } // 0x0000000186BA3540-0x0000000186BA35D0 0x0000000186BA3770-0x0000000186BA3970
		public int Length { get => default; } // 0x0000000186BA35D0-0x0000000186BA3640 
	
		// Constructors
		public pb_IntArray() {} // Dummy constructor
		public pb_IntArray(int[] intArray) {} // 0x0000000186BA3440-0x0000000186BA34B0
		public pb_IntArray(pb_IntArray intArray) {} // 0x0000000186BA34B0-0x0000000186BA3540
	
		// Methods
		public List<int> ToList() => default; // 0x0000000186BA3330-0x0000000186BA33C0
		public static implicit operator int[](pb_IntArray intArr) => default; // 0x0000000186BA3700-0x0000000186BA3770
		public static explicit operator pb_IntArray(int[] arr) => default; // 0x0000000186BA3640-0x0000000186BA3700
		public override string ToString() => default; // 0x0000000186BA33C0-0x0000000186BA3440
		public bool IsEmpty() => default; // 0x0000000186BA31A0-0x0000000186BA3210
		public static void RemoveEmptyOrNull(ref pb_IntArray[] val) {} // 0x0000000186BA3210-0x0000000186BA3330
	}
}
