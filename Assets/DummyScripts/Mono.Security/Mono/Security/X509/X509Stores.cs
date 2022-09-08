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
	public class X509Stores // TypeDefIndex: 1076
	{
		// Fields
		private string _storePath; // 0x10
		private X509Store _trusted; // 0x18
	
		// Properties
		public X509Store TrustedRoot { get => default; } // 0x0000000189531070-0x0000000189531150 
	
		// Constructors
		public X509Stores() {} // Dummy constructor
		internal X509Stores(string path) {} // 0x0000000189531000-0x0000000189531070
	
		// Methods
		public X509Store Open(string storeName, bool create) => default; // 0x0000000189530ED0-0x0000000189531000
	}
}
