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
	public class SubjectAltNameExtension : X509Extension // TypeDefIndex: 1102
	{
		// Fields
		private GeneralNames _names; // 0x28
	
		// Properties
		public string[] DNSNames { get => default; } // 0x0000000186E28170-0x0000000186E281F0 
		public string[] IPAddresses { get => default; } // 0x0000000186E281F0-0x0000000186E28270 
	
		// Constructors
		public SubjectAltNameExtension() {} // Dummy constructor
		public SubjectAltNameExtension(X509Extension extension) {} // 0x0000000186E280F0-0x0000000186E28170
	
		// Methods
		protected override void Decode() {} // 0x0000000186E27F60-0x0000000186E28070
		public override string ToString() => default; // 0x0000000186E28070-0x0000000186E280F0
	}
}
