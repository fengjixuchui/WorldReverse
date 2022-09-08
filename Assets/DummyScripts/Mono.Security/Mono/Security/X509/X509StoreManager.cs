/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509
{
	public sealed class X509StoreManager // TypeDefIndex: 1075
	{
		// Fields
		private static X509Stores _userStore; // 0x00
		private static X509Stores _machineStore; // 0x08
	
		// Properties
		public static X509Stores CurrentUser { get => default; } // 0x00000001895302C0-0x00000001895303D0 
		public static X509Stores LocalMachine { get => default; } // 0x00000001895303D0-0x00000001895304F0 
		public static X509CertificateCollection TrustedRootCertificates { get => default; } // 0x00000001895304F0-0x0000000189530630 
	
		// Constructors
		public X509StoreManager() {} // Dummy constructor
	}
}
