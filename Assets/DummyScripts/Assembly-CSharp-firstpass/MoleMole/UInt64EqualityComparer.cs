/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class UInt64EqualityComparer : IEqualityComparer<ulong> // TypeDefIndex: 7498
	{
		// Nested types
		private struct UInt64Int32sUnion // TypeDefIndex: 7499
		{
			// Fields
			public ulong value64; // 0x00
			public int low32; // 0x00
			public int high32; // 0x04
		}
	
		// Constructors
		public UInt64EqualityComparer() {} // 0x000000018608B750-0x000000018608B7B0
	
		// Methods
		// [XID] // 0x00000001896A5400-0x00000001896A5420
		public bool Equals(ulong x, ulong y) => default; // 0x000000018608B5C0-0x000000018608B690
		// [XID] // 0x00000001896ACCC0-0x00000001896ACCE0
		public int GetHashCode(ulong obj) => default; // 0x000000018608B690-0x000000018608B750
	}
}
