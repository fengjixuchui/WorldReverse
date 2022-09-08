/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Mono.Security;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509
{
	public class X509Extension // TypeDefIndex: 1072
	{
		// Fields
		protected string extnOid; // 0x10
		protected bool extnCritical; // 0x18
		protected ASN1 extnValue; // 0x20
	
		// Properties
		public string Oid { get => default; } // 0x00000001895301E0-0x0000000189530240 
		public bool Critical { get => default; } // 0x0000000189530180-0x00000001895301E0 
		public ASN1 Value { get => default; } // 0x0000000189530240-0x00000001895302C0 
	
		// Constructors
		public X509Extension() {} // Dummy constructor
		public X509Extension(ASN1 asn1) {} // 0x000000018952FE80-0x0000000189530180
		public X509Extension(X509Extension extension) {} // 0x000000018952FD00-0x000000018952FE80
	
		// Methods
		protected virtual void Decode() {} // 0x000000018952F6B0-0x000000018952F700
		protected virtual void Encode() {} // 0x000000018952F700-0x000000018952F750
		public override bool Equals(object obj) => default; // 0x000000018952F750-0x000000018952F910
		public override int GetHashCode() => default; // 0x000000018952F910-0x000000018952F990
		private void WriteLine(StringBuilder sb, int n, int pos) {} // 0x000000018952FAC0-0x000000018952FD00
		public override string ToString() => default; // 0x000000018952F990-0x000000018952FAC0
	}
}
