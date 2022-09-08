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
	public class X509Chain // TypeDefIndex: 1068
	{
		// Fields
		private X509CertificateCollection roots; // 0x10
		private X509CertificateCollection certs; // 0x18
		private X509Certificate _root; // 0x20
		private X509CertificateCollection _chain; // 0x28
		private X509ChainStatusFlags _status; // 0x30
	
		// Properties
		public X509ChainStatusFlags Status { get => default; } // 0x000000018952D910-0x000000018952D970 
		public X509CertificateCollection TrustAnchors { get => default; } // 0x000000018952D970-0x000000018952DA60 
	
		// Constructors
		public X509Chain() {} // 0x000000018952D840-0x000000018952D910
		public X509Chain(X509CertificateCollection chain) {} // 0x000000018952D760-0x000000018952D840
	
		// Methods
		public bool Build(X509Certificate leaf) => default; // 0x000000018952CD30-0x000000018952D0C0
		private bool IsValid(X509Certificate cert) => default; // 0x000000018952D6A0-0x000000018952D760
		private X509Certificate FindCertificateParent(X509Certificate child) => default; // 0x000000018952D0C0-0x000000018952D240
		private X509Certificate FindCertificateRoot(X509Certificate potentialRoot) => default; // 0x000000018952D240-0x000000018952D440
		private bool IsTrusted(X509Certificate potentialTrusted) => default; // 0x000000018952D610-0x000000018952D6A0
		private bool IsParent(X509Certificate child, X509Certificate parent) => default; // 0x000000018952D440-0x000000018952D610
	}
}
