/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using Mono.Security;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509
{
	public class X509Certificate : ISerializable // TypeDefIndex: 1065
	{
		// Fields
		private ASN1 decoder; // 0x10
		private byte[] m_encodedcert; // 0x18
		private DateTime m_from; // 0x20
		private DateTime m_until; // 0x30
		private ASN1 issuer; // 0x40
		private string m_issuername; // 0x48
		private string m_keyalgo; // 0x50
		private byte[] m_keyalgoparams; // 0x58
		private ASN1 subject; // 0x60
		private string m_subject; // 0x68
		private byte[] m_publickey; // 0x70
		private byte[] signature; // 0x78
		private string m_signaturealgo; // 0x80
		private byte[] m_signaturealgoparams; // 0x88
		private byte[] certhash; // 0x90
		private RSA _rsa; // 0x98
		private DSA _dsa; // 0xA0
		private int version; // 0xA8
		private byte[] serialnumber; // 0xB0
		private byte[] issuerUniqueID; // 0xB8
		private byte[] subjectUniqueID; // 0xC0
		private X509ExtensionCollection extensions; // 0xC8
		private static string encoding_error; // 0x00
	
		// Properties
		public DSA DSA { get => default; set {} } // 0x0000000186E32C80-0x0000000186E32FF0 0x0000000186E341C0-0x0000000186E34240
		public X509ExtensionCollection Extensions { get => default; } // 0x0000000186E32FF0-0x0000000186E33050 
		public byte[] Hash { get => default; } // 0x0000000186E33050-0x0000000186E33430 
		public virtual string IssuerName { get => default; } // 0x0000000186E335A0-0x0000000186E33600 
		public virtual string KeyAlgorithm { get => default; } // 0x0000000186E336B0-0x0000000186E33710 
		public virtual byte[] KeyAlgorithmParameters { get => default; set {} } // 0x0000000186E33600-0x0000000186E336B0 0x0000000186E34240-0x0000000186E342A0
		public virtual byte[] PublicKey { get => default; } // 0x0000000186E33710-0x0000000186E337C0 
		public virtual RSA RSA { get => default; set {} } // 0x0000000186E337C0-0x0000000186E339B0 0x0000000186E342A0-0x0000000186E34320
		public virtual byte[] RawData { get => default; } // 0x0000000186E339B0-0x0000000186E33A60 
		public virtual byte[] SerialNumber { get => default; } // 0x0000000186E33A60-0x0000000186E33B10 
		public virtual byte[] Signature { get => default; } // 0x0000000186E33B70-0x0000000186E34020 
		public virtual string SignatureAlgorithm { get => default; } // 0x0000000186E33B10-0x0000000186E33B70 
		public virtual string SubjectName { get => default; } // 0x0000000186E34020-0x0000000186E34080 
		public virtual DateTime ValidFrom { get => default; } // 0x0000000186E34080-0x0000000186E340F0 
		public virtual DateTime ValidUntil { get => default; } // 0x0000000186E340F0-0x0000000186E34160 
		public int Version { get => default; } // 0x0000000186E34160-0x0000000186E341C0 
		public bool IsCurrent { get => default; } // 0x0000000186E33430-0x0000000186E334D0 
		public bool IsSelfSigned { get => default; } // 0x0000000186E334D0-0x0000000186E335A0 
	
		// Constructors
		public X509Certificate() {} // Dummy constructor
		public X509Certificate(byte[] data) {} // 0x0000000186E32B30-0x0000000186E32C80
		static X509Certificate() {} // 0x0000000186E32AB0-0x0000000186E32B30
	
		// Methods
		private void Parse(byte[] data) {} // 0x0000000186E319B0-0x0000000186E32210
		private byte[] GetUnsignedBigInteger(byte[] integer) => default; // 0x0000000186E31720-0x0000000186E31800
		public bool WasCurrent(DateTime instant) => default; // 0x0000000186E32960-0x0000000186E32AB0
		internal bool VerifySignature(DSA dsa) => default; // 0x0000000186E32860-0x0000000186E32960
		internal bool VerifySignature(RSA rsa) => default; // 0x0000000186E32430-0x0000000186E32860
		public bool VerifySignature(AsymmetricAlgorithm aa) => default; // 0x0000000186E32210-0x0000000186E32430
		public ASN1 GetIssuerName() => default; // 0x0000000186E315D0-0x0000000186E31630
		public ASN1 GetSubjectName() => default; // 0x0000000186E316C0-0x0000000186E31720
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000186E31630-0x0000000186E316C0
		private static byte[] PEM(string type, byte[] data) => default; // 0x0000000186E31800-0x0000000186E319B0
	}
}
