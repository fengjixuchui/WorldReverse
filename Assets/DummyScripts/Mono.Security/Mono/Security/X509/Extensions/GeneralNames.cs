/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Security;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509.Extensions
{
	internal class GeneralNames // TypeDefIndex: 1097
	{
		// Fields
		private ArrayList rfc822Name; // 0x10
		private ArrayList dnsName; // 0x18
		private ArrayList directoryNames; // 0x20
		private ArrayList uris; // 0x28
		private ArrayList ipAddr; // 0x30
	
		// Properties
		public string[] DNSNames { get => default; } // 0x0000000186E0F460-0x0000000186E0F580 
		public string[] IPAddresses { get => default; } // 0x0000000186E0F580-0x0000000186E0F6A0 
	
		// Constructors
		public GeneralNames() {} // Dummy constructor
		public GeneralNames(ASN1 sequence) {} // 0x0000000186E0EF10-0x0000000186E0F460
	
		// Methods
		public override string ToString() => default; // 0x0000000186E0E3C0-0x0000000186E0EF10
	}
}
