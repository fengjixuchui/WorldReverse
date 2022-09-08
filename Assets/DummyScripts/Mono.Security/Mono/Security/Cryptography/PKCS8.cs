/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Cryptography
{
	public sealed class PKCS8 // TypeDefIndex: 1055
	{
		// Nested types
		public class PrivateKeyInfo // TypeDefIndex: 1056
		{
			// Fields
			private int _version; // 0x10
			private string _algorithm; // 0x18
			private byte[] _key; // 0x20
			private ArrayList _list; // 0x28
	
			// Properties
			public byte[] PrivateKey { get => default; } // 0x00000001873C2250-0x00000001873C2300 
	
			// Constructors
			public PrivateKeyInfo() {} // 0x00000001873C21C0-0x00000001873C2250
			public PrivateKeyInfo(byte[] data) {} // 0x00000001873C2140-0x00000001873C21C0
	
			// Methods
			private void Decode(byte[] data) {} // 0x00000001873C1BF0-0x00000001873C1F80
			private static byte[] RemoveLeadingZero(byte[] bigInt) => default; // 0x00000001873C2060-0x00000001873C2140
			private static byte[] Normalize(byte[] bigInt, int length) => default; // 0x00000001873C1F80-0x00000001873C2060
			public static RSA DecodeRSA(byte[] keypair) => default; // 0x00000001873C16B0-0x00000001873C1BF0
			public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) => default; // 0x00000001873C1520-0x00000001873C16B0
		}
	
		public class EncryptedPrivateKeyInfo // TypeDefIndex: 1057
		{
			// Fields
			private string _algorithm; // 0x10
			private byte[] _salt; // 0x18
			private int _iterations; // 0x20
			private byte[] _data; // 0x28
	
			// Properties
			public string Algorithm { get => default; } // 0x00000001873B7700-0x00000001873B7760 
			public byte[] EncryptedData { get => default; } // 0x00000001873B7760-0x00000001873B7810 
			public byte[] Salt { get => default; } // 0x00000001873B7870-0x00000001873B7980 
			public int IterationCount { get => default; } // 0x00000001873B7810-0x00000001873B7870 
	
			// Constructors
			public EncryptedPrivateKeyInfo() {} // 0x00000001873B76A0-0x00000001873B7700
			public EncryptedPrivateKeyInfo(byte[] data) {} // 0x00000001873B75E0-0x00000001873B76A0
	
			// Methods
			private void Decode(byte[] data) {} // 0x00000001873B71C0-0x00000001873B75E0
		}
	
		// Constructors
		public PKCS8() {} // Dummy constructor
	}
}
