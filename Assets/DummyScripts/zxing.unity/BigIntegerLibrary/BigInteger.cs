/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace BigIntegerLibrary
{
	internal sealed class BigInteger : IEquatable<BigIntegerLibrary.BigInteger>, IComparable, IComparable<BigIntegerLibrary.BigInteger> // TypeDefIndex: 4609
	{
		// Fields
		public static readonly BigInteger Zero; // 0x00
		public static readonly BigInteger One; // 0x08
		public static readonly BigInteger Two; // 0x10
		public static readonly BigInteger Ten; // 0x18
		private DigitContainer digits; // 0x10
		private int size; // 0x18
		private Sign sign; // 0x1C
	
		// Nested types
		private class DigitContainer // TypeDefIndex: 4610
		{
			// Fields
			private readonly long[][] digits; // 0x10
	
			// Properties
			public long this[int index] { get => default; set {} } // 0x0000000186AEEA50-0x0000000186AEEB20 0x0000000186AEEBF0-0x0000000186AEED50
	
			// Constructors
			public DigitContainer() {} // 0x0000000186AEE930-0x0000000186AEE9C0
		}
	
		// Constructors
		public BigInteger() {} // 0x0000000186AE0060-0x0000000186AE0120
		public BigInteger(long n) {} // 0x0000000186ADFE50-0x0000000186ADFF70
		public BigInteger(BigInteger n) {} // 0x0000000186ADFF70-0x0000000186AE0060
		public BigInteger(string numberString) {} // 0x0000000186AE0120-0x0000000186AE0390
		static BigInteger() {} // 0x0000000186ADFD40-0x0000000186ADFE50
	
		// Methods
		public bool Equals(BigInteger other) => default; // 0x0000000186ADE540-0x0000000186ADE620
		public override bool Equals(object o) => default; // 0x0000000186ADE490-0x0000000186ADE540
		public override int GetHashCode() => default; // 0x0000000186ADE620-0x0000000186ADE760
		public override string ToString() => default; // 0x0000000186ADFA20-0x0000000186ADFBD0
		public static BigInteger Parse(string str) => default; // 0x0000000186ADF230-0x0000000186ADF2B0
		public int CompareTo(BigInteger other) => default; // 0x0000000186ADD960-0x0000000186ADDA20
		public int CompareTo(object obj) => default; // 0x0000000186ADD880-0x0000000186ADD960
		public static BigInteger Opposite(BigInteger n) => default; // 0x0000000186ADF110-0x0000000186ADF230
		public static bool Greater(BigInteger a, BigInteger b) => default; // 0x0000000186ADE810-0x0000000186ADEA10
		public static bool GreaterOrEqual(BigInteger a, BigInteger b) => default; // 0x0000000186ADE760-0x0000000186ADE810
		public static bool Smaller(BigInteger a, BigInteger b) => default; // 0x0000000186ADF350-0x0000000186ADF3F0
		public static bool SmallerOrEqual(BigInteger a, BigInteger b) => default; // 0x0000000186ADF2B0-0x0000000186ADF350
		public static BigInteger Abs(BigInteger n) => default; // 0x0000000186ADD1D0-0x0000000186ADD270
		public static BigInteger Addition(BigInteger a, BigInteger b) => default; // 0x0000000186ADD460-0x0000000186ADD880
		public static BigInteger Subtraction(BigInteger a, BigInteger b) => default; // 0x0000000186ADF5F0-0x0000000186ADFA20
		public static BigInteger Multiplication(BigInteger a, BigInteger b) => default; // 0x0000000186ADEC20-0x0000000186ADEE70
		public static BigInteger Division(BigInteger a, BigInteger b) => default; // 0x0000000186ADE100-0x0000000186ADE490
		public static BigInteger Modulo(BigInteger a, BigInteger b) => default; // 0x0000000186ADEA10-0x0000000186ADEC20
		public static implicit operator BigInteger(long n) => default; // 0x0000000186AE05F0-0x0000000186AE0670
		public static bool operator ==(BigInteger a, BigInteger b) => default; // 0x0000000186AE04D0-0x0000000186AE0550
		public static bool operator !=(BigInteger a, BigInteger b) => default; // 0x0000000186AE0670-0x0000000186AE06F0
		public static bool operator <(BigInteger a, BigInteger b) => default; // 0x0000000186AE0790-0x0000000186AE0830
		public static bool operator >=(BigInteger a, BigInteger b) => default; // 0x0000000186AE0550-0x0000000186AE05F0
		public static bool operator <=(BigInteger a, BigInteger b) => default; // 0x0000000186AE06F0-0x0000000186AE0790
		public static BigInteger operator -(BigInteger n) => default; // 0x0000000186AE0970-0x0000000186AE0A00
		public static BigInteger operator +(BigInteger a, BigInteger b) => default; // 0x0000000186AE0390-0x0000000186AE0430
		public static BigInteger operator -(BigInteger a, BigInteger b) => default; // 0x0000000186AE08D0-0x0000000186AE0970
		public static BigInteger operator *(BigInteger a, BigInteger b) => default; // 0x0000000186AE0830-0x0000000186AE08D0
		public static BigInteger operator /(BigInteger a, BigInteger b) => default; // 0x0000000186AE0430-0x0000000186AE04D0
		private static BigInteger Add(BigInteger a, BigInteger b) => default; // 0x0000000186ADD270-0x0000000186ADD460
		private static BigInteger Subtract(BigInteger a, BigInteger b) => default; // 0x0000000186ADF3F0-0x0000000186ADF5F0
		private static BigInteger Multiply(BigInteger a, BigInteger b) => default; // 0x0000000186ADEE70-0x0000000186ADF110
		private static BigInteger DivideByOneDigitNumber(BigInteger a, long b) => default; // 0x0000000186ADDFA0-0x0000000186ADE100
		private static BigInteger DivideByBigNumber(BigInteger a, BigInteger b) => default; // 0x0000000186ADDCD0-0x0000000186ADDFA0
		private static bool DivideByBigNumberSmaller(BigInteger r, BigInteger dq, int k, int m) => default; // 0x0000000186ADDB80-0x0000000186ADDCD0
		private static void Difference(BigInteger r, BigInteger dq, int k, int m) {} // 0x0000000186ADDA20-0x0000000186ADDB80
		private static long Trial(BigInteger r, BigInteger d, int k, int m) => default; // 0x0000000186ADFBD0-0x0000000186ADFD40
	}
}
