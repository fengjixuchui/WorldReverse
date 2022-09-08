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
using System.Security.Cryptography;
using Mono.Security;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509
{
	// [DefaultMember] // 0x0000000189A8E950-0x0000000189A8E980
	public class X509Crl // TypeDefIndex: 1070
	{
		// Fields
		private string issuer; // 0x10
		private byte version; // 0x18
		private DateTime thisUpdate; // 0x20
		private DateTime nextUpdate; // 0x30
		private ArrayList entries; // 0x40
		private string signatureOID; // 0x48
		private byte[] signature; // 0x50
		private X509ExtensionCollection extensions; // 0x58
		private byte[] encoded; // 0x60
		private byte[] hash_value; // 0x68
	
		// Properties
		public X509ExtensionCollection Extensions { get => default; } // 0x000000018952EF70-0x000000018952EFD0 
		public byte[] Hash { get => default; } // 0x000000018952EFD0-0x000000018952F0E0 
		public string IssuerName { get => default; } // 0x000000018952F0E0-0x000000018952F140 
		public DateTime NextUpdate { get => default; } // 0x000000018952F140-0x000000018952F1B0 
	
		// Nested types
		public class X509CrlEntry // TypeDefIndex: 1071
		{
			// Fields
			private byte[] sn; // 0x10
			private DateTime revocationDate; // 0x18
			private X509ExtensionCollection extensions; // 0x28
	
			// Properties
			public byte[] SerialNumber { get => default; } // 0x000000018952DC50-0x000000018952DD10 
			public DateTime RevocationDate { get => default; } // 0x000000018952DBE0-0x000000018952DC50 
			public X509ExtensionCollection Extensions { get => default; } // 0x000000018952DB80-0x000000018952DBE0 
	
			// Constructors
			public X509CrlEntry() {} // Dummy constructor
			internal X509CrlEntry(ASN1 entry) {} // 0x000000018952DA60-0x000000018952DB80
		}
	
		// Constructors
		public X509Crl() {} // Dummy constructor
		public X509Crl(byte[] crl) {} // 0x000000018952EE70-0x000000018952EF70
	
		// Methods
		private void Parse(byte[] crl) {} // 0x000000018952E220-0x000000018952E840
		private bool Compare(byte[] array1, byte[] array2) => default; // 0x000000018952DD10-0x000000018952DDE0
		public X509CrlEntry GetCrlEntry(X509Certificate x509) => default; // 0x000000018952DDE0-0x000000018952DEB0
		public X509CrlEntry GetCrlEntry(byte[] serialNumber) => default; // 0x000000018952DEB0-0x000000018952E000
		private string GetHashName() => default; // 0x000000018952E000-0x000000018952E220
		internal bool VerifySignature(DSA dsa) => default; // 0x000000018952EB50-0x000000018952EE70
		internal bool VerifySignature(RSA rsa) => default; // 0x000000018952EA60-0x000000018952EB50
		public bool VerifySignature(AsymmetricAlgorithm aa) => default; // 0x000000018952E840-0x000000018952EA60
	}
}
