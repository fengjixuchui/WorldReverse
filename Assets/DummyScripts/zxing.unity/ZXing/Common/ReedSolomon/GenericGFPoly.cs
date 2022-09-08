/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Common.ReedSolomon
{
	internal sealed class GenericGFPoly // TypeDefIndex: 4592
	{
		// Fields
		private readonly GenericGF field; // 0x10
		private readonly int[] coefficients; // 0x18
	
		// Properties
		internal int[] Coefficients { get => default; } // 0x0000000186AF67A0-0x0000000186AF6800 
		internal int Degree { get => default; } // 0x0000000186AF6800-0x0000000186AF6870 
		internal bool isZero { get => default; } // 0x0000000186AF6870-0x0000000186AF6900 
	
		// Constructors
		public GenericGFPoly() {} // Dummy constructor
		internal GenericGFPoly(GenericGF field, int[] coefficients) {} // 0x0000000186AF5E40-0x0000000186AF5FF0
	
		// Methods
		internal int getCoefficient(int degree) => default; // 0x0000000186AF6700-0x0000000186AF67A0
		internal GenericGFPoly addOrSubtract(GenericGFPoly other) => default; // 0x0000000186AF5FF0-0x0000000186AF62A0
		internal GenericGFPoly multiply(GenericGFPoly other) => default; // 0x0000000186AF6B00-0x0000000186AF6E40
		internal GenericGFPoly multiplyByMonomial(int degree, int coefficient) => default; // 0x0000000186AF6900-0x0000000186AF6B00
		internal GenericGFPoly[] divide(GenericGFPoly other) => default; // 0x0000000186AF62A0-0x0000000186AF6700
		public override string ToString() => default; // 0x0000000186AF5B70-0x0000000186AF5E40
	}
}
