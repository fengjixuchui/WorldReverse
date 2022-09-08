/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Security.X509;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509.Extensions
{
	public class KeyUsageExtension : X509Extension // TypeDefIndex: 1099
	{
		// Fields
		private int kubits; // 0x28
	
		// Constructors
		public KeyUsageExtension() {} // Dummy constructor
		public KeyUsageExtension(X509Extension extension) {} // 0x0000000186E10F60-0x0000000186E10FE0
	
		// Methods
		protected override void Decode() {} // 0x0000000186E106D0-0x0000000186E10820
		protected override void Encode() {} // 0x0000000186E10820-0x0000000186E10A90
		public bool Support(KeyUsages usage) => default; // 0x0000000186E10A90-0x0000000186E10B70
		public override string ToString() => default; // 0x0000000186E10B70-0x0000000186E10F60
	}
}
