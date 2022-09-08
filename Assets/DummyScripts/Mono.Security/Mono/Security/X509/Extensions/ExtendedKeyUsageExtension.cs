/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Security.X509;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509.Extensions
{
	public class ExtendedKeyUsageExtension : X509Extension // TypeDefIndex: 1096
	{
		// Fields
		private ArrayList keyPurpose; // 0x28
	
		// Properties
		public ArrayList KeyPurpose { get => default; } // 0x0000000186E0E360-0x0000000186E0E3C0 
	
		// Constructors
		public ExtendedKeyUsageExtension() {} // Dummy constructor
		public ExtendedKeyUsageExtension(X509Extension extension) {} // 0x0000000186E0E2E0-0x0000000186E0E360
	
		// Methods
		protected override void Decode() {} // 0x0000000186E0D9D0-0x0000000186E0DB40
		protected override void Encode() {} // 0x0000000186E0DB40-0x0000000186E0DE00
		public override string ToString() => default; // 0x0000000186E0DE00-0x0000000186E0E2E0
	}
}
