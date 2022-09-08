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
	public sealed class GenericGF // TypeDefIndex: 4656
	{
		// Fields
		public static GenericGF AZTEC_DATA_12; // 0x00
		public static GenericGF AZTEC_DATA_10; // 0x08
		public static GenericGF AZTEC_DATA_6; // 0x10
		public static GenericGF AZTEC_PARAM; // 0x18
		public static GenericGF QR_CODE_FIELD_256; // 0x20
		public static GenericGF DATA_MATRIX_FIELD_256; // 0x28
		public static GenericGF AZTEC_DATA_8; // 0x30
		public static GenericGF MAXICODE_FIELD_64; // 0x38
		private int[] expTable; // 0x10
		private int[] logTable; // 0x18
		private GenericGFPoly zero; // 0x20
		private GenericGFPoly one; // 0x28
		private readonly int size; // 0x30
		private readonly int primitive; // 0x34
		private readonly int generatorBase; // 0x38
	
		// Properties
		internal GenericGFPoly Zero { get => default; } // 0x0000000186AF7790-0x0000000186AF77F0 
		public int GeneratorBase { get => default; } // 0x0000000186AF7730-0x0000000186AF7790 
	
		// Constructors
		public GenericGF() {} // Dummy constructor
		public GenericGF(int primitive, int size, int genBase) {} // 0x0000000186AF72E0-0x0000000186AF7520
		static GenericGF() {} // 0x0000000186AF70F0-0x0000000186AF72E0
	
		// Methods
		internal GenericGFPoly buildMonomial(int degree, int coefficient) => default; // 0x0000000186AF7580-0x0000000186AF76A0
		internal static int addOrSubtract(int a, int b) => default; // 0x0000000186AF7520-0x0000000186AF7580
		internal int exp(int a) => default; // 0x0000000186AF76A0-0x0000000186AF7730
		internal int log(int a) => default; // 0x0000000186AF78E0-0x0000000186AF79A0
		internal int inverse(int a) => default; // 0x0000000186AF77F0-0x0000000186AF78E0
		internal int multiply(int a, int b) => default; // 0x0000000186AF79A0-0x0000000186AF7AB0
		public override string ToString() => default; // 0x0000000186AF6E40-0x0000000186AF70F0
	}
}
