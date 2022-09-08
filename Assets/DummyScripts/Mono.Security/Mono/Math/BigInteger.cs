/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Math
{
	public class BigInteger // TypeDefIndex: 1032
	{
		// Fields
		private uint length; // 0x10
		private uint[] data; // 0x18
		internal static readonly uint[] smallPrimes; // 0x00
		private static RandomNumberGenerator rng; // 0x08
	
		// Properties
		private static RandomNumberGenerator Rng { get => default; } // 0x00000001873AAD60-0x00000001873AAE60 
	
		// Nested types
		public enum Sign // TypeDefIndex: 1033
		{
			Negative = -1,
			Zero = 0,
			Positive = 1
		}
	
		public sealed class ModulusRing // TypeDefIndex: 1034
		{
			// Fields
			private BigInteger mod; // 0x10
			private BigInteger constant; // 0x18
	
			// Constructors
			public ModulusRing() {} // Dummy constructor
			public ModulusRing(BigInteger modulus) {} // 0x00000001873BFA30-0x00000001873BFB60
	
			// Methods
			public void BarrettReduction(BigInteger x) {} // 0x00000001873BEF40-0x00000001873BF2D0
			public BigInteger Multiply(BigInteger a, BigInteger b) => default; // 0x00000001873BF590-0x00000001873BF830
			public BigInteger Difference(BigInteger a, BigInteger b) => default; // 0x00000001873BF2D0-0x00000001873BF590
			public BigInteger Pow(BigInteger a, BigInteger k) => default; // 0x00000001873BF830-0x00000001873BF980
			// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
			public BigInteger Pow(uint b, BigInteger exp) => default; // 0x00000001873BF980-0x00000001873BFA30
		}
	
		private sealed class Kernel // TypeDefIndex: 1035
		{
			// Constructors
			public Kernel() {} // Dummy constructor
	
			// Methods
			public static BigInteger AddSameSign(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873B8A50-0x00000001873B8CE0
			public static BigInteger Subtract(BigInteger big, BigInteger small) => default; // 0x00000001873B9FF0-0x00000001873BA250
			public static void MinusEq(BigInteger big, BigInteger small) {} // 0x00000001873B9510-0x00000001873B96E0
			public static void PlusEq(BigInteger bi1, BigInteger bi2) {} // 0x00000001873B9A40-0x00000001873B9CA0
			public static Sign Compare(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873B8CE0-0x00000001873B8F20
			public static uint SingleByteDivideInPlace(BigInteger n, uint d) => default; // 0x00000001873B9EE0-0x00000001873B9FF0
			public static uint DwordMod(BigInteger n, uint d) => default; // 0x00000001873B91B0-0x00000001873B9290
			public static BigInteger[] DwordDivMod(BigInteger n, uint d) => default; // 0x00000001873B8F20-0x00000001873B91B0
			public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873BAC10-0x00000001873BB4A0
			public static BigInteger LeftShift(BigInteger bi, int n) => default; // 0x00000001873B9290-0x00000001873B9510
			public static BigInteger RightShift(BigInteger bi, int n) => default; // 0x00000001873B9CA0-0x00000001873B9EE0
			public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) {} // 0x00000001873B98B0-0x00000001873B9A40
			public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) {} // 0x00000001873B96E0-0x00000001873B98B0
			public static uint modInverse(BigInteger bi, uint modulus) => default; // 0x00000001873BA250-0x00000001873BA380
			public static BigInteger modInverse(BigInteger bi, BigInteger modulus) => default; // 0x00000001873BA380-0x00000001873BAC10
		}
	
		// Constructors
		public BigInteger() {} // Dummy constructor
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public BigInteger(Sign sign, uint len) {} // 0x00000001873AACC0-0x00000001873AAD60
		public BigInteger(BigInteger bi) {} // 0x00000001873AA6A0-0x00000001873AA770
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public BigInteger(BigInteger bi, uint len) {} // 0x00000001873AABA0-0x00000001873AACC0
		public BigInteger(byte[] inData) {} // 0x00000001873AA840-0x00000001873AABA0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public BigInteger(uint ui) {} // 0x00000001873AA770-0x00000001873AA840
		static BigInteger() {} // 0x00000001873AA600-0x00000001873AA6A0
	
		// Methods
		public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) => default; // 0x00000001873A9710-0x00000001873A9900
		public static BigInteger GenerateRandom(int bits) => default; // 0x00000001873A9680-0x00000001873A9710
		public int BitCount() => default; // 0x00000001873A92E0-0x00000001873A93B0
		public bool TestBit(int bitNum) => default; // 0x00000001873AA120-0x00000001873AA230
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public void SetBit(uint bitNum) {} // 0x00000001873A9F50-0x00000001873AA040
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public void SetBit(uint bitNum, bool value) {} // 0x00000001873AA040-0x00000001873AA120
		public int LowestSetBit() => default; // 0x00000001873A9CA0-0x00000001873A9D70
		public byte[] GetBytes() => default; // 0x00000001873A9900-0x00000001873A9A90
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public string ToString(uint radix) => default; // 0x00000001873AA4D0-0x00000001873AA550
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public string ToString(uint radix, string characterSet) => default; // 0x00000001873AA230-0x00000001873AA4D0
		private void Normalize() {} // 0x00000001873A9EA0-0x00000001873A9F50
		public void Clear() {} // 0x00000001873A93B0-0x00000001873A9450
		public override int GetHashCode() => default; // 0x00000001873A9A90-0x00000001873A9B40
		public override string ToString() => default; // 0x00000001873AA550-0x00000001873AA600
		public override bool Equals(object o) => default; // 0x00000001873A9450-0x00000001873A95E0
		public BigInteger ModInverse(BigInteger modulus) => default; // 0x00000001873A9D70-0x00000001873A9DF0
		public BigInteger ModPow(BigInteger exp, BigInteger n) => default; // 0x00000001873A9DF0-0x00000001873A9EA0
		public static BigInteger GeneratePseudoPrime(int bits) => default; // 0x00000001873A95E0-0x00000001873A9680
		public void Incr2() {} // 0x00000001873A9B40-0x00000001873A9CA0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static implicit operator BigInteger(uint value) => default; // 0x00000001873AB380-0x00000001873AB400
		public static implicit operator BigInteger(int value) => default; // 0x00000001873AB2C0-0x00000001873AB380
		public static BigInteger operator +(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873AAE60-0x00000001873AAF70
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873ABB80-0x00000001873ABD70
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static uint operator %(BigInteger bi, uint ui) => default; // 0x00000001873AB7D0-0x00000001873AB850
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873AB730-0x00000001873AB7D0
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873AAF70-0x00000001873AB010
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873AB850-0x00000001873ABB00
		public static BigInteger operator <<(BigInteger bi1, int shiftVal) => default; // 0x00000001873AB5B0-0x00000001873AB630
		public static BigInteger operator >>(BigInteger bi1, int shiftVal) => default; // 0x00000001873ABB00-0x00000001873ABB80
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static bool operator ==(BigInteger bi1, uint ui) => default; // 0x00000001873AB100-0x00000001873AB1C0
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public static bool operator !=(BigInteger bi1, uint ui) => default; // 0x00000001873AB4F0-0x00000001873AB5B0
		public static bool operator ==(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873AB010-0x00000001873AB100
		public static bool operator !=(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873AB400-0x00000001873AB4F0
		public static bool operator >(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873AB240-0x00000001873AB2C0
		public static bool operator <(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873AB6B0-0x00000001873AB730
		public static bool operator >=(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873AB1C0-0x00000001873AB240
		public static bool operator <=(BigInteger bi1, BigInteger bi2) => default; // 0x00000001873AB630-0x00000001873AB6B0
	}
}
