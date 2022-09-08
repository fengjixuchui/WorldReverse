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

namespace Mono.Security.Authenticode
{
	public class PrivateKey // TypeDefIndex: 1046
	{
		// Fields
		private bool encrypted; // 0x10
		private RSA rsa; // 0x18
		private bool weak; // 0x20
		private int keyType; // 0x24
	
		// Properties
		public RSA RSA { get => default; } // 0x00000001873C2CE0-0x00000001873C2D40 
	
		// Constructors
		public PrivateKey() {} // Dummy constructor
		public PrivateKey(byte[] data, string password) {} // 0x00000001873C2BA0-0x00000001873C2CE0
	
		// Methods
		private byte[] DeriveKey(byte[] salt, string password) => default; // 0x00000001873C29F0-0x00000001873C2BA0
		private bool Decode(byte[] pvk, string password) => default; // 0x00000001873C2570-0x00000001873C29F0
		public static PrivateKey CreateFromFile(string filename) => default; // 0x00000001873C2300-0x00000001873C2370
		public static PrivateKey CreateFromFile(string filename, string password) => default; // 0x00000001873C2370-0x00000001873C2570
	}
}
