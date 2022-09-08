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

namespace Mono.Security.X509
{
	public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 1073
	{
		// Fields
		private bool readOnly; // 0x18
	
		// Properties
		public X509Extension this[string oid] { get => default; } // 0x000000018952F5F0-0x000000018952F6B0 
	
		// Constructors
		public X509ExtensionCollection() {} // 0x000000018952F410-0x000000018952F470
		public X509ExtensionCollection(ASN1 asn1) {} // 0x000000018952F470-0x000000018952F5F0
	
		// Methods
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018952F380-0x000000018952F410
		public int IndexOf(string oid) => default; // 0x000000018952F1B0-0x000000018952F380
	}
}
