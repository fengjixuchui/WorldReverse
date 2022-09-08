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
using Mono.Security.Cryptography;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509
{
	public class PKCS12 : ICloneable // TypeDefIndex: 1062
	{
		// Fields
		private static int recommendedIterationCount; // 0x00
		private byte[] _password; // 0x10
		private ArrayList _keyBags; // 0x18
		private ArrayList _secretBags; // 0x20
		private X509CertificateCollection _certs; // 0x28
		private bool _keyBagsChanged; // 0x30
		private bool _secretBagsChanged; // 0x31
		private bool _certsChanged; // 0x32
		private int _iterations; // 0x34
		private ArrayList _safeBags; // 0x38
		private RandomNumberGenerator _rng; // 0x40
		private static int password_max_length; // 0x04
	
		// Properties
		public string Password { set {} } // 0x0000000186E180E0-0x0000000186E182B0
		public int IterationCount { get => default; set {} } // 0x0000000186E177E0-0x0000000186E17840 0x0000000186E18080-0x0000000186E180E0
		public ArrayList Keys { get => default; } // 0x0000000186E17840-0x0000000186E17F80 
		public X509CertificateCollection Certificates { get => default; } // 0x0000000186E17450-0x0000000186E177E0 
		internal RandomNumberGenerator RNG { get => default; } // 0x0000000186E18010-0x0000000186E18080 
		public static int MaximumPasswordLength { get => default; } // 0x0000000186E17F80-0x0000000186E18010 
	
		// Nested types
		public class DeriveBytes // TypeDefIndex: 1063
		{
			// Fields
			private static byte[] keyDiversifier; // 0x00
			private static byte[] ivDiversifier; // 0x08
			private static byte[] macDiversifier; // 0x10
			private string _hashName; // 0x10
			private int _iterations; // 0x18
			private byte[] _password; // 0x20
			private byte[] _salt; // 0x28
	
			// Properties
			public string HashName { set {} } // 0x0000000186E0D790-0x0000000186E0D7F0
			public int IterationCount { set {} } // 0x0000000186E0D7F0-0x0000000186E0D850
			public byte[] Password { set {} } // 0x0000000186E0D850-0x0000000186E0D920
			public byte[] Salt { set {} } // 0x0000000186E0D920-0x0000000186E0D9D0
	
			// Constructors
			public DeriveBytes() {} // 0x0000000186E0D730-0x0000000186E0D790
			static DeriveBytes() {} // 0x0000000186E0D610-0x0000000186E0D730
	
			// Methods
			private void Adjust(byte[] a, int aOff, byte[] b) {} // 0x0000000186E0CD10-0x0000000186E0CEA0
			private byte[] Derive(byte[] diversifier, int n) => default; // 0x0000000186E0D0B0-0x0000000186E0D610
			public byte[] DeriveKey(int size) => default; // 0x0000000186E0CF50-0x0000000186E0D000
			public byte[] DeriveIV(int size) => default; // 0x0000000186E0CEA0-0x0000000186E0CF50
			public byte[] DeriveMAC(int size) => default; // 0x0000000186E0D000-0x0000000186E0D0B0
		}
	
		// Constructors
		public PKCS12() {} // 0x0000000186E17290-0x0000000186E173B0
		public PKCS12(byte[] data) {} // 0x0000000186E171D0-0x0000000186E17290
		public PKCS12(byte[] data, string password) {} // 0x0000000186E173B0-0x0000000186E17450
		static PKCS12() {} // 0x0000000186E17150-0x0000000186E171D0
	
		// Methods
		private void Decode(byte[] data) {} // 0x0000000186E12690-0x0000000186E12FE0
		~PKCS12() {} // 0x0000000186E137D0-0x0000000186E138A0
		private bool Compare(byte[] expected, byte[] actual) => default; // 0x0000000186E125B0-0x0000000186E12690
		private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) => default; // 0x0000000186E15920-0x0000000186E15F70
		public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) => default; // 0x0000000186E12FE0-0x0000000186E13140
		public byte[] Decrypt(PKCS7.EncryptedData ed) => default; // 0x0000000186E13140-0x0000000186E132C0
		public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) => default; // 0x0000000186E132C0-0x0000000186E13420
		private DSAParameters GetExistingParameters(out bool found) {
			found = default;
			return default;
		} // 0x0000000186E156C0-0x0000000186E15920
		private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) {} // 0x0000000186E119F0-0x0000000186E11BC0
		private void ReadSafeBag(ASN1 safeBag) {} // 0x0000000186E161C0-0x0000000186E16BE0
		private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) => default; // 0x0000000186E11BC0-0x0000000186E12410
		private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) => default; // 0x0000000186E15F70-0x0000000186E161C0
		public byte[] GetBytes() => default; // 0x0000000186E138A0-0x0000000186E156C0
		private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) => default; // 0x0000000186E13420-0x0000000186E137D0
		public void AddCertificate(X509Certificate cert) {} // 0x0000000186E115D0-0x0000000186E11650
		public void AddCertificate(X509Certificate cert, IDictionary attributes) {} // 0x0000000186E11650-0x0000000186E119F0
		public void RemoveCertificate(X509Certificate cert) {} // 0x0000000186E170D0-0x0000000186E17150
		public void RemoveCertificate(X509Certificate cert, IDictionary attrs) {} // 0x0000000186E16BE0-0x0000000186E170D0
		public object Clone() => default; // 0x0000000186E12410-0x0000000186E125B0
	}
}
