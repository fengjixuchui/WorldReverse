/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security
{
	public sealed class PKCS7 // TypeDefIndex: 1043
	{
		// Nested types
		public class ContentInfo // TypeDefIndex: 1044
		{
			// Fields
			private string contentType; // 0x10
			private ASN1 content; // 0x18
	
			// Properties
			public ASN1 ASN1 { get => default; } // 0x00000001873B3C30-0x00000001873B3CA0 
			public ASN1 Content { get => default; set {} } // 0x00000001873B3D00-0x00000001873B3D60 0x00000001873B3DC0-0x00000001873B3E20
			public string ContentType { get => default; set {} } // 0x00000001873B3CA0-0x00000001873B3D00 0x00000001873B3D60-0x00000001873B3DC0
	
			// Constructors
			public ContentInfo() {} // 0x00000001873B3840-0x00000001873B38D0
			public ContentInfo(string oid) {} // 0x00000001873B38D0-0x00000001873B3940
			public ContentInfo(byte[] data) {} // 0x00000001873B3940-0x00000001873B39E0
			public ContentInfo(ASN1 asn1) {} // 0x00000001873B39E0-0x00000001873B3C30
	
			// Methods
			internal ASN1 GetASN1() => default; // 0x00000001873B3770-0x00000001873B3840
		}
	
		public class EncryptedData // TypeDefIndex: 1045
		{
			// Fields
			private byte _version; // 0x10
			private ContentInfo _content; // 0x18
			private ContentInfo _encryptionAlgorithm; // 0x20
			private byte[] _encrypted; // 0x28
	
			// Properties
			public ContentInfo EncryptionAlgorithm { get => default; } // 0x00000001873B7160-0x00000001873B71C0 
			public byte[] EncryptedContent { get => default; } // 0x00000001873B70B0-0x00000001873B7160 
	
			// Constructors
			public EncryptedData() {} // 0x00000001873B6BE0-0x00000001873B6C50
			public EncryptedData(ASN1 asn1) {} // 0x00000001873B6C50-0x00000001873B70B0
		}
	
		// Constructors
		public PKCS7() {} // Dummy constructor
	}
}
