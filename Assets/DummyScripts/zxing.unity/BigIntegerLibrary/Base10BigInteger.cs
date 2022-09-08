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
	internal sealed class Base10BigInteger // TypeDefIndex: 4664
	{
		// Fields
		private static readonly Base10BigInteger Zero; // 0x00
		private static readonly Base10BigInteger One; // 0x08
		private DigitContainer digits; // 0x10
		private int size; // 0x18
		private Sign sign; // 0x1C
	
		// Properties
		internal Sign NumberSign { set {} } // 0x0000000186ADC9B0-0x0000000186ADCA10
	
		// Nested types
		private class DigitContainer // TypeDefIndex: 4665
		{
			// Fields
			private readonly long[][] digits; // 0x10
	
			// Properties
			public long this[int index] { get => default; set {} } // 0x0000000186AEEB20-0x0000000186AEEBF0 0x0000000186AEED50-0x0000000186AEEEB0
	
			// Constructors
			public DigitContainer() {} // 0x0000000186AEE9C0-0x0000000186AEEA50
		}
	
		// Constructors
		public Base10BigInteger() {} // 0x0000000186ADC240-0x0000000186ADC300
		public Base10BigInteger(long n) {} // 0x0000000186ADC3F0-0x0000000186ADC520
		public Base10BigInteger(Base10BigInteger n) {} // 0x0000000186ADC300-0x0000000186ADC3F0
		static Base10BigInteger() {} // 0x0000000186ADC190-0x0000000186ADC240
	
		// Methods
		public bool Equals(Base10BigInteger other) => default; // 0x0000000186ADB2B0-0x0000000186ADB390
		public override bool Equals(object o) => default; // 0x0000000186ADB200-0x0000000186ADB2B0
		public override int GetHashCode() => default; // 0x0000000186ADB390-0x0000000186ADB4D0
		public override string ToString() => default; // 0x0000000186ADC060-0x0000000186ADC190
		public static Base10BigInteger Opposite(Base10BigInteger n) => default; // 0x0000000186ADBCA0-0x0000000186ADBDC0
		public static bool Greater(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADB580-0x0000000186ADB780
		public static bool GreaterOrEqual(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADB4D0-0x0000000186ADB580
		public static bool SmallerOrEqual(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADBDC0-0x0000000186ADBE60
		public static Base10BigInteger Abs(Base10BigInteger n) => default; // 0x0000000186ADAB10-0x0000000186ADABB0
		public static Base10BigInteger Addition(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADADE0-0x0000000186ADB200
		public static Base10BigInteger Multiplication(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADB780-0x0000000186ADB9D0
		public static implicit operator Base10BigInteger(long n) => default; // 0x0000000186ADC6E0-0x0000000186ADC760
		public static bool operator ==(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADC5C0-0x0000000186ADC640
		public static bool operator !=(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADC760-0x0000000186ADC7E0
		public static bool operator >=(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADC640-0x0000000186ADC6E0
		public static bool operator <=(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADC7E0-0x0000000186ADC880
		public static Base10BigInteger operator -(Base10BigInteger n) => default; // 0x0000000186ADC920-0x0000000186ADC9B0
		public static Base10BigInteger operator +(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADC520-0x0000000186ADC5C0
		public static Base10BigInteger operator *(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADC880-0x0000000186ADC920
		private static Base10BigInteger Add(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADABB0-0x0000000186ADADE0
		private static Base10BigInteger Subtract(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADBE60-0x0000000186ADC060
		private static Base10BigInteger Multiply(Base10BigInteger a, Base10BigInteger b) => default; // 0x0000000186ADB9D0-0x0000000186ADBCA0
	}
}
