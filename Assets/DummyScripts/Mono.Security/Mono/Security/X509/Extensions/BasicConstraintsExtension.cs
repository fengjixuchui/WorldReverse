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
	public class BasicConstraintsExtension : X509Extension // TypeDefIndex: 1095
	{
		// Fields
		private bool cA; // 0x28
		private int pathLenConstraint; // 0x2C
	
		// Properties
		public bool CertificateAuthority { get => default; } // 0x0000000186E0CCB0-0x0000000186E0CD10 
	
		// Constructors
		public BasicConstraintsExtension() {} // Dummy constructor
		public BasicConstraintsExtension(X509Extension extension) {} // 0x0000000186E0CC30-0x0000000186E0CCB0
	
		// Methods
		protected override void Decode() {} // 0x0000000186E0C7A0-0x0000000186E0C940
		protected override void Encode() {} // 0x0000000186E0C940-0x0000000186E0CAC0
		public override string ToString() => default; // 0x0000000186E0CAC0-0x0000000186E0CC30
	}
}
