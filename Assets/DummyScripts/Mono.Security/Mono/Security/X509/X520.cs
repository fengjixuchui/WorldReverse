/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Security;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509
{
	public class X520 // TypeDefIndex: 1077
	{
		// Nested types
		public abstract class AttributeTypeAndValue // TypeDefIndex: 1078
		{
			// Fields
			private string oid; // 0x10
			private string attrValue; // 0x18
			private int upperBound; // 0x20
			private byte encoding; // 0x24
	
			// Properties
			public string Value { get; set; } // 0x000000018952B430-0x000000018952B540
	
			// Constructors
			protected AttributeTypeAndValue() {} // Dummy constructor
			protected AttributeTypeAndValue(string oid, int upperBound) {} // 0x000000018952B3A0-0x000000018952B430
			protected AttributeTypeAndValue(string oid, int upperBound, byte encoding) {} // 0x000000018952B310-0x000000018952B3A0
	
			// Methods
			internal ASN1 GetASN1(byte encoding) => default; // 0x000000018952B020-0x000000018952B250
			internal ASN1 GetASN1() => default; // 0x000000018952AFB0-0x000000018952B020
			private byte SelectBestEncoding() => default; // 0x000000018952B250-0x000000018952B310
		}
	
		public class CommonName : AttributeTypeAndValue // TypeDefIndex: 1079
		{
			// Constructors
			public CommonName() {} // 0x000000018952B540-0x000000018952B600
		}
	
		public class LocalityName : AttributeTypeAndValue // TypeDefIndex: 1080
		{
			// Constructors
			public LocalityName() {} // 0x000000018952BA80-0x000000018952BB40
		}
	
		public class StateOrProvinceName : AttributeTypeAndValue // TypeDefIndex: 1081
		{
			// Constructors
			public StateOrProvinceName() {} // 0x000000018952BD80-0x000000018952BE40
		}
	
		public class OrganizationName : AttributeTypeAndValue // TypeDefIndex: 1082
		{
			// Constructors
			public OrganizationName() {} // 0x000000018952BC00-0x000000018952BCC0
		}
	
		public class OrganizationalUnitName : AttributeTypeAndValue // TypeDefIndex: 1083
		{
			// Constructors
			public OrganizationalUnitName() {} // 0x000000018952BCC0-0x000000018952BD80
		}
	
		public class EmailAddress : AttributeTypeAndValue // TypeDefIndex: 1084
		{
			// Constructors
			public EmailAddress() {} // 0x000000018952B840-0x000000018952B900
		}
	
		public class DomainComponent : AttributeTypeAndValue // TypeDefIndex: 1085
		{
			// Constructors
			public DomainComponent() {} // 0x000000018952B780-0x000000018952B840
		}
	
		public class UserId : AttributeTypeAndValue // TypeDefIndex: 1086
		{
			// Constructors
			public UserId() {} // 0x000000018952BFC0-0x000000018952C080
		}
	
		public class Oid : AttributeTypeAndValue // TypeDefIndex: 1087
		{
			// Constructors
			public Oid() {} // Dummy constructor
			public Oid(string oid) {} // 0x000000018952BB40-0x000000018952BC00
		}
	
		public class Title : AttributeTypeAndValue // TypeDefIndex: 1088
		{
			// Constructors
			public Title() {} // 0x000000018952BF00-0x000000018952BFC0
		}
	
		public class CountryName : AttributeTypeAndValue // TypeDefIndex: 1089
		{
			// Constructors
			public CountryName() {} // 0x000000018952B600-0x000000018952B6C0
		}
	
		public class DnQualifier : AttributeTypeAndValue // TypeDefIndex: 1090
		{
			// Constructors
			public DnQualifier() {} // 0x000000018952B6C0-0x000000018952B780
		}
	
		public class Surname : AttributeTypeAndValue // TypeDefIndex: 1091
		{
			// Constructors
			public Surname() {} // 0x000000018952BE40-0x000000018952BF00
		}
	
		public class GivenName : AttributeTypeAndValue // TypeDefIndex: 1092
		{
			// Constructors
			public GivenName() {} // 0x000000018952B900-0x000000018952B9C0
		}
	
		public class Initial : AttributeTypeAndValue // TypeDefIndex: 1093
		{
			// Constructors
			public Initial() {} // 0x000000018952B9C0-0x000000018952BA80
		}
	
		// Constructors
		public X520() {} // Dummy constructor
	}
}
