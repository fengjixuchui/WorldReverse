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

namespace Mono.Security.Cryptography
{
	public sealed class PKCS1 // TypeDefIndex: 1054
	{
		// Fields
		private static byte[] emptySHA1; // 0x00
		private static byte[] emptySHA256; // 0x08
		private static byte[] emptySHA384; // 0x10
		private static byte[] emptySHA512; // 0x18
	
		// Constructors
		public PKCS1() {} // Dummy constructor
		static PKCS1() {} // 0x00000001873C0740-0x00000001873C08B0
	
		// Methods
		private static bool Compare(byte[] array1, byte[] array2) => default; // 0x00000001873BFB60-0x00000001873BFC50
		public static byte[] I2OSP(byte[] x, int size) => default; // 0x00000001873BFFF0-0x00000001873C00C0
		public static byte[] OS2IP(byte[] x) => default; // 0x00000001873C00C0-0x00000001873C01D0
		public static byte[] RSASP1(RSA rsa, byte[] m) => default; // 0x00000001873C01D0-0x00000001873C0260
		public static byte[] RSAVP1(RSA rsa, byte[] s) => default; // 0x00000001873C0260-0x00000001873C02F0
		public static byte[] Sign_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue) => default; // 0x00000001873C02F0-0x00000001873C0400
		public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature) => default; // 0x00000001873C0680-0x00000001873C0740
		public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) => default; // 0x00000001873C0400-0x00000001873C0680
		public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) => default; // 0x00000001873BFC50-0x00000001873BFFF0
	}
}
