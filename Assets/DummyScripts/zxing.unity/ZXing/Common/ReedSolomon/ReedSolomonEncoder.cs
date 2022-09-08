/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Common.ReedSolomon
{
	public sealed class ReedSolomonEncoder // TypeDefIndex: 4588
	{
		// Fields
		private readonly GenericGF field; // 0x10
		private readonly IList<GenericGFPoly> cachedGenerators; // 0x18
	
		// Constructors
		public ReedSolomonEncoder() {} // Dummy constructor
		public ReedSolomonEncoder(GenericGF field) {} // 0x0000000186AFF100-0x0000000186AFF230
	
		// Methods
		private GenericGFPoly buildGenerator(int degree) => default; // 0x0000000186AFF230-0x0000000186AFF5A0
		public void encode(int[] toEncode, int ecBytes) {} // 0x0000000186AFF5A0-0x0000000186AFF840
	}
}
